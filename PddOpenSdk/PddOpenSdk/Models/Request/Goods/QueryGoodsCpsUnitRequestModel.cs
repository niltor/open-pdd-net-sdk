using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class QueryGoodsCpsUnitRequestModel : PddRequestModel
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("goods_id")]
        public long GoodsId { get; set; }

    }

}
