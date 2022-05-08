namespace PddOpenSdk.Models.Response.Goods;
public partial class GetGoodsLatestCommitStatusResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("goods_latest_commit_status_get_response")]
    public GoodsLatestCommitStatusGetResponseResponse GoodsLatestCommitStatusGetResponse { get; set; }
    public partial class GoodsLatestCommitStatusGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// list
        /// </summary>
        [JsonPropertyName("list")]
        public List<ListResponse> List { get; set; }
        public partial class ListResponse : PddResponseModel
        {

            /// <summary>
            /// 草稿状态
            /// </summary>
            [JsonPropertyName("check_status")]
            public int? CheckStatus { get; set; }

            /// <summary>
            /// 商品id
            /// </summary>
            [JsonPropertyName("goods_id")]
            public long? GoodsId { get; set; }

            /// <summary>
            /// 驳回原因
            /// </summary>
            [JsonPropertyName("reject_comment")]
            public string RejectComment { get; set; }

        }

    }

}

