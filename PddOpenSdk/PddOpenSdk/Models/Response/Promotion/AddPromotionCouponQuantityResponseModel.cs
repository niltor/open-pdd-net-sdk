using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Promotion
{
    public partial class AddPromotionCouponQuantityResponseModel : PddResponseModel {
        /// <summary>
        /// 增加优惠券发行数量响应对象
        /// </summary>
        [JsonProperty ("coupon_quantity_add_response")]
        public CouponQuantityAddResponseResponseModel CouponQuantityAddResponse { get; set; }
        public partial class CouponQuantityAddResponseResponseModel : PddResponseModel {
            /// <summary>
            /// 是否增加成功，true-成功，false-失败
            /// </summary>
            [JsonProperty ("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}