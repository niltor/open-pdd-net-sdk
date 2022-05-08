namespace PddOpenSdk.Models.Response.DdkTools;
public partial class CreateDdkOauthCashgiftResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("create_cashgift_response")]
    public CreateCashgiftResponseResponse CreateCashgiftResponse { get; set; }
    public partial class CreateCashgiftResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 礼金ID
        /// </summary>
        [JsonPropertyName("cash_gift_id")]
        public long? CashGiftId { get; set; }

        /// <summary>
        /// 创建结果
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }

    }

}

