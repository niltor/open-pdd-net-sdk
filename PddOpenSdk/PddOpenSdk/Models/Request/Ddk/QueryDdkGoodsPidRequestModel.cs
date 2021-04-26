using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Ddk
{
    public partial class QueryDdkGoodsPidRequestModel : PddRequestModel
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
        /// <summary>
        /// 推广位列表，例如：["60005_612"]
        /// </summary>
        [JsonProperty("pid_list")]
        public List<string> PidList { get; set; }
        /// <summary>
        /// 推广位状态：0-正常，1-封禁
        /// </summary>
        [JsonProperty("status")]
        public int? Status { get; set; }

    }

}
