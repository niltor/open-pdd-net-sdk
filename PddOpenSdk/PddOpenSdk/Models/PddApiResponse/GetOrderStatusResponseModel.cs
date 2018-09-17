using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetOrderStatusResponseModel : PddResponseModel
    {
        /// <summary>
        /// 订单状态列表对象
        /// </summary>
        [JsonProperty("order_status_list")]
        public object OrderStatusList { get; set; }

        public partial class OrderStatusListResponseModel : PddResponseModel
        {

        }

    }
}
