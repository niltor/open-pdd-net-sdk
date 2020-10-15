using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class BalanceAdApiAdvertiserQueryAccountResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("response")]
        public ResponseResponseModel Response { get; set; }
        public partial class ResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("errorCode")]
            public int? ErrorCode { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("errorMsg")]
            public string ErrorMsg { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("result")]
            public ResultResponseModel Result { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("success")]
            public bool? Success { get; set; }
            public partial class ResultResponseModel : PddResponseModel
            {
                /// <summary>
                /// 账户余额明细列表
                /// </summary>
                [JsonProperty("accountsBalance")]
                public List<AccountsBalanceResponseModel> AccountsBalance { get; set; }
                /// <summary>
                /// 总余额，单位厘
                /// </summary>
                [JsonProperty("balance")]
                public long? Balance { get; set; }
                /// <summary>
                /// 广告主Id
                /// </summary>
                [JsonProperty("mallId")]
                public long? MallId { get; set; }
                public partial class AccountsBalanceResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 账户类型。1表示现金余额，2表示通用红包余额，3表示奖励金余额，7表示聚焦展位CPM专用红包余额，10表示直播专用红包余额。
                    /// </summary>
                    [JsonProperty("accountType")]
                    public int? AccountType { get; set; }
                    /// <summary>
                    /// 账户余额，单位厘
                    /// </summary>
                    [JsonProperty("rawBalance")]
                    public long? RawBalance { get; set; }
                    /// <summary>
                    /// 可消费余额，单位厘
                    /// </summary>
                    [JsonProperty("spendableBalance")]
                    public long? SpendableBalance { get; set; }

                }

            }

        }

    }

}
