using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Promotion
{
    public partial class CancelPromotionLimitedActivityRequestModel : PddRequestModel
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonProperty("detail_id")]
        public long DetailId { get; set; }
        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("goods_id")]
        public long GoodsId { get; set; }

    }

}
