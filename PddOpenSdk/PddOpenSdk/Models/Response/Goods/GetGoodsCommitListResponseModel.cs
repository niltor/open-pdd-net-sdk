using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class GetGoodsCommitListResponseModel : PddResponseModel
    {
        /// <summary>
        /// res
        /// </summary>
        [JsonProperty("goods_commit_list_get_response")]
        public GoodsCommitListGetResponseResponseModel GoodsCommitListGetResponse { get; set; }
        public partial class GoodsCommitListGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// list
            /// </summary>
            [JsonProperty("list")]
            public List<ListResponseModel> List { get; set; }
            /// <summary>
            /// total
            /// </summary>
            [JsonProperty("total")]
            public long? Total { get; set; }
            public partial class ListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 草稿id
                /// </summary>
                [JsonProperty("commit_id")]
                public long? CommitId { get; set; }
                /// <summary>
                /// 商品id
                /// </summary>
                [JsonProperty("goods_id")]
                public long? GoodsId { get; set; }
                /// <summary>
                /// 商家编码
                /// </summary>
                [JsonProperty("outer_goods_id")]
                public string OuterGoodsId { get; set; }
                /// <summary>
                /// 商品标题
                /// </summary>
                [JsonProperty("goods_name")]
                public string GoodsName { get; set; }
                /// <summary>
                /// 草稿状态 0:编辑中,1:审核中,2:审核通过,3:审核驳回
                /// </summary>
                [JsonProperty("check_status")]
                public int? CheckStatus { get; set; }
                /// <summary>
                /// 是否新增 0:新增，1：修改
                /// </summary>
                [JsonProperty("is_shop")]
                public int? IsShop { get; set; }
                /// <summary>
                /// 提交时间
                /// </summary>
                [JsonProperty("submit_time")]
                public int? SubmitTime { get; set; }
                /// <summary>
                /// 审核时间
                /// </summary>
                [JsonProperty("checked_time")]
                public int? CheckedTime { get; set; }
                /// <summary>
                /// 驳回原因
                /// </summary>
                [JsonProperty("reject_comment")]
                public string RejectComment { get; set; }

            }

        }

    }

}
