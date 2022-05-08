namespace PddOpenSdk.Models.Request.Fds;
public partial class SlaveFdsWaybillReturn
{

    /// <summary>
    /// 回传从运单号请求
    /// </summary>
    [JsonPropertyName("request")]
    public RequestModel Request { get; set; }
    public partial class RequestModel
    {

        /// <summary>
        /// 代打店铺id
        /// </summary>
        [JsonPropertyName("mall_mask_id")]
        public string MallMaskId { get; set; }

        /// <summary>
        /// 代打订单号
        /// </summary>
        [JsonPropertyName("order_mask_sn")]
        public string OrderMaskSn { get; set; }

        /// <summary>
        /// 从运单号列表，最多传递十条从运单号
        /// </summary>
        [JsonPropertyName("waybill_codes")]
        public List<string> WaybillCodes { get; set; }

        /// <summary>
        /// 物流公司 Code ，枚举： YTO- 圆通，ZTO-中通，YUNDA-韵达，STO-申通
        /// </summary>
        [JsonPropertyName("wp_code")]
        public string WpCode { get; set; }

    }

}

