namespace PddOpenSdk.Models.Request.Logistics;
public partial class CallbackHeavygoodsBackExpress
{

    /// <summary>
    /// 包裹回退原因
    /// </summary>
    [JsonPropertyName("back_reason")]
    public string BackReason { get; set; }

    /// <summary>
    /// 逆向运单号
    /// </summary>
    [JsonPropertyName("back_trck_no")]
    public string BackTrckNo { get; set; }

    /// <summary>
    /// 逆向运单所关联的正向运单号
    /// </summary>
    [JsonPropertyName("trck_no")]
    public string TrckNo { get; set; }

}

