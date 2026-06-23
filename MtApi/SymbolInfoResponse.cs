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

        ///<summary>Trade contract size (SYMBOL_TRADE_CONTRACT_SIZE).</summary>
        public double ContractSize { get; set; }

        ///<summary>Time of the last quote, in MetaTrader server time (seconds since epoch).</summary>
        public long MtTime { get; set; }

        ///<summary>Current spread in points.</summary>
        public int Spread { get; set; }

        ///<summary>Number of digits after the decimal point.</summary>
        public int Digits { get; set; }

        ///<summary>Minimal permitted volume for a deal.</summary>
        public double MinLot { get; set; }

        ///<summary>Maximal permitted volume for a deal.</summary>
        public double MaxLot { get; set; }

        ///<summary>Step for changing the deal volume.</summary>
        public double LotStep { get; set; }

        ///<summary>Profit calculation mode (MODE_PROFITCALCMODE: 0 = Forex, 1 = CFD, 2 = Futures).</summary>
        public double ProfitcalcMode { get; set; }

        ///<summary>Time of the last quote as a <see cref="DateTime"/>.</summary>
        public DateTime Time
        {
            get { return MtApiTimeConverter.ConvertFromMtTime((int)MtTime); }
        }
    }
}
