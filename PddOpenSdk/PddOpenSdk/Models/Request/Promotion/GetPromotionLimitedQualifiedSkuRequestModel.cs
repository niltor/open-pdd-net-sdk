using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Promotion
{
    public partial class GetPromotionLimitedQualifiedSkuRequestModel : PddRequestModel
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("goods_id")]
        public long GoodsId { get; set; }

    }

}
