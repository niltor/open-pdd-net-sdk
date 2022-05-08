namespace PddOpenSdk.Models.Request.LogisticsCompany;
public partial class SubLogisticsCoTrack
{

    /// <summary>
    /// 快递公司伙伴ID
    /// </summary>
    [JsonPropertyName("ship_id")]
    public string ShipId { get; set; }

    /// <summary>
    /// 消息体
    /// </summary>
    [JsonPropertyName("data")]
    public string Data { get; set; }

}

