using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.OpenMsg
{
    public partial class MsgOpenMsgServiceSendExpressRequestModel : PddRequestModel
    {
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
        /// 短信模板变量JSON集合(与手机号对应)与按照手机号发短信一致key变量名 value变量值
        /// </summary>
        [JsonProperty("template_param_json")]
        public List<Dictionary<string, object>> TemplateParamJson { get; set; }
        /// <summary>
        /// 物流单号集合
        /// </summary>
        [JsonProperty("waybill_codes")]
        public List<string> WaybillCodes { get; set; }
        /// <summary>
        /// 快递公司编码
        /// </summary>
        [JsonProperty("wp_code")]
        public string WpCode { get; set; }
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
            /// 模板变量key
            /// </summary>
            [JsonProperty("$key")]
            public string Key { get; set; }
            /// <summary>
            /// 模板变量value
            /// </summary>
            [JsonProperty("$value")]
            public string Value { get; set; }

        }

    }

}
