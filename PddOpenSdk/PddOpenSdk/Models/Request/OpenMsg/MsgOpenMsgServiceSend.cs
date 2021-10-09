namespace PddOpenSdk.Models.Request.OpenMsg;
public partial class MsgOpenMsgServiceSend
{

    /// <summary>
    /// 接收短信的手机号码列表,["15900000000", "17600000000"]
    /// </summary>
    [JsonPropertyName("phone_numbers")]
    public List<string> PhoneNumbers { get; set; }

    /// <summary>
    /// 短信签名名称
    /// </summary>
    [JsonPropertyName("sign_name")]
    public string SignName { get; set; }

    /// <summary>
    /// 短信模板ID
    /// </summary>
    [JsonPropertyName("template_code")]
    public long TemplateCode { get; set; }

    /// <summary>
    /// 短信模板变量对应的实际值，JSON格式
    /// </summary>
    [JsonPropertyName("template_param")]
    public Dictionary<string, object> TemplateParam { get; set; }

    /// <summary>
    /// 业务请求唯一标识
    /// </summary>
    [JsonPropertyName("out_id")]
    public string OutId { get; set; }

    /// <summary>
    /// 上行短信扩展码
    /// </summary>
    [JsonPropertyName("sms_up_extend_code")]
    public string SmsUpExtendCode { get; set; }
    public partial class TemplateParamModel
    {

        /// <summary>
        /// 模板变量名
        /// </summary>
        [JsonPropertyName("$key")]
        public string Key { get; set; }

        /// <summary>
        /// 模板变量值
        /// </summary>
        [JsonPropertyName("$value")]
        public string Value { get; set; }

    }

}

