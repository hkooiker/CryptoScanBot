﻿using CryptoExchange.Net.Objects;
using CryptoExchange.Net.Objects.Sockets;

using CryptoScanBot.Intern;

namespace CryptoScanBot.Exchange;

public class TickerItem(ExchangeOptions exchangeOptions)
{
    internal ExchangeOptions ExchangeOptions = exchangeOptions;

    public int TickerCount = 0;
    public int TickerCountLast = 0;

    public int ConnectionLostCount = 0;
    public bool ErrorDuringStartup = false;

    internal string GroupName = "";
    internal string TickerType = "";
    internal List<string> Symbols = [];
    public TickerGroup TickerGroup = null;

    internal UpdateSubscription _subscription;


    public virtual Task<CallResult<UpdateSubscription>> Subscribe()
    {
        throw new NotImplementedException();
    }


    public virtual async Task StartAsync()
    {
        if (_subscription != null)
        {
            ScannerLog.Logger.Trace($"{TickerType} ticker for group {GroupName} already started");
            return;
        }

        ConnectionLostCount = 0;
        ErrorDuringStartup = false;
        ScannerLog.Logger.Trace($"{TickerType} ticker for group {GroupName} starting");

        var subscriptionResult = await Subscribe();
        if (subscriptionResult.Success)
        {
            _subscription = subscriptionResult.Data;
            _subscription.Exception += TickerException;
            _subscription.ConnectionLost += TickerConnectionLost;
            _subscription.ConnectionRestored += TickerConnectionRestored;
            ScannerLog.Logger.Trace($"{TickerType} ticker for group {GroupName} started");
        }
        else
        {
            if (_subscription != null)
            {
                _subscription.Exception -= TickerException;
                _subscription.ConnectionLost -= TickerConnectionLost;
                _subscription.ConnectionRestored -= TickerConnectionRestored;
                _subscription = null;
            }

            // todo, nakijken!
            //socketClient.Dispose();
            //socketClient = null;

            ConnectionLostCount++;
            ErrorDuringStartup = true;

            ScannerLog.Logger.Trace($"{TickerType} ticker for group {GroupName} error {subscriptionResult.Error.Message} {string.Join(',', Symbols)}");
            GlobalData.AddTextToLogTab($"{TickerType} ticker for group {GroupName} error {subscriptionResult.Error.Message} {string.Join(',', Symbols)}");
        }
    }


    public virtual async Task StopAsync()
    {
        if (_subscription == null)
        {
            ScannerLog.Logger.Trace($"{TickerType} ticker for group {GroupName} already stopped");
            return;
        }

        ScannerLog.Logger.Trace($"{TickerType} ticker for group {GroupName} stopping");
        _subscription.Exception -= TickerException;
        _subscription.ConnectionLost -= TickerConnectionLost;
        _subscription.ConnectionRestored -= TickerConnectionRestored;

        await TickerGroup.SocketClient?.UnsubscribeAsync(_subscription);
        _subscription = null;

        //TickerGroup.SocketClient?.Dispose();
        //TickerGroup.SocketClient = null;
        ScannerLog.Logger.Trace($"{TickerType} ticker for group {GroupName} stopped");
    }


    internal void TickerConnectionLost()
    {
        ConnectionLostCount++;
        GlobalData.AddTextToLogTab($"{ExchangeOptions.ExchangeName} {TickerType} ticker for group connection lost {GroupName}.");
        ScannerSession.ConnectionWasLost("");
    }


    internal void TickerConnectionRestored(TimeSpan timeSpan)
    {
        GlobalData.AddTextToLogTab($"{ExchangeOptions.ExchangeName} {TickerType} ticker for group {GroupName} connection restored.");
        ScannerSession.ConnectionWasRestored("");
    }


    internal void TickerException(Exception ex)
    {
        GlobalData.AddTextToLogTab($"{ExchangeOptions.ExchangeName} {TickerType} ticker for group {GroupName} connection error {ex.Message} | Stack trace: {ex.StackTrace}");
    }

}