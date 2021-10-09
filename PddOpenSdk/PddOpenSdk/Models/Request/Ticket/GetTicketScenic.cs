namespace PddOpenSdk.Models.Request.Ticket;
public partial class GetTicketScenic
{

    /// <summary>
    /// 城市编码
    /// </summary>
    [JsonPropertyName("city_code")]
    public long? CityCode { get; set; }

    /// <summary>
    /// 定位类型 1.百度 2.google
    /// </summary>
    [JsonPropertyName("location_type")]
    public int LocationType { get; set; }

    /// <summary>
    /// 拼多多景区 ID
    /// </summary>
    [JsonPropertyName("scenic_id")]
    public long? ScenicId { get; set; }

    /// <summary>
    /// 景区简称（至少两个字）
    /// </summary>
    [JsonPropertyName("scenic_name")]
    public string ScenicName { get; set; }

}

