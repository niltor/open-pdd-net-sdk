using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class ClosePromotionCouponResponseModel : PddResponseModel
    {
        /// <summary>
        /// 关闭批次接口响应对象
        /// </summary>
        [JsonProperty("promotion_coupon_batch_close_response")]
        public object PromotionCouponBatchCloseResponse { get; set; }

        public partial class PromotionCouponBatchCloseResponseResponseModel : PddResponseModel
        {

        }

    }
}
