using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class CheckRefundStatusResponseModel : PddResponseModel
    {
        /// <summary>
        /// 存在售后的订单列表对象
        /// </summary>
        [JsonProperty("order_sns_exists_refund")]
        public object OrderSnsExistsRefund { get; set; }

        public partial class OrderSnsExistsRefundResponseModel : PddResponseModel
        {

        }

    }
}
