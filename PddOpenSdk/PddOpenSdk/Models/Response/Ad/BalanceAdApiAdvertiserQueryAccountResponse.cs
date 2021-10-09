namespace PddOpenSdk.Models.Response.Ad;
public partial class BalanceAdApiAdvertiserQueryAccountResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("errorMsg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("result")]
        public ResultResponse Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 账户余额明细列表
            /// </summary>
            [JsonPropertyName("accountsBalance")]
            public List<AccountsBalanceResponse> AccountsBalance { get; set; }

            /// <summary>
            /// 总余额，单位厘
            /// </summary>
            [JsonPropertyName("balance")]
            public long? Balance { get; set; }

            /// <summary>
            /// 广告主Id
            /// </summary>
            [JsonPropertyName("mallId")]
            public long? MallId { get; set; }
            public partial class AccountsBalanceResponse : PddResponseModel
            {

                /// <summary>
                /// 账户类型。1表示现金余额，2表示通用红包余额，3表示奖励金余额，7表示聚焦展位CPM专用红包余额，10表示直播专用红包余额。
                /// </summary>
                [JsonPropertyName("accountType")]
                public int? AccountType { get; set; }

                /// <summary>
                /// 账户余额，单位厘
                /// </summary>
                [JsonPropertyName("rawBalance")]
                public long? RawBalance { get; set; }

                /// <summary>
                /// 可消费余额，单位厘
                /// </summary>
                [JsonPropertyName("spendableBalance")]
                public long? SpendableBalance { get; set; }

            }

        }

    }

}

