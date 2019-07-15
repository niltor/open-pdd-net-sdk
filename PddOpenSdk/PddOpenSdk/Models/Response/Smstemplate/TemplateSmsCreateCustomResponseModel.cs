using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Smstemplate
{
    public partial class TemplateSmsCreateCustomResponseModel : PddResponseModel
    {
        /// <summary>
        /// 创建结果
        /// </summary>
        [JsonProperty("sms_create_custom_template_response")]
        public SmsCreateCustomTemplateResponseResponseModel SmsCreateCustomTemplateResponse { get; set; }
        public partial class SmsCreateCustomTemplateResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 请求结果
            /// </summary>
            [JsonProperty("result")]
            public string Result { get; set; }

        }

    }

}
