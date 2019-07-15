using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Smstemplate
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
