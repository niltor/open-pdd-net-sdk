using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class EditGoodsChildSkuResponseModel : PddResponseModel
    {
        /// <summary>
        /// 子sku新增或提交结果
        /// </summary>
        [JsonProperty("child_sku_edit_response")]
        public ChildSkuEditResponseResponseModel ChildSkuEditResponse { get; set; }
        public partial class ChildSkuEditResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 草稿id
            /// </summary>
            [JsonProperty("goods_commit_id")]
            public long? GoodsCommitId { get; set; }
            /// <summary>
            /// 商品id
            /// </summary>
            [JsonProperty("goods_id")]
            public long? GoodsId { get; set; }

        }

    }

}
