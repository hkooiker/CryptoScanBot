﻿using CryptoScanBot.Context;
using CryptoScanBot.Enums;
using CryptoScanBot.Model;
using Dapper.Contrib.Extensions;

namespace CryptoScanBot.Intern;

public class BarometerTools
{

    private static readonly object LockObject = new();
    private delegate bool CalcBarometerMethod(CryptoQuoteData quoteData, SortedList<string, CryptoSymbol> symbols, CryptoInterval interval, long unixCandleLast, out decimal barometerPerc);


    private static CryptoSymbol CheckSymbolPrecence(string baseName, CryptoQuoteData quoteData)
    {
        if (GlobalData.ExchangeListName.TryGetValue(GlobalData.Settings.General.ExchangeName, out Model.CryptoExchange exchange))
        {
            if (!exchange.SymbolListName.TryGetValue(baseName + quoteData.Name, out CryptoSymbol symbol))
            {
                using CryptoDatabase databaseThread = new();
                databaseThread.Close();
                databaseThread.Open();
                using var transaction = databaseThread.BeginTransaction();
                
                symbol = new CryptoSymbol
                {
                    Exchange = exchange,
                    ExchangeId = exchange.Id,
                    Base = baseName, //De "munt"
                    Quote = quoteData.Name, //USDT, BTC etc.
                    Volume = 0,
                };
                symbol.Name = symbol.Base + symbol.Quote;

                databaseThread.Connection.Insert<CryptoSymbol>(symbol, transaction);
                transaction.Commit();

                GlobalData.AddSymbol(symbol);
            }
            symbol.Status = 1;
            return symbol;
        }
        return null;
    }


    private bool CalculatePriceBarometer(CryptoQuoteData quoteData, SortedList<string, CryptoSymbol> symbols, CryptoInterval interval, long unixCandleLast, out decimal barometerPerc)
    {
        // Wat is de candle in het vorige interval
        long unixCandlePrev = unixCandleLast - interval.Duration;

        // Ter debug van de intervallen (unix datetime's zijn niet zo goed leesbaar)
        //DateTime dateCandlePrev = CandleTools.GetUnixDate(unixCandlePrev);
        //DateTime dateCandleLast = CandleTools.GetUnixDate(unixCandleLast);

        decimal sumPerc = 0;
        int coinsMatching = 0;

        // De prijs en/of volume sommeren over alle munten
        for (int i = 0; i < quoteData.SymbolList.Count; i++) // een foreach variant met een ToList() kost extra cpu
        {
            CryptoSymbol symbol = quoteData.SymbolList[i];
            if (symbol.CandleList.TryGetValue(unixCandlePrev, out CryptoCandle candlePrev) && symbol.CandleList.TryGetValue(unixCandleLast, out CryptoCandle candleLast))
            {
                if (candlePrev != null && candleLast != null) // Er worden in kucoin null candles toegevoegd?
                {
                    decimal perc;
                    decimal diff = candleLast.Close - candlePrev.Close;
                    if (!candlePrev.Close.Equals(0))
                        perc = 100m * (diff / candlePrev.Close);
                    else perc = 0;

                    sumPerc += perc;
                    coinsMatching++;
                }
            }
        }

        if (coinsMatching > 0)
        {
            decimal result = sumPerc / coinsMatching;
            barometerPerc = decimal.Round(result, 8);
        }
        else
            barometerPerc = 0m; // Geen -99 want dan is short juist aantrekkelijk..

        return coinsMatching > 0; // Met 1 munt krijgen we okay, mhhhh geeft een aardig vertekend beeld in dat geval..
    }


    private static void CalculateBarometerInternal(CryptoSymbol bmSymbol, CryptoInterval interval, CryptoQuoteData quoteData, CalcBarometerMethod calcBarometerMethod, bool pricebarometer)
    {
        CryptoSymbolInterval symbolInterval = bmSymbol.GetSymbolInterval(interval.IntervalPeriod);
        SortedList<long, CryptoCandle> candles = symbolInterval.CandleList;

        // Remove old candles (< 24 hours, 1440 candles)
        long startFetchUnix = CandleIndicatorData.GetCandleFetchStart(bmSymbol, interval, DateTime.UtcNow);
        while (candles.Values.Count > 0)
        {
            CryptoCandle c = candles.Values[0];
            if (c.OpenTime < startFetchUnix)
                candles.Remove(c.OpenTime);
            else break;
        }



        BarometerData barometerData = quoteData.BarometerList[interval.IntervalPeriod];

        // Begin van de candle in interval X, bereken het laatste interval opnieuw (bewust)
        long periodStart;
        if (symbolInterval.LastCandleSynchronized.HasValue)
            periodStart = (long)symbolInterval.LastCandleSynchronized;
        else
        {
            // Geef deze alvast een waarde
            if (candles.Values.Any())
                periodStart = candles.Values.First().OpenTime;
            else
                periodStart = CandleTools.GetUnixTime(DateTime.UtcNow.AddDays(-2), 60);

            symbolInterval.IsChanged = true;
            symbolInterval.LastCandleSynchronized = periodStart;
        }
        //DateTime periodStartDebug = CandleTools.GetUnixDate(periodStart);

        // De laatste candle die we moeten berekenen. Mogelijk 1 te hoog, wat "valse" waarden kan geven?
        // Dat kan opgelost worden door de laatst aangekomen candle mee te geven (vanuit de 1m stream)
        long periodStop = CandleTools.GetUnixTime(DateTime.UtcNow, 60);
        //DateTime periodStopDebug = CandleTools.GetUnixDate(periodStop);

        // De opgegeven periode per minuut itereren
        while (periodStart <= periodStop)
        {
            //periodStartDebug = CandleTools.GetUnixDate(periodStart);

            // Bereken de 1e waarde (alleen candle aanmaken als er candles bestaan voor beide intervallen)
            if (calcBarometerMethod(quoteData, bmSymbol.Exchange.SymbolListName, interval, periodStart, out decimal BarometerPerc))
            {
                // De candle aanmaken of bijwerken
                if (!candles.TryGetValue(periodStart, out CryptoCandle candle))
                {
                    candle = new CryptoCandle
                    {
#if SQLDATABASE
                        ExchangeId = bmSymbol.ExchangeId,
                        SymbolId = bmSymbol.Id,
                        IntervalId = interval.Id,
#endif
                        //Symbol = bmSymbol,
                        //Interval = interval,
                        OpenTime = periodStart,
                    };
                    candles.Add(candle.OpenTime, candle);
                }

                // Alle waarden invullen
                candle.Open = BarometerPerc;
                candle.High = BarometerPerc;
                candle.Low = BarometerPerc;
                candle.Close = BarometerPerc;

                // Administratie bijwerken
                if (pricebarometer)
                {
                    barometerData.PriceDateTime = periodStart;
                    barometerData.PriceBarometer = BarometerPerc;
                }
                else
                {
                    barometerData.VolumeDateTime = periodStart;
                    barometerData.VolumeBarometer = BarometerPerc;
                }

                // Willen we dat hier wel bijwerken, zie ook opmerking hierboven
                if (periodStart > symbolInterval.LastCandleSynchronized)
                {
                    symbolInterval.IsChanged = true;
                    symbolInterval.LastCandleSynchronized = periodStart;
                }
#if SQLDATABASE
                // Experimenteel (de berekening van LastFetched gaat fout voor de barometers!)
                GlobalData.TaskSaveCandles.AddToQueue(candle);
#endif
            }

            // Naar de volgende 1m candle 
            periodStart += 60;
        }
    }

    /// <summary>
    /// Deze routine maakt barometer per 1m (ondanks dat we met de IntervalPeriod suggereren dat we het in een bepaald interval doen)
    /// </summary>
    private static void CalculateBarometerIntervals(CryptoSymbol symbol, CryptoQuoteData quoteData, CalcBarometerMethod calcBarometerMethod, bool pricebarometer)
    {

        // Herbereken de candles in de andere intervallen (voor de 15m, 30m, 1h, 4h en 1d)
        foreach (CryptoInterval interval in GlobalData.IntervalList)
        {
            if ((interval.IntervalPeriod == CryptoIntervalPeriod.interval15m) ||
                (interval.IntervalPeriod == CryptoIntervalPeriod.interval30m) ||
                (interval.IntervalPeriod == CryptoIntervalPeriod.interval1h) ||
                (interval.IntervalPeriod == CryptoIntervalPeriod.interval4h) ||
                (interval.IntervalPeriod >= CryptoIntervalPeriod.interval1d))
            {
                //if (interval.IntervalPeriod == CryptoIntervalPeriod.interval1h)
                //GlobalData.AddTextToLogTab("Calculating barometer chart " + bmSymbol.Name + " " + interval.Name);
                CalculateBarometerInternal(symbol, interval, quoteData, calcBarometerMethod, pricebarometer);
            }
        }
    }


    public void ExecuteInternal()
    {
        // Bereken de (prijs en volume) barometers voor de aangevinkte basismunten

        //GlobalData.AddTextToLogTab("Calculating barometer charts start");
        foreach (CryptoQuoteData quoteData in GlobalData.Settings.QuoteCoins.Values.ToList())
        {
            if (quoteData.FetchCandles)
            {
                //Monitor.Enter(quoteData.SymbolList);
                //try
                //{
                //GlobalData.AddTextToLogTab(string.Format("Calculating barometer charts start for {0}", quoteData.Name));

                // Controleer of de prijs barometer symbol bestaat en berekenen
                //GlobalData.AddTextToLogTab("Calculating price barometer chart " + baseCoin");
                CryptoSymbol symbol = CheckSymbolPrecence(Constants.SymbolNameBarometerPrice, quoteData);
                if (symbol != null)
                {
                    //Monitor.Enter(symbol.CandleList);
                    //try
                    //{
                    CalculateBarometerIntervals(symbol, quoteData, CalculatePriceBarometer, true);
                    //}
                    //finally
                    //{
                    //    Monitor.Exit(symbol.CandleList);
                    //}
                }

                // Ik weet niet wat ik met de volume barometer kan (of moet aanvangen, laat maar achterwege)
                // Controleer of de volume barometer symbol bestaat en berekenen (CPU gaat behoorlijk omhoog)
                //GlobalData.AddTextToLogTab("Calculating volume barometer chart " + baseCoin");
                //symbol = CheckSymbolPrecence(Constants.SymbolNameBarometerVolume, quoteData);
                //if (symbol != null)
                //{
                //    Monitor.Enter(symbol.CandleList);
                //    try
                //    {
                //        CalculateBarometerIntervals(symbol, quoteData, CalculateVolumeBarometer, false);
                //    }
                //    finally
                //    {
                //        Monitor.Exit(symbol.CandleList);
                //    }
                //}
                //}
                //finally
                //{
                //    Monitor.Exit(quoteData.SymbolList);
                //}
            }
        }

        // Nu de barometer uitgerekend is mag het aantal 1m candles naar beneden
        CandleIndicatorData.SetInitialCandleCountFetch(24 * 60 * 60 + 10 * 60); // 10 extra, maar dat is een quick en dirty fix voor iets anders
    }


    public void ExecuteAsync()
    {
        try
        {
            if (Monitor.TryEnter(LockObject))
            {
                try
                {
                    ExecuteInternal();
                }
                finally
                {
                    Monitor.Exit(LockObject);
                }
            }
        }
        catch (Exception error)
        {
            ScannerLog.Logger.Error(error, "");
            GlobalData.AddTextToLogTab("");
            GlobalData.AddTextToLogTab(error.ToString());
        }
    }
}
