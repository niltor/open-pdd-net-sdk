using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Promotion
{
    public class PromotionCouponBatchCloseResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    public class ClosePromotionCouponResponseModel
    {

        /// <summary>
        /// Examples: {"is_success":true}
        /// </summary>
        [JsonProperty("promotion_coupon_batch_close_response")]
        public PromotionCouponBatchCloseResponse PromotionCouponBatchCloseResponse { get; set; }
    }


}
