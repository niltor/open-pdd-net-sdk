namespace PddOpenSdk.Models.Request.Fds;
public partial class GetFdsOrder
{

    /// <summary>
    /// 入参信息
    /// </summary>
    [JsonPropertyName("param_fds_order_get_request")]
    public ParamFdsOrderGetRequestModel ParamFdsOrderGetRequest { get; set; }
    public partial class ParamFdsOrderGetRequestModel
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

    }

}

