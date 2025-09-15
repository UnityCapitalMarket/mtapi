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
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("currency_base")]
        public string CurrencyBase { get; set; } = string.Empty;

        [JsonProperty("currency_profit")]
        public string CurrencyProfit { get; set; } = string.Empty;

        [JsonProperty("currency_margin")]
        public string CurrencyMargin { get; set; } = string.Empty;

        [JsonProperty("bank")]
        public string Bank { get; set; } = string.Empty;

        [JsonProperty("description")]
        public string Description { get; set; } = string.Empty;

        [JsonProperty("path")]
        public string Path { get; set; } = string.Empty;

        // ----- Tick -----
        [JsonProperty("tick_time")]
        public double TickTimeRaw { get; set; }   // datetime → epoch → double

        [JsonProperty("bid")]
        public double Bid { get; set; }

        [JsonProperty("ask")]
        public double Ask { get; set; }

        [JsonProperty("last")]
        public double Last { get; set; }

        [JsonProperty("volume")]
        public double Volume { get; set; }

        // ----- Price precision & unit -----
        [JsonProperty("digits")]
        public int Digits { get; set; }

        [JsonProperty("point")]
        public double Point { get; set; }

        [JsonProperty("tick_value")]
        public double TickValue { get; set; }

        [JsonProperty("tick_value_profit")]
        public double TickValueProfit { get; set; }

        [JsonProperty("tick_value_loss")]
        public double TickValueLoss { get; set; }

        [JsonProperty("tick_size")]
        public double TickSize { get; set; }

        // ----- Lots & contract -----
        [JsonProperty("contract_size")]
        public double ContractSize { get; set; }

        [JsonProperty("lots_min")]
        public double LotsMin { get; set; }

        [JsonProperty("lots_max")]
        public double LotsMax { get; set; }

        [JsonProperty("lots_step")]
        public double LotsStep { get; set; }

        [JsonProperty("lots_limit")]
        public double LotsLimit { get; set; }

        // ----- Swaps -----
        [JsonProperty("swap_long")]
        public double SwapLong { get; set; }

        [JsonProperty("swap_short")]
        public double SwapShort { get; set; }

        [JsonProperty("swap_mode")]
        public int SwapMode { get; set; }

        [JsonProperty("swap3")]
        public int Swap3Day { get; set; }

        // ----- Trading config -----
        [JsonProperty("order_mode")]
        public int OrderMode { get; set; }

        [JsonProperty("trade_execution")]
        public int TradeExecution { get; set; }

        [JsonProperty("trade_calcmode")]
        public int TradeCalcMode { get; set; }

        [JsonProperty("trade_mode")]
        public int TradeMode { get; set; }

        // ----- Trading time / filling flags -----
        [JsonProperty("trade_time_flags")]
        public int TradeTimeFlags { get; set; }

        [JsonProperty("trade_fill_flags")]
        public int TradeFillFlags { get; set; }

        // ----- Spread & book depth -----
        [JsonProperty("spread")]
        public int Spread { get; set; }

        [JsonProperty("spread_float")]
        public bool SpreadFloat { get; set; }

        [JsonProperty("ticks_book_depth")]
        public int TicksBookDepth { get; set; }

        // ----- Trade levels -----
        [JsonProperty("stops_level")]
        public int StopsLevel { get; set; }

        [JsonProperty("freeze_level")]
        public int FreezeLevel { get; set; }

        // ----- High/Low snapshots -----
        [JsonProperty("bid_high")]
        public double BidHigh { get; set; }

        [JsonProperty("bid_low")]
        public double BidLow { get; set; }

        [JsonProperty("ask_high")]
        public double AskHigh { get; set; }

        [JsonProperty("ask_low")]
        public double AskLow { get; set; }

        [JsonProperty("last_high")]
        public double LastHigh { get; set; }

        [JsonProperty("last_low")]
        public double LastLow { get; set; }

        // ----- Futures timing -----
        [JsonProperty("start_time")]
        public double StartTimeRaw { get; set; }   // datetime → epoch seconds

        [JsonProperty("expiration_time")]
        public double ExpirationTimeRaw { get; set; }

        // ----- Margin parameters -----
        [JsonProperty("margin_initial")]
        public double MarginInitial { get; set; }

        [JsonProperty("margin_maintenance")]
        public double MarginMaintenance { get; set; }

        [JsonProperty("margin_hedged_use_leg")]
        public bool MarginHedgedUseLeg { get; set; }

        [JsonProperty("margin_hedged")]
        public double MarginHedged { get; set; }

        // ----- Session info -----
        [JsonProperty("session_deals")]
        public long SessionDeals { get; set; }

        [JsonProperty("session_buy_orders")]
        public long SessionBuyOrders { get; set; }

        [JsonProperty("session_sell_orders")]
        public long SessionSellOrders { get; set; }

        [JsonProperty("session_turnover")]
        public double SessionTurnover { get; set; }

        [JsonProperty("session_interest")]
        public double SessionInterest { get; set; }

        [JsonProperty("session_buy_orders_volume")]
        public double SessionBuyOrdersVolume { get; set; }

        [JsonProperty("session_sell_orders_volume")]
        public double SessionSellOrdersVolume { get; set; }

        [JsonProperty("session_open")]
        public double SessionOpen { get; set; }

        [JsonProperty("session_close")]
        public double SessionClose { get; set; }

        [JsonProperty("session_aw")]
        public double SessionAw { get; set; }

        [JsonProperty("session_price_settlement")]
        public double SessionPriceSettlement { get; set; }

        [JsonProperty("session_price_limit_min")]
        public double SessionPriceLimitMin { get; set; }

        [JsonProperty("session_price_limit_max")]
        public double SessionPriceLimitMax { get; set; }
    }
}
