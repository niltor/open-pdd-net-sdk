namespace PddOpenSdk.Models.Request.Order;
public partial class GetFulfillmentList
{

    /// <summary>
    /// 成交时间终止（秒）
    /// </summary>
    [JsonPropertyName("end_confirm_at")]
    public int EndConfirmAt { get; set; }

    /// <summary>
    /// 跨境全托管发货单状态。0-全部，1-待发货，2-已发货待签收，3-已签收
    /// </summary>
    [JsonPropertyName("fulfillment_status")]
    public int FulfillmentStatus { get; set; }

    /// <summary>
    /// 页码
    /// </summary>
    [JsonPropertyName("page_number")]
    public int PageNumber { get; set; }

    /// <summary>
    /// 页面大小
    /// </summary>
    [JsonPropertyName("page_size")]
    public int PageSize { get; set; }

    /// <summary>
    /// 成交时间起始（秒）
    /// </summary>
    [JsonPropertyName("start_confirm_at")]
    public int StartConfirmAt { get; set; }

    /// <summary>
    /// 是否启用has_next的分页方式，默认为true。如果指定true，则返回的结果中不包含总记录数，但是会新增一个是否存在下一页的的字段。
    /// </summary>
    [JsonPropertyName("use_has_next")]
    public bool? UseHasNext { get; set; }

}

