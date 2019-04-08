using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Sms
{
    public partial class QuerySmsRemainSettingDetailRequestModel : PddRequestModel {
        /// <summary>
        /// //1：提醒付款 ；  3：召唤买家成团
        /// </summary>
        [JsonProperty ("scene")]
        public int Scene { get; set; }

    }

}