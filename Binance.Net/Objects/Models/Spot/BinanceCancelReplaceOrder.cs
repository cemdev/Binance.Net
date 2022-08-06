using System;
using System.Collections.Generic;
using CryptoExchange.Net.Converters;
using Newtonsoft.Json;

namespace Binance.Net.Objects.Models.Spot
{
    /// <summary>
    /// The result of placing a new order
    /// </summary>
    public class BinanceCancelReplaceOrder
    {
        private bool _cancelResult;
        private bool _newOrderResult;

        [JsonProperty("cancelResult")]
        public string c { set => _cancelResult = value == "SUCCESS"; }

        [JsonProperty("newOrderResult")]
        public string o { set => _newOrderResult = value == "SUCCESS"; }

        public bool CancelResult { get => _cancelResult; }

        public bool NewOrderResult { get => _newOrderResult; }

        [JsonProperty("cancelResponse")]
        public BinanceOrderBase CancelResponse { get; set; }

        [JsonProperty("newOrderResponse")]
        public BinanceOrderBase NewOrderResponse { get; set; }

    }
}
