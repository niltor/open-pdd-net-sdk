using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Smstemplate
{
    public partial class SettingSmsSellResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [JsonProperty("sms_sell_setting_response")]
        public SmsSellSettingResponseResponseModel SmsSellSettingResponse { get; set; }
        public partial class SmsSellSettingResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 请求结果
            /// </summary>
            [JsonProperty("result")]
            public long? Result { get; set; }

        }

    }

}
