namespace PddOpenSdk.Models.Response.Stock;
public partial class MoveStockWareResponse : PddResponseModel
{

    /// <summary>
    /// 调整单ID
    /// </summary>
    [JsonPropertyName("open_api_response")]
    public long? OpenApiResponse { get; set; }

}

