using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Sms
{
    public partial class QuerySmsSellSettingDetailRequestModel : PddRequestModel
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

    }

}
