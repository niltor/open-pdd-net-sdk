namespace PddOpenSdk.Models.Request.OpenMsg;
public partial class RecordOpenMsgServiceQueryMsg
{

    /// <summary>
    /// 短信发送流水
    /// </summary>
    [JsonPropertyName("biz_id")]
    public string BizId { get; set; }

    /// <summary>
    /// 分页参数,页码
    /// </summary>
    [JsonPropertyName("page_number")]
    public int PageNumber { get; set; }

    /// <summary>
    /// 分页参数，每页数量。最大值50
    /// </summary>
    [JsonPropertyName("page_size")]
    public int PageSize { get; set; }

    /// <summary>
    /// 查询手机号码
    /// </summary>
    [JsonPropertyName("phone_number")]
    public string PhoneNumber { get; set; }

    /// <summary>
    /// 短信发送日期，支持近30天记录查询，格式yyyyMMdd
    /// </summary>
    [JsonPropertyName("send_date")]
    public string SendDate { get; set; }

}

