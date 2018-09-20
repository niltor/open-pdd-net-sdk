using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class CommitGoodsSubmitGoodsResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("goods_update_response")]
        public GoodsUpdateResponseResponseModel GoodsUpdateResponse { get; set; }

        public partial class GoodsUpdateResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 商品id
            /// </summary>
            [JsonProperty("goods_id")]
            public string GoodsId { get; set; }
            /// <summary>
            /// 提交申请的序列id
            /// </summary>
            [JsonProperty("goods_commit_id")]
            public string GoodsCommitId { get; set; }

        }

    }
}
