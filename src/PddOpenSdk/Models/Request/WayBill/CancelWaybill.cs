namespace PddOpenSdk.Models.Request.WayBill;
public partial class CancelWaybill
{

    /// <summary>
    /// 电子面单号
    /// </summary>
    [JsonPropertyName("waybill_code")]
    public string WaybillCode { get; set; }

    /// <summary>
    /// 快递公司code
    /// </summary>
    [JsonPropertyName("wp_code")]
    public string WpCode { get; set; }

}

