using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class FieldExchangeThirdResponseModel : PddResponseModel
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonProperty("goods_id")]
        public string GoodsId { get; set; }
        /// <summary>
        /// 商品草稿ID
        /// </summary>
        [JsonProperty("goods_commit_id")]
        public string GoodsCommitId { get; set; }

    }

}
