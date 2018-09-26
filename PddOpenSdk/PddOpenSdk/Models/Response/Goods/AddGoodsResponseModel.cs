using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public class GoodsAddResponse
    {

        /// <summary>
        /// Examples: 1620657673
        /// </summary>
        [JsonProperty("goods_id")]
        public int GoodsId { get; set; }

        /// <summary>
        /// Examples: 3576756018
        /// </summary>
        [JsonProperty("goods_commit_id")]
        public long GoodsCommitId { get; set; }
    }

    public class AddGoodsResponseModel
    {

        /// <summary>
        /// Examples: {"goods_id":1620657673,"goods_commit_id":3576756018}
        /// </summary>
        [JsonProperty("goods_add_response")]
        public GoodsAddResponse GoodsAddResponse { get; set; }
    }


}
