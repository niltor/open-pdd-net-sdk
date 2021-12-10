namespace PddOpenSdk.Models.Response.Stock;
public partial class UpdateStockDepotPriorityResponse : PddResponseModel
{

    /// <summary>
    /// 请求结果
    /// </summary>
    [JsonPropertyName("open_api_response")]
    public string OpenApiResponse { get; set; }

}

