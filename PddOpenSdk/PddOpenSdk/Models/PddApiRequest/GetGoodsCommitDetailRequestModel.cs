using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class GetGoodsCommitDetailRequestModel : PddRequestModel
    {
        /// <summary>
        /// 提交申请的序列id
        /// </summary>
        [JsonProperty("goods_commit_id")]
        public int GoodsCommitId { get; set; }

    }
}
