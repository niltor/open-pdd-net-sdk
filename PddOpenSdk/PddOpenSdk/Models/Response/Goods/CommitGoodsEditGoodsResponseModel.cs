using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public class GoodsUpdateResponse
    {

        /// <summary>
        /// Examples: 2578098969
        /// </summary>
        [JsonProperty("goods_id")]
        public long GoodsId { get; set; }

        /// <summary>
        /// Examples: 4979252482
        /// </summary>
        [JsonProperty("goods_commit_id")]
        public long GoodsCommitId { get; set; }
    }

    public class CommitGoodsEditGoodsResponseModel
    {

        /// <summary>
        /// Examples: {"goods_id":2578098969,"goods_commit_id":4979252482}
        /// </summary>
        [JsonProperty("goods_update_response")]
        public GoodsUpdateResponse GoodsUpdateResponse { get; set; }
    }


}
