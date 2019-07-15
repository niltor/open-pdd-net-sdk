using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goodsedit
{
    public partial class AddGoodsResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("goods_add_response")]
        public GoodsAddResponseResponseModel GoodsAddResponse { get; set; }
        public partial class GoodsAddResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 商品ID
            /// </summary>
            [JsonProperty("goods_id")]
            public long? GoodsId { get; set; }
            /// <summary>
            /// 上传商品的上传序列ID
            /// </summary>
            [JsonProperty("goods_commit_id")]
            public long? GoodsCommitId { get; set; }

        }

    }

}
