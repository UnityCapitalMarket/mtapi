using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtApi5
{
    public class MT5SymbolInfo
    {
        // --- Identity ---
        [JsonProperty("Name")] public string Name { get; set; } = string.Empty;
        [JsonProperty("Description")] public string Description { get; set; } = string.Empty;
        [JsonProperty("CurrencyBase")] public string CurrencyBase { get; set; } = string.Empty;
        [JsonProperty("CurrencyProfit")] public string CurrencyProfit { get; set; } = string.Empty;
        [JsonProperty("CurrencyMargin")] public string CurrencyMargin { get; set; } = string.Empty;

        // --- Tick ---
        [JsonProperty("Time")] public string Time { get; set; } = string.Empty;
        [JsonProperty("Bid")] public double Bid { get; set; }
        [JsonProperty("Ask")] public double Ask { get; set; }
        [JsonProperty("Last")] public double Last { get; set; }
        [JsonProperty("Volume")] public double Volume { get; set; }

        // --- Precision ---
        [JsonProperty("Digits")] public int Digits { get; set; }
        [JsonProperty("Point")] public double Point { get; set; }
        [JsonProperty("TickValue")] public double TickValue { get; set; }
        [JsonProperty("TickValueProfit")] public double TickValueProfit { get; set; }
        [JsonProperty("TickValueLoss")] public double TickValueLoss { get; set; }
        [JsonProperty("TickSize")] public double TickSize { get; set; }

        // --- Lots ---
        [JsonProperty("ContractSize")] public double ContractSize { get; set; }
        [JsonProperty("LotsMin")] public double LotsMin { get; set; }
        [JsonProperty("LotsMax")] public double LotsMax { get; set; }
        [JsonProperty("LotsStep")] public double LotsStep { get; set; }
        [JsonProperty("LotsLimit")] public double LotsLimit { get; set; }

        // --- Swaps ---
        [JsonProperty("SwapLong")] public double SwapLong { get; set; }
        [JsonProperty("SwapShort")] public double SwapShort { get; set; }

        // CHANGED: int -> double
        [JsonProperty("SwapMode")] public double SwapModeRaw { get; set; }
        [JsonProperty("Swap3Days")] public double Swap3DaysRaw { get; set; }

        // --- Trading config ---
        // CHANGED: int -> double
        [JsonProperty("OrderMode")] public double OrderModeRaw { get; set; }
        [JsonProperty("TradeExecution")] public double TradeExecutionRaw { get; set; }
        [JsonProperty("TradeCalcMode")] public double TradeCalcModeRaw { get; set; }
        [JsonProperty("TradeMode")] public double TradeModeRaw { get; set; }

        // --- Flags ---
        // CHANGED: int -> double
        [JsonProperty("TradeTimeFlags")] public double TradeTimeFlagsRaw { get; set; }
        [JsonProperty("TradeFillFlags")] public double TradeFillFlagsRaw { get; set; }

        // --- Spread & depth ---
        // CHANGED: int -> double (đề phòng JSONNumber đẩy "x.0")
        [JsonProperty("Spread")] public double SpreadRaw { get; set; }
        [JsonProperty("SpreadFloat")] public bool SpreadFloat { get; set; }

        // CHANGED: int -> double
        [JsonProperty("BookDepth")] public double BookDepthRaw { get; set; }

        // --- High/Low ---
        [JsonProperty("BidHigh")] public double BidHigh { get; set; }
        [JsonProperty("BidLow")] public double BidLow { get; set; }
        [JsonProperty("AskHigh")] public double AskHigh { get; set; }
        [JsonProperty("AskLow")] public double AskLow { get; set; }
        [JsonProperty("LastHigh")] public double LastHigh { get; set; }
        [JsonProperty("LastLow")] public double LastLow { get; set; }

        // --- Futures dates ---
        [JsonProperty("StartTime")] public string StartTime { get; set; } = string.Empty;
        [JsonProperty("ExpirationTime")] public string ExpirationTime { get; set; } = string.Empty;

        // --- Margin ---
        [JsonProperty("MarginInitial")] public double MarginInitial { get; set; }
        [JsonProperty("MarginMaintenance")] public double MarginMaintenance { get; set; }
        [JsonProperty("MarginHedged")] public double MarginHedged { get; set; }
        [JsonProperty("MarginHedgedUseLeg")] public bool MarginHedgedUseLeg { get; set; }

        // --- Session info ---
        [JsonProperty("SessionDeals")] public long SessionDeals { get; set; }
        [JsonProperty("SessionBuyOrders")] public long SessionBuyOrders { get; set; }
        [JsonProperty("SessionSellOrders")] public long SessionSellOrders { get; set; }
        [JsonProperty("SessionTurnover")] public double SessionTurnover { get; set; }
        [JsonProperty("SessionInterest")] public double SessionInterest { get; set; }
        [JsonProperty("SessionBuyOrdersVolume")] public double SessionBuyOrdersVolume { get; set; }
        [JsonProperty("SessionSellOrdersVolume")] public double SessionSellOrdersVolume { get; set; }
        [JsonProperty("SessionOpen")] public double SessionOpen { get; set; }
        [JsonProperty("SessionClose")] public double SessionClose { get; set; }
        [JsonProperty("SessionAW")] public double SessionAw { get; set; }
        [JsonProperty("SessionPriceSettlement")] public double SessionPriceSettlement { get; set; }
        [JsonProperty("SessionPriceLimitMin")] public double SessionPriceLimitMin { get; set; }
        [JsonProperty("SessionPriceLimitMax")] public double SessionPriceLimitMax { get; set; }

        // ------------ Helpers to cast back to int (nếu cần) ------------
        [JsonIgnore] public int SwapMode => (int)Math.Round(SwapModeRaw);
        [JsonIgnore] public int Swap3Days => (int)Math.Round(Swap3DaysRaw);
        [JsonIgnore] public int OrderModeInt => (int)Math.Round(OrderModeRaw);
        [JsonIgnore] public int TradeExecution => (int)Math.Round(TradeExecutionRaw);
        [JsonIgnore] public int TradeCalcMode => (int)Math.Round(TradeCalcModeRaw);
        [JsonIgnore] public int TradeMode => (int)Math.Round(TradeModeRaw);
        [JsonIgnore] public int TradeTimeFlags => (int)Math.Round(TradeTimeFlagsRaw);
        [JsonIgnore] public int TradeFillFlags => (int)Math.Round(TradeFillFlagsRaw);
        [JsonIgnore] public int Spread => (int)Math.Round(SpreadRaw);
        [JsonIgnore] public int BookDepth => (int)Math.Round(BookDepthRaw);

        // (Tuỳ chọn) Parse chuỗi thời gian của MT5
        [JsonIgnore] public DateTime? TimeParsed => TryParseMtTime(Time);
        [JsonIgnore] public DateTime? StartTimeParsed => TryParseMtTime(StartTime);
        [JsonIgnore] public DateTime? ExpirationTimeParsed => TryParseMtTime(ExpirationTime);

        private static DateTime? TryParseMtTime(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return null;
            string[] fmts = { "yyyy.MM.dd HH:mm:ss", "yyyy.MM.dd HH:mm", "yyyy-MM-dd HH:mm:ss", "yyyy-MM-dd HH:mm" };
            if (DateTime.TryParseExact(s, fmts, System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.AssumeLocal, out var dt)) return dt;
            if (DateTime.TryParse(s, out dt)) return dt;
            return null;
        }
    }
}
