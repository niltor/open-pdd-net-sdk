using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public class GoodsSubmitResponse
    {

        /// <summary>
        /// Examples: 2636897500
        /// </summary>
        [JsonProperty("goods_id")]
        public long GoodsId { get; set; }

        /// <summary>
        /// Examples: 5165546802
        /// </summary>
        [JsonProperty("goods_commit_id")]
        public long GoodsCommitId { get; set; }
    }

    public class CommitGoodsSubmitGoodsResponseModel
    {

        /// <summary>
        /// Examples: {"goods_id":2636897500,"goods_commit_id":5165546802}
        /// </summary>
        [JsonProperty("goods_update_response")]
        public GoodsSubmitResponse GoodsUpdateResponse { get; set; }
    }


}
