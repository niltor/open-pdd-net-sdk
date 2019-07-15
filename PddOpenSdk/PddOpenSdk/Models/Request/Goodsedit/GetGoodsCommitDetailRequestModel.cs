using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goodsedit
{
    public partial class GetGoodsCommitDetailRequestModel : PddRequestModel
    {
        /// <summary>
        /// 提交申请的序列id
        /// </summary>
        [JsonProperty("goods_commit_id")]
        public long GoodsCommitId { get; set; }

    }

}
