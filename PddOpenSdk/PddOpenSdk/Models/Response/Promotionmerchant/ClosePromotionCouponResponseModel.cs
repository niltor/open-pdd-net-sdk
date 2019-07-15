using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Promotionmerchant
{
    public partial class ClosePromotionCouponResponseModel : PddResponseModel
    {
        /// <summary>
        /// 关闭批次接口响应对象
        /// </summary>
        [JsonProperty("promotion_coupon_batch_close_response")]
        public PromotionCouponBatchCloseResponseResponseModel PromotionCouponBatchCloseResponse { get; set; }
        public partial class PromotionCouponBatchCloseResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 是否关闭成功，true-成功，false-失败
            /// </summary>
            [JsonProperty("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}
