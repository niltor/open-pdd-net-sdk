using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class CreatePromotionHomeCouponResponseModel : PddResponseModel
    {
        /// <summary>
        /// 创建店铺首页优惠券批次对象
        /// </summary>
        [JsonProperty("home_coupon_batch_create_response")]
        public object HomeCouponBatchCreateResponse { get; set; }

        public partial class HomeCouponBatchCreateResponseResponseModel : PddResponseModel
        {

        }

    }
}
