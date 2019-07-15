using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Smstemplate
{
    public partial class QuerySmsShortStatisticRequestModel : PddRequestModel
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("setting_id")]
        public long SettingId { get; set; }

    }

}
