using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Promotion
{
    public class GoodsCouponBatchCreateResponse
    {

        /// <summary>
        /// Examples: 9251417797
        /// </summary>
        [JsonProperty("batch_id")]
        public long BatchId { get; set; }
    }

    public class CreatePromotionGoodsCouponResponseModel
    {

        /// <summary>
        /// Examples: {"batch_id":9251417797}
        /// </summary>
        [JsonProperty("goods_coupon_batch_create_response")]
        public GoodsCouponBatchCreateResponse GoodsCouponBatchCreateResponse { get; set; }
    }


}
