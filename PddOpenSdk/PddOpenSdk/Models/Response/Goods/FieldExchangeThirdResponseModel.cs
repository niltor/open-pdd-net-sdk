using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public class FieldExchangeThirdResponseModel
    {

        /// <summary>
        /// Examples: 2747709104
        /// </summary>
        [JsonProperty("goods_id")]
        public long GoodsId { get; set; }

        /// <summary>
        /// Examples: 5617860211
        /// </summary>
        [JsonProperty("goods_commit_id")]
        public long GoodsCommitId { get; set; }

        /// <summary>
        /// Examples: 204962614
        /// </summary>
        [JsonProperty("mall_id")]
        public int MallId { get; set; }
    }


}
