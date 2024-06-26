﻿using CryptoScanBot.Enums;
using CryptoScanBot.Intern;
using CryptoScanBot.Model;

namespace CryptoScanBot.Settings;

public class CryptoExternalUrl
{
    // Alleen HyperTrader gebruikt een execute link
    public CryptoExternalUrlType Execute { get; set; } = CryptoExternalUrlType.External;
    public string Url { get; set; }
    public string Telegram { get; set; }
}

public class CryptoExternalUrls
{
    public CryptoExternalUrl Altrady { get; set; }
    public CryptoExternalUrl HyperTrader { get; set; }
    public CryptoExternalUrl TradingView { get; set; }
    public CryptoExternalUrl ExchangeUrl { get; set; }
}

public class CryptoExternalUrlList : SortedList<string, CryptoExternalUrls>
{

    public void InitializeUrls()
    {
        this.Remove("Binance");
        this.TryAdd("Binance Spot",
            new()
            {
                Altrady = new()
                {
                    Execute = CryptoExternalUrlType.Internal,
                    Url = "https://app.altrady.com/d/BINA_{QUOTE}_{BASE}:{interval}",
                },
                HyperTrader = new()
                {
                    Execute = CryptoExternalUrlType.External,
                    Url = "hypertrader://binance/{BASE}-{QUOTE}/{interval}",
                    Telegram = "http://www.ccscanner.nl/hypertrader/?e=binance&a={BASE}&b={QUOTE}&i={interval}",
                },
                TradingView = new()
                {
                    Execute = CryptoExternalUrlType.External,
                    Url = "https://www.tradingview.com/chart/?symbol=BINANCE:{BASE}{QUOTE}&interval={interval}"
                },
                ExchangeUrl = new()
                {
                    Execute = CryptoExternalUrlType.External,
                    Url = "https://www.binance.com/en/trade/{BASE}_{QUOTE}?_from=markets&type=spot",
                }
            }
        );

        this.TryAdd("Binance Futures",
            new()
            {
                Altrady = new() // werkt niet
                {
                    Execute = CryptoExternalUrlType.Internal,
                    Url = "https://app.altrady.com/d/BINAF_{QUOTE}_{BASE}:{interval}",
                },
                HyperTrader = new() // werkt niet
                {
                    Execute = CryptoExternalUrlType.External,
                    Url = "hypertrader://binance/{BASE}-{QUOTE}/{interval}",
                    Telegram = "http://www.ccscanner.nl/hypertrader/?e=binance&a={BASE}&b={QUOTE}&i={interval}",
                },
                TradingView = new() // werkt
                {
                    Execute = CryptoExternalUrlType.External,
                    Url = "https://www.tradingview.com/chart/?symbol=BINANCE:{BASE}{QUOTE}.P&interval={interval}"
                },
                ExchangeUrl = new() // werkt niet
                {
                    Execute = CryptoExternalUrlType.External,
                    Url = "https://www.binance.com/en/trade/{BASE}_{QUOTE}?_from=markets&type=futures",
                }
            }
        );

        this.TryAdd("Bybit Futures",
            new()
            {
                Altrady = new()
                {
                    Execute = CryptoExternalUrlType.Internal,
                    Url = "https://app.altrady.com/d/BYBIF_{QUOTE}_{BASE}:{interval}",
                },
                HyperTrader = new()
                {
                    Execute = CryptoExternalUrlType.External,
                    Url = "hypertrader://bybit/{BASE}-{QUOTE}/{interval}",
                    Telegram = "http://www.ccscanner.nl/hypertrader/?e=bybit&a={BASE}&b={QUOTE}&i={interval}",
                },
                TradingView = new()
                {
                    Execute = CryptoExternalUrlType.External,
                    Url = "https://www.tradingview.com/chart/?symbol=BYBIT:{BASE}{QUOTE}.P&interval={interval}",
                },
                ExchangeUrl = new()
                {
                    Execute = CryptoExternalUrlType.External,
                    Url = "https://www.bybit.com/trade/{quote}/{BASE}{QUOTE}",
                }
            }
        );

        this.Remove("Bybit");
        this.TryAdd("Bybit Spot",
            new()
            {
                Altrady = new()
                {
                    Execute = CryptoExternalUrlType.Internal,
                    Url = "https://app.altrady.com/d/BYBI_{QUOTE}_{BASE}:{interval}",
                },
                HyperTrader = new()
                {
                    Execute = CryptoExternalUrlType.External,
                    Url = "hypertrader://bybit-spot/{BASE}-{QUOTE}/{interval}",
                    Telegram = "http://www.ccscanner.nl/hypertrader/?e=bybit-spot&a={BASE}&b={QUOTE}&i={interval}",
                },
                TradingView = new()
                {
                    Execute = CryptoExternalUrlType.External,
                    Url = "https://www.tradingview.com/chart/?symbol=BYBIT:{BASE}{QUOTE}&interval={interval}",
                },
                ExchangeUrl = new()
                {
                    Execute = CryptoExternalUrlType.External,
                    Url = "https://www.bybit.com/trade/spot/{BASE}/{QUOTE}",
                }
            }
        );

        this.Remove("Kucoin");
        this.TryAdd("Kucoin Spot",
            new()
            {
                Altrady = new()
                {
                    Execute = CryptoExternalUrlType.Internal,
                    Url = "https://app.altrady.com/d/KUCN_{QUOTE}_{BASE}:{interval}",
                },
                HyperTrader = new()
                {
                    Execute = CryptoExternalUrlType.External,
                    Url = "hypertrader://kucoin/{BASE}-{QUOTE}/{interval}",
                    Telegram = "http://www.ccscanner.nl/hypertrader/?e=kucoin&a={BASE}&b={QUOTE}&i={interval}",
                },
                TradingView = new()
                {
                    Execute = CryptoExternalUrlType.External,
                    Url = "https://www.tradingview.com/chart/?symbol=KUCOIN:{BASE}{QUOTE}&interval={interval}",
                },
                ExchangeUrl = new()
                {
                    // Geen idee
                    Execute = CryptoExternalUrlType.External,
                    Url = "https://www.kucoin.com/trade/{QUOTE}/{BASE}&interval={interval}",
                }
            }
        );
    }

    public string GetTradingAppName(CryptoTradingApp tradingApp, string exchangeName)
    {
        string text = tradingApp switch
        {
            CryptoTradingApp.Altrady => "Altrady",
            CryptoTradingApp.Hypertrader => "Hypertrader",
            CryptoTradingApp.TradingView => "TradingView",
            CryptoTradingApp.ExchangeUrl => exchangeName,
            _ => "",
        };
        return text;
    }

    //altrady://market/BINA_ETH_LOKA:2
    //http://www.ccscanner.nl/hypertrader/?e=binance&a=lto&b=usdt&i=60
    ///hypertrader://binance/BETA-BTC/5
    ///https://app.altrady.com/d/BINA_BTC_BETA:1
    ///https://app.altrady.com/d/BINA_BTC_USDT:2
    ///https://app.muunship.com/chart/BN-BETABTC?l=5&resolution=1
    ///https://www.tradingview.com/chart/?symbol=BINANCE:BETABTC&interval=1

    public (string Url, CryptoExternalUrlType Execute) GetExternalRef(CryptoTradingApp externalApp, bool telegram, CryptoSymbol symbol, CryptoInterval interval)
    {
        Model.CryptoExchange exchange = symbol.Exchange;
        if (GlobalData.Settings.General.ActivateExchange > 0)
        {
            if (!GlobalData.ExchangeListId.TryGetValue(GlobalData.Settings.General.ActivateExchange, out exchange))
                return ("", CryptoExternalUrlType.Internal);
        }
        return GetExternalRef(exchange, externalApp, telegram, symbol, interval);
    }


    public (string Url, CryptoExternalUrlType Execute) GetExternalRef(Model.CryptoExchange exchange, CryptoTradingApp externalApp, bool telegram, CryptoSymbol symbol, CryptoInterval interval)
    {
        GlobalData.LoadLinkSettings();
        if (GlobalData.ExternalUrls.TryGetValue(exchange.Name, out CryptoExternalUrls externalUrls))
        {

            CryptoExternalUrl externalUrl = externalApp switch
            {
                CryptoTradingApp.Altrady => externalUrls.Altrady,
                CryptoTradingApp.Hypertrader => externalUrls.HyperTrader,
                CryptoTradingApp.TradingView => externalUrls.TradingView,
                CryptoTradingApp.ExchangeUrl => externalUrls.ExchangeUrl,
                _ => null
            };

            if (externalUrl == null)
                return ("", CryptoExternalUrlType.Internal);


            string urlTemplate = externalUrl.Url;
            if (telegram && externalUrl.Telegram != null && externalUrl.Telegram != "")
                urlTemplate = externalUrl.Telegram;

            urlTemplate = urlTemplate.Replace("{name}", symbol.Name.ToLower());
            urlTemplate = urlTemplate.Replace("{base}", symbol.Base.ToLower());
            urlTemplate = urlTemplate.Replace("{quote}", symbol.Quote.ToLower());

            urlTemplate = urlTemplate.Replace("{NAME}", symbol.Name.ToUpper());
            urlTemplate = urlTemplate.Replace("{BASE}", symbol.Base.ToUpper());
            urlTemplate = urlTemplate.Replace("{QUOTE}", symbol.Quote.ToUpper());

            string intervalCode = ((int)(interval.Duration / 60)).ToString();
            urlTemplate = urlTemplate.Replace("{interval}", intervalCode.ToLower());
            urlTemplate = urlTemplate.Replace("{INTERVAL}", intervalCode.ToUpper());
            return (urlTemplate, externalUrl.Execute);
        }

        return ("", CryptoExternalUrlType.Internal);
    }

}
