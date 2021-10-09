namespace PddOpenSdk.Models.Response.OpenMsg;
public partial class RecordOpenMsgServiceQueryMsgResponse : PddResponseModel
{

    /// <summary>
    /// 请求ID
    /// </summary>
    [JsonPropertyName("request_id")]
    public string RequestId { get; set; }

    /// <summary>
    /// 请求状态码
    /// </summary>
    [JsonPropertyName("result_code")]
    public string ResultCode { get; set; }

    /// <summary>
    /// 状态码描述
    /// </summary>
    [JsonPropertyName("result_message")]
    public string ResultMessage { get; set; }

    /// <summary>
    /// 短信发送明细列表
    /// </summary>
    [JsonPropertyName("sms_send_details")]
    public List<SmsSendDetailsResponse> SmsSendDetails { get; set; }

    /// <summary>
    /// 短信发送总条数
    /// </summary>
    [JsonPropertyName("total_count")]
    public int? TotalCount { get; set; }
    public partial class SmsSendDetailsResponse : PddResponseModel
    {

        /// <summary>
        /// 模板内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public long? ErrorCode { get; set; }

        /// <summary>
        /// 外部id
        /// </summary>
        [JsonPropertyName("out_id")]
        public string OutId { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 接收时间
        /// </summary>
        [JsonPropertyName("receive_time")]
        public string ReceiveTime { get; set; }

        /// <summary>
        /// 发送状态
        /// </summary>
        [JsonPropertyName("send_status")]
        public int? SendStatus { get; set; }

        /// <summary>
        /// 发送时间
        /// </summary>
        [JsonPropertyName("send_time")]
        public string SendTime { get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        [JsonPropertyName("template_code")]
        public long? TemplateCode { get; set; }

    }

}

