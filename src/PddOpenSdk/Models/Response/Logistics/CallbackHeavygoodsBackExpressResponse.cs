namespace PddOpenSdk.Models.Response.Logistics;
public partial class CallbackHeavygoodsBackExpressResponse : PddResponseModel
{

    /// <summary>
    /// 1
    /// </summary>
    [JsonPropertyName("error_code")]
    public int? ErrorCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("error_msg")]
    public string ErrorMsg { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("result")]
    public bool? Result { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}

