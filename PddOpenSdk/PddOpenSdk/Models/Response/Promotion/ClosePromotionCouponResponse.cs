namespace PddOpenSdk.Models.Response.Promotion;
public partial class ClosePromotionCouponResponse : PddResponseModel
{

    /// <summary>
    /// 关闭批次接口响应对象
    /// </summary>
    [JsonPropertyName("promotion_coupon_batch_close_response")]
    public PromotionCouponBatchCloseResponseResponse PromotionCouponBatchCloseResponse { get; set; }
    public partial class PromotionCouponBatchCloseResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 是否关闭成功，true-成功，false-失败
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }

    }

}

