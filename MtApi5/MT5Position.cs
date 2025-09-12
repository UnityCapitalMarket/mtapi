using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtApi5
{
    public class MT5Position
    {
        // ----- Fields khớp JSON -----
        [JsonProperty("Ticket")]
        public string Ticket { get; set; } = string.Empty;

        [JsonProperty("Symbol")]
        public string Symbol { get; set; } = string.Empty;

        [JsonProperty("TypeDescription")]
        public string TypeDesc { get; set; } = string.Empty;

        [JsonProperty("Comment")]
        public string Comment { get; set; } = string.Empty;

        // Chuỗi thời gian dạng "yyyy.MM.dd HH:mm:ss"
        [JsonProperty("TimeOpen")]
        public string TimeOpenRaw { get; set; } = string.Empty;
        [JsonProperty("TimeUpdate")]
        public string TimeUpdateRaw { get; set; } = string.Empty;

        [JsonProperty("TimeClose")]
        public string TimeCloseRaw { get; set; } = string.Empty;

        // Các giá trị “msc” trả về dạng 1753105820355.0 → dùng double để nhận
        [JsonProperty("TimeOpenMsc")]
        public double TimeOpenMscRaw { get; set; }

        [JsonProperty("TimeCloseMsc")]
        public double TimeCloseMscRaw { get; set; }
        [JsonProperty("TimeUpdateMsc")]
        public double TimeUpdateMscRaw { get; set; }

        // Các “int” nhưng JSON có thể trả 0 hoặc 1.0 → dùng double để nhận
        [JsonProperty("PositionType")]
        public double PositionTypeRaw { get; set; }

        [JsonProperty("Magic")]
        public double MagicRaw { get; set; }

        [JsonProperty("Identifier")]
        public double IdentifierRaw { get; set; }

        [JsonProperty("OpenReason")]
        public double OpenReasonRaw { get; set; }

        [JsonProperty("CloseReason")]
        public double CloseReasonRaw { get; set; }

        [JsonProperty("DealTickets")]
        public string DealTickets { get; set; } = string.Empty;

        // Giá/khối lượng/tiền: double là phù hợp
        [JsonProperty("Volume")]
        public double Volume { get; set; }

        [JsonProperty("PriceOpen")]
        public double PriceOpen { get; set; }

        [JsonProperty("StopLoss")]
        public double SL { get; set; }

        [JsonProperty("TakeProfit")]
        public double TP { get; set; }

        [JsonProperty("PriceClose")]
        public double PriceClose { get; set; }
        [JsonProperty("PriceCurrent")]
        public double PriceCurrent { get; set; }

        [JsonProperty("Commission")]
        public double Commission { get; set; }

        [JsonProperty("Swap")]
        public double Swap { get; set; }

        [JsonProperty("Profit")]
        public double Profit { get; set; }

        // ----- Helpers đã ép kiểu tiện dùng trong code -----
        [JsonIgnore]
        public int PositionType => (int)Math.Round(PositionTypeRaw);

        [JsonIgnore]
        public long Magic => (long)Math.Round(MagicRaw);

        [JsonIgnore]
        public long Identifier => (long)Math.Round(IdentifierRaw);

        [JsonIgnore]
        public long TimeOpenMsc => (long)Math.Round(TimeOpenMscRaw);

        [JsonIgnore]
        public long TimeCloseMsc => (long)Math.Round(TimeCloseMscRaw);

        [JsonIgnore]
        public long TimeUpdateMsc => (long)Math.Round(TimeUpdateMscRaw);

        [JsonIgnore]
        public DateTime? TimeOpen =>
            TryParseMtTime(TimeOpenRaw);

        [JsonIgnore]
        public DateTime? TimeClose =>
            TryParseMtTime(TimeCloseRaw);
        [JsonIgnore]
        public DateTime? TimeUpdate => TryParseMtTime(TimeUpdateRaw);

        private static DateTime? TryParseMtTime(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return null;
            // MQL/MT thường format "yyyy.MM.dd HH:mm:ss"
            if (DateTime.TryParseExact(s, "yyyy.MM.dd HH:mm:ss",
                CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal, out var dt))
                return dt;
            // fallback
            if (DateTime.TryParse(s, CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal, out dt))
                return dt;
            return null;
        }
    }
}
