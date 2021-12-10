namespace PddOpenSdk.Models.Request.Invoice;
public partial class QueryInvoiceApplication
{

    /// <summary>
    /// 订单号；订单号和申请时间必填其一
    /// </summary>
    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

    /// <summary>
    /// 页码，默认1
    /// </summary>
    [JsonPropertyName("page")]
    public int? Page { get; set; }

    /// <summary>
    /// 每页返回数目，默认50
    /// </summary>
    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }

    /// <summary>
    /// 是否正品发票 0=非正品发票 1=是正品发票
    /// </summary>
    [JsonPropertyName("quality_goods_invoice")]
    public int? QualityGoodsInvoice { get; set; }

    /// <summary>
    /// 申请状态：0-已拒绝，1-申请中，2-已同意
    /// </summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

    /// <summary>
    /// 申请结束时间, 时间戳（单位毫秒，查询时间间隔不可超过15天）
    /// </summary>
    [JsonPropertyName("update_end_time")]
    public long? UpdateEndTime { get; set; }

    /// <summary>
    /// 申请开始时间, 时间戳（单位毫秒，查询时间间隔不可超过15天）
    /// </summary>
    [JsonPropertyName("update_start_time")]
    public long? UpdateStartTime { get; set; }

}

