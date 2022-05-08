namespace PddOpenSdk.Models.Request.Goods;
public partial class CreateGoodsCpsMallUnit
{

    /// <summary>
    /// 合作方code
    /// </summary>
    [JsonPropertyName("erp_code")]
    public string ErpCode { get; set; }

    /// <summary>
    /// 佣金比（千分比）
    /// </summary>
    [JsonPropertyName("rate")]
    public long Rate { get; set; }

}

