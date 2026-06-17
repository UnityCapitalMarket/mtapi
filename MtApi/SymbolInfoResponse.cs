namespace MtApi
{
    ///<summary>
    ///Aggregated snapshot of the commonly used information for a single trading
    ///symbol. Retrieved with one request via <see cref="MtApiClient.SymbolInfo"/>
    ///instead of issuing a separate request per value (SymbolInfoString,
    ///SymbolInfoInteger, SymbolInfoDouble, SymbolInfoTick, MarketInfo). A single
    ///round-trip avoids the command queue back-pressure that can otherwise cause
    ///"Response from MetaTrader is null" timeouts under concurrent requests.
    ///</summary>
    public class SymbolInfoResponse
    {
        ///<summary>Symbol name (e.g. EURUSD).</summary>
        public string Name { get; set; } = string.Empty;

        ///<summary>Symbol description.</summary>
        public string Description { get; set; } = string.Empty;

        ///<summary>Base currency of the symbol.</summary>
        public string CurrencyBase { get; set; } = string.Empty;

        ///<summary>Profit currency of the symbol.</summary>
        public string CurrencyProfit { get; set; } = string.Empty;

        ///<summary>Margin currency of the symbol.</summary>
        public string CurrencyMargin { get; set; } = string.Empty;

        ///<summary>Current best bid price.</summary>
        public double Bid { get; set; }

        ///<summary>Current best ask price.</summary>
        public double Ask { get; set; }

        ///<summary>Price of the last deal.</summary>
        public double Last { get; set; }

        ///<summary>Volume of the last quote.</summary>
        public long Volume { get; set; }

        ///<summary>Time of the last quote, in MetaTrader server time (seconds since epoch).</summary>
        public long MtTime { get; set; }

        ///<summary>Current spread in points.</summary>
        public int Spread { get; set; }

        ///<summary>Number of digits after the decimal point.</summary>
        public int Digits { get; set; }

        ///<summary>Point size in the quote currency.</summary>
        public double Point { get; set; }

        ///<summary>Minimal distance (in points) for stop orders.</summary>
        public int StopLevel { get; set; }

        ///<summary>Freeze distance (in points) for trade operations.</summary>
        public int FreezeLevel { get; set; }

        ///<summary>Contract size (lot size) in the base currency.</summary>
        public double LotSize { get; set; }

        ///<summary>Tick value in the deposit currency.</summary>
        public double TickValue { get; set; }

        ///<summary>Minimal price change (tick size).</summary>
        public double TickSize { get; set; }

        ///<summary>Minimal permitted volume for a deal.</summary>
        public double MinLot { get; set; }

        ///<summary>Maximal permitted volume for a deal.</summary>
        public double MaxLot { get; set; }

        ///<summary>Step for changing the deal volume.</summary>
        public double LotStep { get; set; }

        ///<summary>Swap charged for holding a long position.</summary>
        public double SwapLong { get; set; }

        ///<summary>Swap charged for holding a short position.</summary>
        public double SwapShort { get; set; }

        ///<summary>Initial margin requirement for 1 lot.</summary>
        public double MarginInit { get; set; }

        ///<summary>Margin required to open 1 lot.</summary>
        public double MarginRequired { get; set; }

        ///<summary>Time of the last quote as a <see cref="DateTime"/>.</summary>
        public DateTime Time
        {
            get { return MtApiTimeConverter.ConvertFromMtTime((int)MtTime); }
        }
    }
}
