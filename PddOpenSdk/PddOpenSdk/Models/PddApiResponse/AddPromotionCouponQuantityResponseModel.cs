using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class AddPromotionCouponQuantityResponseModel : PddResponseModel
    {
        /// <summary>
        /// 增加优惠券发行数量响应对象
        /// </summary>
        [JsonProperty("coupon_quantity_add_response")]
        public object CouponQuantityAddResponse { get; set; }

        public partial class CouponQuantityAddResponseResponseModel : PddResponseModel
        {

        }

    }
}
