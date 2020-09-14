using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class GetAdApiKeywordRecommendRequestModel : PddRequestModel
    {
        /// <summary>
        /// 商品Id
        /// </summary>
        [JsonProperty("goodsId")]
        public long GoodsId { get; set; }

    }

}
