namespace PddOpenSdk.Models.Response.Goods;
public partial class GetGoodsCommitStatusResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("goods_commit_status_get_response")]
    public GoodsCommitStatusGetResponseResponse GoodsCommitStatusGetResponse { get; set; }
    public partial class GoodsCommitStatusGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// list
        /// </summary>
        [JsonPropertyName("list")]
        public List<ListResponse> List { get; set; }
        public partial class ListResponse : PddResponseModel
        {

            /// <summary>
            /// 状态
            /// </summary>
            [JsonPropertyName("check_status")]
            public int? CheckStatus { get; set; }

            /// <summary>
            /// 草稿id
            /// </summary>
            [JsonPropertyName("goods_commit_id")]
            public long? GoodsCommitId { get; set; }

            /// <summary>
            /// 驳回原因
            /// </summary>
            [JsonPropertyName("reject_comment")]
            public string RejectComment { get; set; }

        }

    }

}

