﻿using CryptoExchange.Net.Clients;

namespace CryptoScanBot.Exchange;

public class TickerGroup : IDisposable
{
    // Iedere client bedient maximaal 10 subscriptions
    // Iedere subscription bedient een aantal symbols
    // dat is zo'n 1..200 en afhankelijk van de exchange..
    internal BaseSocketClient SocketClient;
    public List<SubscriptionTicker> TickerList { get; set; } = [];


    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (SocketClient != null)
            {
                SocketClient.Dispose();
                SocketClient = null;
            }
        }
    }
}
