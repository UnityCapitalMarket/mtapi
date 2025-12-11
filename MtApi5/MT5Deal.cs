using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MtApi5
{
    public class MT5Deal
    { 
        // ===== Identity / basic info =====

        [JsonProperty("Ticket")]
        public string Ticket { get; set; } = string.Empty;

        [JsonProperty("Symbol")]
        public string Symbol { get; set; } = string.Empty;

        [JsonProperty("TypeDescription")]
        public string TypeDescription { get; set; } = string.Empty;

        [JsonProperty("EntryDescription")]
        public string EntryDescription { get; set; } = string.Empty;

        [JsonProperty("Comment")]
        public string Comment { get; set; } = string.Empty;

        [JsonProperty("ExternalId")]
        public string ExternalId { get; set; } = string.Empty;

        // ===== Time =====

        /// <summary>
        /// Deal time – formatted string from MT5 (TimeToString)
        /// </summary>
        [JsonProperty("Time")]
        public string Time { get; set; } = string.Empty;

        /// <summary>
        /// Deal time in milliseconds (Unix-style from MT5)
        /// </summary>
        [JsonProperty("TimeMsc")]
        public long TimeMsc { get; set; }

        // ===== Types / identifiers =====

        [JsonProperty("DealType")]
        public int DealType { get; set; }

        [JsonProperty("Entry")]
        public int Entry { get; set; }

        [JsonProperty("Magic")]
        public long Magic { get; set; }

        [JsonProperty("PositionId")]
        public long PositionId { get; set; }

        [JsonProperty("Order")]
        public long Order { get; set; }

        // ===== Numeric values =====

        [JsonProperty("Volume")]
        public double Volume { get; set; }

        [JsonProperty("Price")]
        public double Price { get; set; }

        [JsonProperty("Commission")]
        public double Commission { get; set; }

        [JsonProperty("Swap")]
        public double Swap { get; set; }

        [JsonProperty("Profit")]
        public double Profit { get; set; }
    }
}
