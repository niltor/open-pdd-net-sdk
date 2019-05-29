using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ddkoauth
{
    public partial class QueryDdkOauthGoodsPidRequestModel : PddRequestModel
    {
        /// <summary>
        /// 返回的页数
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }
        /// <summary>
        /// 返回的每页推广位数量
        /// </summary>
        [JsonProperty("page_size")]
        public int? PageSize { get; set; }

    }

}
