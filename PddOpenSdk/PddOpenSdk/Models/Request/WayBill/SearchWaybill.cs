namespace PddOpenSdk.Models.Request.WayBill;
public partial class SearchWaybill
{

    /// <summary>
    /// 物流公司code
    /// </summary>
    [JsonPropertyName("wp_code")]
    public string WpCode { get; set; }

}

