using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class SettingSmsRemainResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("sms_remain_setting_response")]
        public SmsRemainSettingResponseResponseModel SmsRemainSettingResponse { get; set; }

        public partial class SmsRemainSettingResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 结果
            /// </summary>
            [JsonProperty("result")]
            public int Result { get; set; }

        }

    }
}
