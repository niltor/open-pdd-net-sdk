using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Promotion
{
    public class HomeCouponBatchCreateResponse
    {

        /// <summary>
        /// Examples: 9251417799
        /// </summary>
        [JsonProperty("batch_id")]
        public long BatchId { get; set; }
    }

    public class CreatePromotionHomeCouponResponseModel
    {

        /// <summary>
        /// Examples: {"batch_id":9251417799}
        /// </summary>
        [JsonProperty("home_coupon_batch_create_response")]
        public HomeCouponBatchCreateResponse HomeCouponBatchCreateResponse { get; set; }
    }


}
