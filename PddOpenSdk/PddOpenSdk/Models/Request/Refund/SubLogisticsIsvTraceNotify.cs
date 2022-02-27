namespace PddOpenSdk.Models.Request.Refund;
public partial class SubLogisticsIsvTraceNotify
{

    /// <summary>
    /// 快递公司编码
    /// </summary>
    [JsonPropertyName("ship_code")]
    public string ShipCode { get; set; }

    /// <summary>
    /// 收件人手机
    /// </summary>
    [JsonPropertyName("tel")]
    public string Tel { get; set; }

    /// <summary>
    /// 快递单号
    /// </summary>
    [JsonPropertyName("track_no")]
    public string TrackNo { get; set; }

}

