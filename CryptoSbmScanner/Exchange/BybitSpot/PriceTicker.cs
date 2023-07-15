﻿using CryptoSbmScanner.Intern;
using CryptoSbmScanner.Model;

namespace CryptoSbmScanner.Exchange.BybitSpot;

internal class PriceTicker : PriceTickerBase
{
    static private List<PriceTickerStream> TickerList { get; set; } = new();

    public override async Task Start()
    {
        GlobalData.AddTextToLogTab("Bybit starting price ticker");
        if (GlobalData.ExchangeListName.TryGetValue(Api.ExchangeName, out Model.CryptoExchange exchange))
        {
            int count = 0;
            List<Task> taskList = new();
            foreach (CryptoQuoteData quoteData in GlobalData.Settings.QuoteCoins.Values)
            {
                if (quoteData.FetchCandles && quoteData.SymbolList.Count > 0)
                {
                    List<CryptoSymbol> symbols = quoteData.SymbolList.ToList();

                    // We krijgen soms timeouts (eigenlijk de library) omdat we teveel 
                    // symbols aanbieden, daarom splitsen we het hier de lijst in twee stukken.
                    //int splitCount = 200;
                    //if (symbols.Count > splitCount)
                    //    splitCount = 1 + (symbols.Count / 2);

                    //raar..
                    while (symbols.Count > 0)
                    {
                        PriceTickerStream ticker = new();
                        TickerList.Add(ticker);

                        // Op deze exchange is er een limiet van 10 symbols, dus opknippen in (veel) stukjes
                        while (symbols.Count > 0)
                        {
                            CryptoSymbol symbol = symbols[0];
                            ticker.Symbols.Add(symbol.Name);
                            symbols.Remove(symbol);
                            count++;

                            if (ticker.Symbols.Count >= 10)
                                break;
                        }

                        // opvullen tot circa 150 coins?
                        //ExchangeStream1mCandles.Add(bybitStream1mCandles);
                        //await bybitStream1mCandles.StartAsync(); // bewust geen await

                        //await TaskBybitStreamPriceTicker.ExecuteAsync(symbolNames);

                        Task task = Task.Run(async () => { await ticker.StartAsync(); });
                        taskList.Add(task);
                    }
                }
            }

            if (taskList.Any())
            {
                await Task.WhenAll(taskList);
                GlobalData.AddTextToLogTab(string.Format("Bybit started price ticker stream for {0} symbols", count));
            }
        }
    }



    public override async Task Stop()
    {
        GlobalData.AddTextToLogTab("Bybit stopping price ticker");
        List<Task> taskList = new();
        foreach (var ticker in TickerList)
        {
            Task task = Task.Run(async () => { await ticker.StopAsync(); });
            taskList.Add(task);
        }
        if (taskList.Any())
            await Task.WhenAll(taskList);
        TickerList.Clear();
    }

    
    public override void Reset()
    {
        foreach (var ticker in TickerList)
            ticker.TickerCount = 0;
    }


    public override int Count()
    {
        int count = 0;
        foreach (var ticker in TickerList)
            count += ticker.TickerCount;
        return count;
    }
}