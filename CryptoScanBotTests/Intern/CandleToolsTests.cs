﻿using Microsoft.VisualStudio.TestTools.UnitTesting;


using CryptoScanBot.Model;
using CryptoScanBot.Enums;
using CryptoScanBotTests;
using CryptoScanBot.Context;

namespace CryptoScanBot.Intern.Tests;

[TestClass()]
public class CandleToolsTests : TestBase
{
    [TestMethod()]
    public void CalculateCandleForIntervalTest()
    {
        InitTestSession();
        CryptoDatabase database = new();
        database.Open();

        // arrange
        CryptoSymbol symbol = CreateTestSymbol(database);

        // act

        decimal value = 19000;
        DateTime startTime = new(2023, 08, 27, 00, 00, 00, DateTimeKind.Utc);
        long startTimeUnix = CandleTools.GetUnixTime(startTime, 60);
        for (int count = 60; count <= 24*60*60; count+=60) // een complete dag
        {
            startTime = CandleTools.GetUnixDate(startTimeUnix);
            CryptoCandle candle = CandleTools.HandleFinalCandleData(symbol, GlobalData.IntervalList[0], startTime, value, value, value, value, 1, false);
            CandleTools.UpdateCandleFetched(symbol, GlobalData.IntervalList[0]);
            string text = $"ticker(1m):" + candle.OhlcText(symbol, GlobalData.IntervalList[0], symbol.PriceDisplayFormat, true, false, true);
            Console.WriteLine(text);

            // Calculate higher timeframes
            long candle1mCloseTime = candle.OpenTime + 60;
            foreach (CryptoInterval interval in GlobalData.IntervalList)
            {
                if (interval.ConstructFrom != null && candle1mCloseTime % interval.Duration == 0)
                {
                    // Deze doet een call naar de TaskSaveCandles en de UpdateCandleFetched (overlappend?)
                    CryptoCandle candleX = CandleTools.CalculateCandleForInterval(interval, interval.ConstructFrom, symbol, candle1mCloseTime);
                    CandleTools.UpdateCandleFetched(symbol, interval);
                    string text2 = $"ticker({interval.Name}):" + candleX.OhlcText(symbol, interval, symbol.PriceDisplayFormat, true, false, true);
                    Console.WriteLine(text2);
                }
            }

            startTimeUnix += 60;


            // Assert
            foreach (CryptoInterval interval in GlobalData.IntervalList)
            {
                CryptoSymbolInterval symbolPeriod = symbol.GetSymbolInterval(interval.IntervalPeriod);
                Assert.AreEqual(count / symbolPeriod.Interval.Duration, symbolPeriod.CandleList.Count, $"Aantal candles in de {symbolPeriod.Interval}");

                foreach (var c in symbolPeriod.CandleList.Values)
                {
                    long unix = c.OpenTime;
                    long diff = unix % interval.Duration;
                    Assert.AreEqual(0, diff, $"Candle.OpenTime");

                    Assert.AreEqual(value, c.Open, $"Candle.Open");
                    Assert.AreEqual(value, c.High, $"Candle.High");
                    Assert.AreEqual(value, c.Low, $"Candle.Low");
                    Assert.AreEqual(value, c.Close, $"Candle.Close");
                    
                    Assert.AreEqual(interval.Duration / 60, c.Volume, $"Candle.Volume");
                }
            }
        }
    }

}