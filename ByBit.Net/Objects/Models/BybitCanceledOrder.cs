﻿using Bybit.Net.Converters;
using Bybit.Net.Enums;
using CryptoExchange.Net.Converters;
using Newtonsoft.Json;
using System;

namespace Bybit.Net.Objects.Models
{
    /// <summary>
    /// Canceled order info
    /// </summary>
    public class BybitCanceledOrder: BybitOrderBase
    {
        /// <summary>
        /// Cancel order id
        /// </summary>
        [JsonProperty("clOrdID")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// The state of initiating a matchmaking request
        /// </summary>
        [JsonProperty("cross_status"), JsonConverter(typeof(OrderStatusConverter))]
        public OrderStatus CrossStatus { get; set; }
        /// <summary>
        /// Trigger scenario for single action
        /// </summary>
        [JsonProperty("create_type")]
        public string? CreateType { get; set; }
        /// <summary>
        /// Cross sequence
        /// </summary>
        [JsonProperty("cross_seq")]
        public decimal CrossSequence { get; set; }
    }
}
