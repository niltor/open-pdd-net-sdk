using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetOrderInformationResponseModel : PddResponseModel
    {
        /// <summary>
        /// 订单详情对象
        /// </summary>
        [JsonProperty("order_info")]
        public object OrderInfo { get; set; }

        public partial class OrderInfoResponseModel : PddResponseModel
        {

        }

    }
}
