using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MtApi5
{
    public class MT5Order
    {
        [JsonProperty("Symbol")]
        public string Symbol { get; set; } = string.Empty;

        [JsonProperty("TypeDescription")]
        public string TypeDesc { get; set; } = string.Empty;

        [JsonProperty("StateDescription")]
        public string StateDesc { get; set; } = string.Empty;

        [JsonProperty("FillTypeDesc")]
        public string FillTypeDesc { get; set; } = string.Empty;

        [JsonProperty("TimeTypeDesc")]
        public string TimeTypeDesc { get; set; } = string.Empty;

        [JsonProperty("Comment")]
        public string Comment { get; set; } = string.Empty;

        [JsonProperty("ExternalId")]
        public string ExternalId { get; set; } = string.Empty;

        // Chuỗi thời gian dạng "yyyy.MM.dd HH:mm:ss"
        [JsonProperty("TimeSetup")]
        public string TimeSetupRaw { get; set; } = string.Empty;

        [JsonProperty("TimeDone")]
        public string TimeDoneRaw { get; set; } = string.Empty;

        [JsonProperty("Expiration")]
        public string ExpirationRaw { get; set; } = string.Empty;

        // Millisecond time fields (double trong JSON)
        [JsonProperty("TimeSetupMsc")]
        public double TimeSetupMscRaw { get; set; }

        [JsonProperty("TimeDoneMsc")]
        public double TimeDoneMscRaw { get; set; }

        // Enum / state fields (số int nhưng JSON trả double)
        [JsonProperty("OrderType")]
        public double OrderTypeRaw { get; set; }

        [JsonProperty("OrderState")]
        public double OrderStateRaw { get; set; }

        [JsonProperty("TypeFilling")]
        public double TypeFillingRaw { get; set; }

        [JsonProperty("TypeTime")]
        public double TypeTimeRaw { get; set; }

        // Identifiers
        [JsonProperty("TicketNumeric")]
        public double TicketNumericRaw { get; set; }

        [JsonProperty("Magic")]
        public double MagicRaw { get; set; }

        [JsonProperty("PositionId")]
        public double PositionIdRaw { get; set; }

        [JsonProperty("PositionById")]
        public double PositionByIdRaw { get; set; }

        // Volume / prices
        [JsonProperty("VolumeInitial")]
        public double VolumeInitial { get; set; }

        [JsonProperty("VolumeCurrent")]
        public double VolumeCurrent { get; set; }

        [JsonProperty("PriceOpen")]
        public double PriceOpen { get; set; }

        [JsonProperty("StopLoss")]
        public double StopLoss { get; set; }

        [JsonProperty("TakeProfit")]
        public double TakeProfit { get; set; }

        [JsonProperty("PriceCurrent")]
        public double PriceCurrent { get; set; }

        [JsonProperty("PriceStopLimit")]
        public double PriceStopLimit { get; set; }

        // ----- Helpers ép kiểu tiện dùng -----

        [JsonIgnore]
        public long TicketNumeric => (long)Math.Round(TicketNumericRaw);

        [JsonIgnore]
        public int OrderType => (int)Math.Round(OrderTypeRaw);

        [JsonIgnore]
        public int OrderState => (int)Math.Round(OrderStateRaw);

        [JsonIgnore]
        public int TypeFilling => (int)Math.Round(TypeFillingRaw);

        [JsonIgnore]
        public int TypeTime => (int)Math.Round(TypeTimeRaw);

        [JsonIgnore]
        public long Magic => (long)Math.Round(MagicRaw);

        [JsonIgnore]
        public long PositionId => (long)Math.Round(PositionIdRaw);

        [JsonIgnore]
        public long PositionById => (long)Math.Round(PositionByIdRaw);

        [JsonIgnore]
        public long TimeSetupMsc => (long)Math.Round(TimeSetupMscRaw);

        [JsonIgnore]
        public long TimeDoneMsc => (long)Math.Round(TimeDoneMscRaw);

        [JsonIgnore]
        public DateTime? TimeSetup => TryParseMtTime(TimeSetupRaw);

        [JsonIgnore]
        public DateTime? TimeDone => TryParseMtTime(TimeDoneRaw);

        [JsonIgnore]
        public DateTime? Expiration => TryParseMtTime(ExpirationRaw);

        private static DateTime? TryParseMtTime(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return null;
            if (DateTime.TryParseExact(s, "yyyy.MM.dd HH:mm:ss",
                CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal, out var dt))
                return dt;

            if (DateTime.TryParse(s, CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal, out dt))
                return dt;

            return null;
        }
    }
}
