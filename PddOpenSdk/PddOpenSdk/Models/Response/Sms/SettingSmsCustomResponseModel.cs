using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Sms
{
    public class SmsCustomSettingResponse
    {

        /// <summary>
        /// Examples: 9958
        /// </summary>
        [JsonProperty("result")]
        public int Result { get; set; }
    }

    public class SettingSmsCustomResponseModel
    {

        /// <summary>
        /// Examples: {"result":9958}
        /// </summary>
        [JsonProperty("sms_custom_setting_response")]
        public SmsCustomSettingResponse SmsCustomSettingResponse { get; set; }
    }


}
