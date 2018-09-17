using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class SettingSmsCustomResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("sms_custom_setting_response")]
        public object SmsCustomSettingResponse { get; set; }

        public partial class SmsCustomSettingResponseResponseModel : PddResponseModel
        {

        }

    }
}
