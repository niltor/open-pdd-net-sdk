namespace PddOpenSdk.Models.Response.Promotion;
public partial class AddPromotionCouponQuantityResponse : PddResponseModel
{

    /// <summary>
    /// 增加优惠券发行数量响应对象
    /// </summary>
    [JsonPropertyName("coupon_quantity_add_response")]
    public CouponQuantityAddResponseResponse CouponQuantityAddResponse { get; set; }
    public partial class CouponQuantityAddResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 是否增加成功，true-成功，false-失败
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }

    }

}

