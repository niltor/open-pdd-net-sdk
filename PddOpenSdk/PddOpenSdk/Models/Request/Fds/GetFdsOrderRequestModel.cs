using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Fds
{
    public partial class GetFdsOrderRequestModel : PddRequestModel
    {
        /// <summary>
        /// 入参信息
        /// </summary>
        [JsonProperty("param_fds_order_get_request")]
        public ParamFdsOrderGetRequestRequestModel ParamFdsOrderGetRequest { get; set; }
        public partial class ParamFdsOrderGetRequestRequestModel : PddRequestModel
        {
            /// <summary>
            /// 代打店铺id
            /// </summary>
            [JsonProperty("mall_mask_id")]
            public string MallMaskId { get; set; }
            /// <summary>
            /// 代打订单号
            /// </summary>
            [JsonProperty("order_mask_sn")]
            public string OrderMaskSn { get; set; }

        }

    }

}
