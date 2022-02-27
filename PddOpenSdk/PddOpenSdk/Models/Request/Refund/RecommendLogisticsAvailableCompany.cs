namespace PddOpenSdk.Models.Request.Refund;
public partial class RecommendLogisticsAvailableCompany
{

    /// <summary>
    /// 收件人市id（最多支持50个）
    /// </summary>
    [JsonPropertyName("city_id")]
    public List<long> CityId { get; set; }

}

