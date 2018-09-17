using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
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
