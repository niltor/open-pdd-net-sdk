using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Sms
{
    public partial class QuerySmsShortStatisticRequestModel : PddRequestModel
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("setting_id")]
        public int SettingId { get; set; }

    }

}
