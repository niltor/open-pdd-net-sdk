using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetGoodsCommitDetailResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("goods_commit_detail_response")]
        public object GoodsCommitDetailResponse { get; set; }

        public partial class GoodsCommitDetailResponseResponseModel : PddResponseModel
        {

        }

    }
}
