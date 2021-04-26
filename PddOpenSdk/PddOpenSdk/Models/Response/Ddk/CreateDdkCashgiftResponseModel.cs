using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public partial class CreateDdkCashgiftResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("create_cashgift_response")]
        public CreateCashgiftResponseResponseModel CreateCashgiftResponse { get; set; }
        public partial class CreateCashgiftResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 礼金ID
            /// </summary>
            [JsonProperty("cash_gift_id")]
            public long? CashGiftId { get; set; }
            /// <summary>
            /// 创建结果
            /// </summary>
            [JsonProperty("success")]
            public bool? Success { get; set; }

        }

    }

}
