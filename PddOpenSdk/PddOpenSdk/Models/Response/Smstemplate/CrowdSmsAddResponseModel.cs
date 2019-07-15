using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Smstemplate
{
    public partial class CrowdSmsAddResponseModel : PddResponseModel
    {
        /// <summary>
        /// 创建结果，为空成功
        /// </summary>
        [JsonProperty("sms_add_crowd_response")]
        public SmsAddCrowdResponseResponseModel SmsAddCrowdResponse { get; set; }
        public partial class SmsAddCrowdResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 请求结果
            /// </summary>
            [JsonProperty("result")]
            public string Result { get; set; }

        }

    }

}
