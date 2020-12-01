using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.OpenMsg
{
    public partial class MsgOpenMsgServiceSendBatchRequestModel : PddRequestModel
    {
        /// <summary>
        /// 接收短信的手机号码集合, ["15900000000", "17600000000"]
        /// </summary>
        [JsonProperty("phone_numbers")]
        public List<string> PhoneNumbers { get; set; }
        /// <summary>
        /// 短信签名名称
        /// </summary>
        [JsonProperty("sign_name")]
        public string SignName { get; set; }
        /// <summary>
        /// 短信模板CODE
        /// </summary>
        [JsonProperty("template_code")]
        public long TemplateCode { get; set; }
        /// <summary>
        /// 短信模板变量JSON集合(与手机号对应)
        /// </summary>
        [JsonProperty("template_param_json")]
        public List<Dictionary<string, object>> TemplateParamJson { get; set; }
        /// <summary>
        /// 业务请求唯一标识
        /// </summary>
        [JsonProperty("out_id")]
        public string OutId { get; set; }
        /// <summary>
        /// 上行短信扩展码
        /// </summary>
        [JsonProperty("sms_up_extend_code")]
        public string SmsUpExtendCode { get; set; }
        public partial class TemplateParamJsonRequestModel : PddRequestModel
        {
            /// <summary>
            /// 模板变量名
            /// </summary>
            [JsonProperty("$key")]
            public string Key { get; set; }
            /// <summary>
            /// 模板变量值
            /// </summary>
            [JsonProperty("$value")]
            public string Value { get; set; }

        }

    }

}
