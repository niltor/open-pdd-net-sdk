namespace PddOpenSdk.Models.Response.Stock;
public partial class DepotExpressAddResponse : PddResponseModel
{

    /// <summary>
    /// 操作成功
    /// </summary>
    [JsonPropertyName("open_api_response")]
    public string OpenApiResponse { get; set; }

}

