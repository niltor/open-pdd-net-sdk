namespace PddOpenSdk.Models.Response.Oversea;
public partial class GetOverseaClearanceResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("clearance_response")]
    public ClearanceResponseResponse ClearanceResponse { get; set; }
    public partial class ClearanceResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 身份证姓名
        /// </summary>
        [JsonPropertyName("id_card_name")]
        public string IdCardName { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [JsonPropertyName("id_card_no")]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 支付申报订单号
        /// </summary>
        [JsonPropertyName("inner_transaction_id")]
        public string InnerTransactionId { get; set; }

        /// <summary>
        /// 支付单号
        /// </summary>
        [JsonPropertyName("pay_no")]
        public string PayNo { get; set; }

        /// <summary>
        /// 支付方式，枚举值：WEIXIN,ALIPAY,DUODUOPAY
        /// </summary>
        [JsonPropertyName("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [JsonPropertyName("order_sn")]
        public string OrderSn { get; set; }

    }

}

