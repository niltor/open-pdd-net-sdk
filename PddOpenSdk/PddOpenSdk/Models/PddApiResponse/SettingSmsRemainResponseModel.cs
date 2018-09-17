using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class SettingSmsRemainResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("sms_remain_setting_response")]
        public object SmsRemainSettingResponse { get; set; }

        public partial class SmsRemainSettingResponseResponseModel : PddResponseModel
        {

        }

    }
}
