namespace PddOpenSdk.Models.Response.Goods;
public partial class GetGoodsCommitListResponse : PddResponseModel
{

    /// <summary>
    /// res
    /// </summary>
    [JsonPropertyName("goods_commit_list_get_response")]
    public GoodsCommitListGetResponseResponse GoodsCommitListGetResponse { get; set; }
    public partial class GoodsCommitListGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// list
        /// </summary>
        [JsonPropertyName("list")]
        public List<ListResponse> List { get; set; }

        /// <summary>
        /// total
        /// </summary>
        [JsonPropertyName("total")]
        public long? Total { get; set; }
        public partial class ListResponse : PddResponseModel
        {

            /// <summary>
            /// 审核时间
            /// </summary>
            [JsonPropertyName("checked_time")]
            public int? CheckedTime { get; set; }

            /// <summary>
            /// 草稿状态 0:编辑中,1:审核中,2:审核通过,3:审核驳回
            /// </summary>
            [JsonPropertyName("check_status")]
            public int? CheckStatus { get; set; }

            /// <summary>
            /// 草稿id
            /// </summary>
            [JsonPropertyName("commit_id")]
            public long? CommitId { get; set; }

            /// <summary>
            /// 商品id
            /// </summary>
            [JsonPropertyName("goods_id")]
            public long? GoodsId { get; set; }

            /// <summary>
            /// 商品标题
            /// </summary>
            [JsonPropertyName("goods_name")]
            public string GoodsName { get; set; }

            /// <summary>
            /// 是否新增 0:新增，1：修改
            /// </summary>
            [JsonPropertyName("is_shop")]
            public int? IsShop { get; set; }

            /// <summary>
            /// 商家编码
            /// </summary>
            [JsonPropertyName("outer_goods_id")]
            public string OuterGoodsId { get; set; }

            /// <summary>
            /// 驳回原因
            /// </summary>
            [JsonPropertyName("reject_comment")]
            public string RejectComment { get; set; }

            /// <summary>
            /// 提交时间
            /// </summary>
            [JsonPropertyName("submit_time")]
            public int? SubmitTime { get; set; }

        }

    }

}

