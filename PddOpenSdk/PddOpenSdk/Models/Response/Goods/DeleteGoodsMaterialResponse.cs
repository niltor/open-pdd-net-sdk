namespace PddOpenSdk.Models.Response.Goods;
public partial class DeleteGoodsMaterialResponse : PddResponseModel
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
    /// 返回非0代表删除成功
    /// </summary>
    [JsonPropertyName("result")]
    public int? Result { get; set; }

    /// <summary>
    /// 是否成功
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}

