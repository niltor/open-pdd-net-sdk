using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Sms
{
    public partial class QuerySmsSellSettingDetailRequestModel : PddRequestModel
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

    }

}
