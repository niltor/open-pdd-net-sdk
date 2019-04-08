using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class UpdateGoodsInformationResponseModel : PddResponseModel {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty ("goods_update_response")]
        public GoodsUpdateResponseResponseModel GoodsUpdateResponse { get; set; }
        public partial class GoodsUpdateResponseResponseModel : PddResponseModel {
            /// <summary>
            /// 提交申请的序列id
            /// </summary>
            [JsonProperty ("goods_commit_id")]
            public long? GoodsCommitId { get; set; }
            /// <summary>
            /// 是否修改成功
            /// </summary>
            [JsonProperty ("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}