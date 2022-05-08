namespace PddOpenSdk.Models.Request.Fds;
public partial class ReturnFdsWaybill
{

    /// <summary>
    /// 入参信息
    /// </summary>
    [JsonPropertyName("param_fds_waybill_return_request")]
    public ParamFdsWaybillReturnRequestModel ParamFdsWaybillReturnRequest { get; set; }
    public partial class ParamFdsWaybillReturnRequestModel
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

