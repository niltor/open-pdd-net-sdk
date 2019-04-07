using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Sms
{
    public partial class CancelSmsSellSettingRecordRequestModel : PddRequestModel {
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty ("id")]
        public long Id { get; set; }

    }

}