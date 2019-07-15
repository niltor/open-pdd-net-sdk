using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Promotionmerchant
{
    public partial class ClosePromotionCouponRequestModel : PddRequestModel
    {
        /// <summary>
        /// 券批次ID
        /// </summary>
        [JsonProperty("batch_id")]
        public long BatchId { get; set; }

    }

}
