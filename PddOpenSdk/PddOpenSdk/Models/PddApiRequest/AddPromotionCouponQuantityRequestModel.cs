using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class AddPromotionCouponQuantityRequestModel : PddRequestModel
    {
        /// <summary>
        /// 券批次ID
        /// </summary>
        [JsonProperty("batch_id")]
        public int BatchId { get; set; }
        /// <summary>
        /// 要增加的数量
        /// </summary>
        [JsonProperty("add_quantity")]
        public int AddQuantity { get; set; }

    }
}
