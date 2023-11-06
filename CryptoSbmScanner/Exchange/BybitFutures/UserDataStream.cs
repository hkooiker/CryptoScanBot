﻿using System.Text.Encodings.Web;
using System.Text.Json;

using Bybit.Net.Clients;
using Bybit.Net.Enums;
using Bybit.Net.Objects.Models.Socket;

using CryptoExchange.Net.Objects;
using CryptoExchange.Net.Sockets;
using CryptoSbmScanner.Intern;
using CryptoSbmScanner.Model;

namespace CryptoSbmScanner.Exchange.BybitFutures;
#if TRADEBOT
public class UserDataStream
{
    private BybitSocketClient socketClient;
    private UpdateSubscription _subscription;

    public async Task StopAsync()
    {
        if (_subscription == null)
            return; // Task.CompletedTask;

        GlobalData.AddTextToLogTab($"{Api.ExchangeName} Stopping user stream");

        _subscription.Exception -= Exception;
        _subscription.ConnectionLost -= ConnectionLost;
        _subscription.ConnectionRestored -= ConnectionRestored;

        await socketClient.UnsubscribeAllAsync();
        return; // Task.CompletedTask;
    }

    public async Task ExecuteAsync()
    {
        socketClient = new();

        var subscriptionResult = await socketClient.UsdPerpetualApi.SubscribeToOrderUpdatesAsync(
            OnOrderUpdate).ConfigureAwait(false);

        // Subscribe to network-related stuff
        if (subscriptionResult.Success)
        {
            _subscription = subscriptionResult.Data;

            // Events
            _subscription.Exception += Exception;
            _subscription.ConnectionLost += ConnectionLost;
            _subscription.ConnectionRestored += ConnectionRestored;
            return;
        }
        else
        {
            GlobalData.AddTextToLogTab($"{Api.ExchangeName} Error subscribing to userstream " + subscriptionResult.Error.Message);
            return;
        }
    }


    private void OnOrderUpdate(DataEvent<IEnumerable<BybitUsdPerpetualOrderUpdate>> dataList)
    {
        try
        {
            foreach (var data in dataList.Data)
            {
                // We krijgen duplicaat json berichten binnen (even een quick & dirty fix)
                string text = JsonSerializer.Serialize(data, new JsonSerializerOptions { Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping, WriteIndented = false }).Trim();
                GlobalData.AddTextToLogTab(string.Format("{0} OnOrderUpdate#1 TradeId={1} {2} quantity={3} price={4} text={5}", data.Symbol, data.Id, data.Status.ToString(), data.Quantity, data.Price, text));


                // We zijn slechts geinteresseerd in 3 statussen (de andere zijn niet interessant voor de afhandeling van de order)
                if (data.Status == OrderStatus.Filled ||
                    data.Status == OrderStatus.PartiallyFilled ||
                    data.Status == OrderStatus.Canceled)
                {
                    // Nieuwe thread opstarten en de data meegeven zodat er een sell wordt gedaan of administratie wordt bijgewerkt.
                    // Het triggeren van een stoploss of een DCA zal op een andere manier gedaan moeten worden (maar hoe en waar?)
                    if (GlobalData.ExchangeListName.TryGetValue(Api.ExchangeName, out Model.CryptoExchange exchange))
                    {
                        if (exchange.SymbolListName.TryGetValue(data.Symbol, out CryptoSymbol symbol))
                        {
                            // Converteer de data naar een (tijdelijke) trade
                            CryptoTrade trade = new();
                            Api.PickupTrade(GlobalData.ExchangeRealTradeAccount, symbol, trade, data);
                            GlobalData.AddTextToLogTab(string.Format("{0} OnOrderUpdate#2 TradeId={1} {2} quantity={3} price={4} (addtoqueue)", symbol.Name, trade.TradeId, data.Status.ToString(), trade.Quantity, trade.Price));

                            GlobalData.ThreadMonitorOrder.AddToQueue((
                                symbol,
                                Api.LocalOrderType(data.Type),
                                Api.LocalOrderSide(data.Side),
                                Api.LocalOrderStatus((OrderStatus)data.Status),
                                trade));
                        }
                    }
                }

                // Converteer de data naar een (tijdelijke) trade
                //BinanceApi.PickupTrade(trade, data.Data);
                //GlobalData.ThreadMonitorOrder.AddToQueue(data.Data);
            }
        }
        catch (Exception error)
        {
            GlobalData.Logger.Error(error);
            GlobalData.AddTextToLogTab($"{Api.ExchangeName} ERROR: OrderUpdate " + error.ToString());
        }
    }

    //private void onOcoOrderUpdateMessage(BinanceStreamOrderList data)
    //{
    //    try
    //    {
    //        Exchange exchange;
    //        if (GlobalData.ExchangeListName.TryGetValue(Api.ExchangeName, out exchange))
    //        {
    //            Symbol symbol;
    //            if (exchange.SymbolListName.TryGetValue(data.Symbol, out symbol))
    //            {
    //                // Oppassen, bij een OCO wordt ook de OnOrderUpdate aangeroepen (via 2 aparte orders, dus wellicht overbodig?)
    //                MonitorAlgorithm monitorAlgorithm = new MonitorAlgorithm();
    //                monitorAlgorithm.HandleTrade(symbol, data);
    //            }
    //        }
    //    }
    //    catch (Exception error)
    //    {
    //        GlobalData.AddTextToLogTab("ERROR: OcoOrderUpdateMessage " + error.ToString());
    //    }
    //}

    // deze was deprecated en is ondertussen vervallen
    //static private void OnAccountUpdate(BinanceStreamAccountInfo data)
    //{
    //    try                                
    //    {
    //        Exchange exchange = null;
    //        if (GlobalData.ExchangeListName.TryGetValue(Api.ExchangeName, out exchange))
    //        {
    //            BinanceTools.PickupAssets(exchange, data.Balances);
    //            GlobalData.AssetsHaveChanged("");
    //        }
    //    }
    //    catch (Exception error)
    //    {
    //        GlobalData.AddTextToLogTab("ERROR: AccountUpdate " + error.ToString());
    //    }
    //}

    // afgesterd
    //private void OnAccountPositionMessage(DataEvent<BinanceStreamPositionsUpdate> data)
    //{
    //    try
    //    {
    //        if (GlobalData.ExchangeListName.TryGetValue(Api.ExchangeName, out Model.CryptoExchange exchange))
    //        {
    //            BinanceApi.PickupAssets(GlobalData.ExchangeRealTradeAccount, data.Data.Balances);
    //            GlobalData.AssetsHaveChanged("");
    //        }
    //    }
    //    catch (Exception error)
    //    {
    //        GlobalData.Logger.Error(error);
    //        GlobalData.AddTextToLogTab($"{Api.ExchangeName} ERROR: AccountPositionMessage " + error.ToString());
    //    }
    //}


    //private void OnAccountBalanceUpdate(BinanceStreamBalanceUpdate data)
    //{
    //    // Dit rapporteert het verschil, deze staat (nu) niet aan..
    //    try
    //    {
    //        GlobalData.AddTextToLogTab(string.Format("AccountBalanceUpdate {0} usdt={1} free={2}", data.Event.ToString(), data.Asset, data.BalanceDelta));
    //    }
    //    catch (Exception error)
    //    {
    //        GlobalData.Logger.Error(error);
    //        GlobalData.AddTextToLogTab("ERROR: AccountBalanceUpdate " + error.ToString());
    //    }
    //}


    private void ConnectionLost()
    {
        //ConnectionLostCount++;
        GlobalData.AddTextToLogTab($"{Api.ExchangeName} user ticker connection lost.");
    }

    private void ConnectionRestored(TimeSpan timeSpan)
    {
        GlobalData.AddTextToLogTab($"{Api.ExchangeName} user ticker connection restored.");
    }

    private void Exception(Exception ex)
    {
        GlobalData.AddTextToLogTab($"{Api.ExchangeName} user ticker connection error {ex.Message} | Stack trace: {ex.StackTrace}");
    }
}

#endif
