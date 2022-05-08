namespace PddOpenSdk.Models.Response.Goods;
public partial class CreateGoodsMaterialResponse : PddResponseModel
{

    /// <summary>
    /// 错误码
    /// </summary>
    [JsonPropertyName("error_code")]
    public int? ErrorCode { get; set; }

    /// <summary>
    /// 错误文案
    /// </summary>
    [JsonPropertyName("error_msg")]
    public string ErrorMsg { get; set; }

    /// <summary>
    /// 返回素材id
    /// </summary>
    [JsonPropertyName("result")]
    public long? Result { get; set; }

    /// <summary>
    /// 是否成功
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}

