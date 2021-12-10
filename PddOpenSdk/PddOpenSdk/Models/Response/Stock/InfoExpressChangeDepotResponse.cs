namespace PddOpenSdk.Models.Response.Stock;
public partial class InfoExpressChangeDepotResponse : PddResponseModel
{

    /// <summary>
    /// 响应结果
    /// </summary>
    [JsonPropertyName("open_api_response")]
    public string OpenApiResponse { get; set; }

}

