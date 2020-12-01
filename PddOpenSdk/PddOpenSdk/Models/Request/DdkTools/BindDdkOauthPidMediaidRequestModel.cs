using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.DdkTools
{
    public partial class BindDdkOauthPidMediaidRequestModel : PddRequestModel
    {
        /// <summary>
        /// 媒体id
        /// </summary>
        [JsonProperty("media_id")]
        public long MediaId { get; set; }
        /// <summary>
        /// pid列表
        /// </summary>
        [JsonProperty("pid_list")]
        public List<string> PidList { get; set; }

    }

}
