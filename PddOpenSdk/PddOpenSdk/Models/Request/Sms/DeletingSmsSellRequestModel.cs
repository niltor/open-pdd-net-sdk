using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Sms
{
    public partial class DeletingSmsSellRequestModel : PddRequestModel
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

    }

}
