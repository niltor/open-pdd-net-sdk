namespace PddOpenSdk.Models.Response.Promotion;
public partial class CreatePromotionHomeCouponResponse : PddResponseModel
{

    /// <summary>
    /// 创建店铺首页优惠券批次对象
    /// </summary>
    [JsonPropertyName("home_coupon_batch_create_response")]
    public HomeCouponBatchCreateResponseResponse HomeCouponBatchCreateResponse { get; set; }
    public partial class HomeCouponBatchCreateResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 批次id
        /// </summary>
        [JsonPropertyName("batch_id")]
        public long? BatchId { get; set; }

    }

}

