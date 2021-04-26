using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Ddk
{
    public partial class BindDdkPidMediaidRequestModel : PddRequestModel
    {
        /// <summary>
        /// 媒体id
        /// </summary>
        [JsonProperty("media_id")]
        public long MediaId { get; set; }
        /// <summary>
        /// 推广位列表，例如：["60005_612"]，最多支持同时传入1000个
        /// </summary>
        [JsonProperty("pid_list")]
        public List<string> PidList { get; set; }

    }

}
