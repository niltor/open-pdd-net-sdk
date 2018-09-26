using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Sms
{
    public class SmsRemainSettingResponse
    {

        /// <summary>
        /// Examples: 1000
        /// </summary>
        [JsonProperty("result")]
        public int Result { get; set; }
    }

    public class SettingSmsRemainResponseModel
    {

        /// <summary>
        /// Examples: {"result":1000}
        /// </summary>
        [JsonProperty("sms_remain_setting_response")]
        public SmsRemainSettingResponse SmsRemainSettingResponse { get; set; }
    }


}
