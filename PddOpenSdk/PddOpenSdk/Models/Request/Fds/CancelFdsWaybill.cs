namespace PddOpenSdk.Models.Request.Fds;
public partial class CancelFdsWaybill
{

    /// <summary>
    /// 入参信息
    /// </summary>
    [JsonPropertyName("pdd_fds_waybill_cancel_request")]
    public PddFdsWaybillCancelRequestModel PddFdsWaybillCancelRequest { get; set; }
    public partial class PddFdsWaybillCancelRequestModel
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
        /// 面单号
        /// </summary>
        [JsonPropertyName("waybill_code")]
        public string WaybillCode { get; set; }

        /// <summary>
        /// 物流公司 Code ，枚举： YTO- 圆通，ZTO-中通，YUNDA-韵达，STO-申通
        /// </summary>
        [JsonPropertyName("wp_code")]
        public string WpCode { get; set; }

    }

}

