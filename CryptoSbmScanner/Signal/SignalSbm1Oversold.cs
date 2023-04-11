﻿using CryptoSbmScanner.Intern;
using CryptoSbmScanner.Model;

namespace CryptoSbmScanner.Signal;


// De officiele SBM methode van Maurice Orsel

public class SignalSbm1Oversold : SignalSbmBaseOversold
{
    public SignalSbm1Oversold(CryptoSymbol symbol, CryptoInterval interval, CryptoCandle candle) : base(symbol, interval, candle)
    {
        SignalMode = SignalMode.modeLong;
        SignalStrategy = SignalStrategy.sbm1Oversold;
    }


    public bool HadStobbInThelastXCandles(int candleCount)
    {
        // Is de prijs onlangs dicht bij de onderste bb geweest?
        CryptoCandle last = CandleLast;
        while (candleCount > 0)
        {
            // Er een candle onder de bb opent of sluit & een oversold situatie (beide moeten onder de 20 zitten)
            if ((last.IsBelowBollingerBands(GlobalData.Settings.Signal.SbmUseLowHigh)) && (last.IsStochOversold()))
                return true;

            if (!GetPrevCandle(last, out last))
                return false;
            candleCount--;
        }

        return false;
    }



    public override bool IsSignal()
    {
        if (!base.IsSignal())
            return false;

        if (!HadStobbInThelastXCandles(GlobalData.Settings.Signal.Sbm1CandlesLookbackCount))
        {
            ExtraText = "geen stob in de laatste x candles";
            return false;
        }

        return true;
    }


}