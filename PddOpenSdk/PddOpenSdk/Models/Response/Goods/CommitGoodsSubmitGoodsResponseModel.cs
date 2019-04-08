using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class CommitGoodsSubmitGoodsResponseModel : PddResponseModel {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty ("goods_update_response")]
        public GoodsUpdateResponseResponseModel GoodsUpdateResponse { get; set; }
        public partial class GoodsUpdateResponseResponseModel : PddResponseModel {
            /// <summary>
            /// 商品id
            /// </summary>
            [JsonProperty ("goods_id")]
            public long? GoodsId { get; set; }
            /// <summary>
            /// 提交申请的序列id
            /// </summary>
            [JsonProperty ("goods_commit_id")]
            public long? GoodsCommitId { get; set; }

        }

    }

}