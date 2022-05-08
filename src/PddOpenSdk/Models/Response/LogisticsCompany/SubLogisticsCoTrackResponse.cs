namespace PddOpenSdk.Models.Response.LogisticsCompany;
public partial class SubLogisticsCoTrackResponse : PddResponseModel
{

    /// <summary>
    /// 快递公司伙伴ID
    /// </summary>
    [JsonPropertyName("ship_id")]
    public string ShipId { get; set; }

    /// <summary>
    /// 是否成功
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 返回码
    /// </summary>
    [JsonPropertyName("reason_code")]
    public string ReasonCode { get; set; }

}

