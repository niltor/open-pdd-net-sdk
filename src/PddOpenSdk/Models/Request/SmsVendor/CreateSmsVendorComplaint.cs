namespace PddOpenSdk.Models.Request.SmsVendor;
public partial class CreateSmsVendorComplaint
{

    /// <summary>
    /// cmpp账号名
    /// </summary>
    [JsonPropertyName("account")]
    public string Account { get; set; }

    /// <summary>
    /// 投诉时间(格式yyyy-MM-dd HH:mm:ss)
    /// </summary>
    [JsonPropertyName("complaint_time")]
    public string ComplaintTime { get; set; }

    /// <summary>
    /// 投诉次数
    /// </summary>
    [JsonPropertyName("count")]
    public int Count { get; set; }

    /// <summary>
    /// 短信下发时间(格式yyyy-MM-dd HH:mm:ss)
    /// </summary>
    [JsonPropertyName("deliver_time")]
    public string DeliverTime { get; set; }

    /// <summary>
    /// 手机号码
    /// </summary>
    [JsonPropertyName("mobile")]
    public string Mobile { get; set; }

    /// <summary>
    /// 归属运营商
    /// </summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>
    /// 归属地省份
    /// </summary>
    [JsonPropertyName("province")]
    public string Province { get; set; }

    /// <summary>
    /// 短信投诉内容(不超过500个字)
    /// </summary>
    [JsonPropertyName("sms_content")]
    public string SmsContent { get; set; }

}

