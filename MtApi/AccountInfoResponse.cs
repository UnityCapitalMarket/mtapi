namespace MtApi
{
    ///<summary>
    ///Aggregated snapshot of the MetaTrader account information.
    ///Retrieved with a single request via <see cref="MtApiClient.AccountInfo"/>
    ///instead of issuing one round-trip per value. This avoids the command
    ///queue back-pressure that previously produced the "Response from
    ///MetaTrader is null" error when many account values were requested
    ///concurrently.
    ///</summary>
    public class AccountInfoResponse
    {
        ///<summary>Account number (login).</summary>
        public long Login { get; set; }

        ///<summary>Account holder name.</summary>
        public string Name { get; set; } = string.Empty;

        ///<summary>Trade server name the account is connected to.</summary>
        public string Server { get; set; } = string.Empty;

        ///<summary>Name of the broker/company serving the account.</summary>
        public string Company { get; set; } = string.Empty;

        ///<summary>Deposit currency (e.g. USD, EUR).</summary>
        public string Currency { get; set; } = string.Empty;

        ///<summary>Account balance in the deposit currency.</summary>
        public double Balance { get; set; }

        ///<summary>Account credit in the deposit currency.</summary>
        public double Credit { get; set; }

        ///<summary>Account equity in the deposit currency.</summary>
        public double Equity { get; set; }

        ///<summary>Current floating profit in the deposit currency.</summary>
        public double Profit { get; set; }

        ///<summary>Account margin used in the deposit currency.</summary>
        public double Margin { get; set; }

        ///<summary>Free margin available for opening positions.</summary>
        public double FreeMargin { get; set; }

        ///<summary>Margin level in percent (equity / margin * 100).</summary>
        public double MarginLevel { get; set; }

        ///<summary>Account leverage.</summary>
        public int Leverage { get; set; }

        ///<summary>Margin stop out level.</summary>
        public int StopoutLevel { get; set; }

        ///<summary>Margin stop out mode (0 - percent, 1 - money).</summary>
        public int StopoutMode { get; set; }

        ///<summary>True if the account is a demo account.</summary>
        public bool IsDemo { get; set; }

        ///<summary>True if trading is allowed for the account/expert.</summary>
        public bool TradeAllowed { get; set; }
    }
}
