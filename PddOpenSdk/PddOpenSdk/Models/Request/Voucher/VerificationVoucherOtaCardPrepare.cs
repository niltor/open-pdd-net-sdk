namespace PddOpenSdk.Models.Request.Voucher;
public partial class VerificationVoucherOtaCardPrepare
{

    /// <summary>
    /// 请求体
    /// </summary>
    [JsonPropertyName("request")]
    public RequestModel Request { get; set; }
    public partial class RequestModel
    {

        /// <summary>
        /// 卡密
        /// </summary>
        [JsonPropertyName("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonPropertyName("store_id")]
        public long? StoreId { get; set; }

    }

}

