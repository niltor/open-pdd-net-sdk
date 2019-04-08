using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class CommitDeleteDraftRequestModel : PddRequestModel {
        /// <summary>
        /// 草稿id
        /// </summary>
        [JsonProperty ("goods_commit_id")]
        public long GoodsCommitId { get; set; }

    }

}