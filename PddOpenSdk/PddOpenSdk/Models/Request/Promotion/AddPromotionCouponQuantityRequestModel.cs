using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Promotion
{
    public partial class AddPromotionCouponQuantityRequestModel : PddRequestModel {
        /// <summary>
        /// 券批次ID
        /// </summary>
        [JsonProperty ("batch_id")]
        public long BatchId { get; set; }
        /// <summary>
        /// 要增加的数量
        /// </summary>
        [JsonProperty ("add_quantity")]
        public long AddQuantity { get; set; }

    }

}