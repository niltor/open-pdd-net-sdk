using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetDdkOauthLotteryNewListResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回列表
        /// </summary>
        [JsonProperty("list")]
        public object List { get; set; }
        /// <summary>
        /// 每页数量
        /// </summary>
        [JsonProperty("page_num")]
        public object PageNum { get; set; }
        /// <summary>
        /// 分页数
        /// </summary>
        [JsonProperty("page_size")]
        public object PageSize { get; set; }
        /// <summary>
        /// 13
        /// </summary>
        [JsonProperty("total_count")]
        public object TotalCount { get; set; }

        public partial class ListResponseModel : PddResponseModel
        {

        }

    }
}
