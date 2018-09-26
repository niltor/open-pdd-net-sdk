using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Promotion
{
    public class CouponQuantityAddResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    public class AddPromotionCouponQuantityResponseModel
    {

        /// <summary>
        /// Examples: {"is_success":true}
        /// </summary>
        [JsonProperty("coupon_quantity_add_response")]
        public CouponQuantityAddResponse CouponQuantityAddResponse { get; set; }
    }


}
