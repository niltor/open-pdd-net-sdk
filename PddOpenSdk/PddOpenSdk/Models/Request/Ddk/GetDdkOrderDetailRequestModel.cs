using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ddk
{
    public partial class GetDdkOrderDetailRequestModel : PddRequestModel
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }
        /// <summary>
        /// 订单类型：1-推广订单；2-直播间订单
        /// </summary>
        [JsonProperty("query_order_type")]
        public int? QueryOrderType { get; set; }

    }

}
