namespace PddOpenSdk.Models.Response.Promotion;
public partial class CancelPromotionLimitedActivityResponse : PddResponseModel
{

    /// <summary>
    /// 是否成功
    /// </summary>
    [JsonPropertyName("result")]
    public bool? Result { get; set; }

}

