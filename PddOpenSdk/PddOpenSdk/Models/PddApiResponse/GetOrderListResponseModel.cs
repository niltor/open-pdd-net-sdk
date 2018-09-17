using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetOrderListResponseModel : PddResponseModel
    {
        /// <summary>
        /// 请求response
        /// </summary>
        [JsonProperty("order_list_get_response")]
        public object OrderListGetResponse { get; set; }
        /// <summary>
        /// 订单总数
        /// </summary>
        [JsonProperty("total_count")]
        public object TotalCount { get; set; }

        public partial class OrderListGetResponseResponseModel : PddResponseModel
        {

        }

    }
}
