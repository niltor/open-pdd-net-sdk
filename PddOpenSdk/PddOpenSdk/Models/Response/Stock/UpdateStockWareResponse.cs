namespace PddOpenSdk.Models.Response.Stock;
public partial class UpdateStockWareResponse : PddResponseModel
{

    /// <summary>
    /// 货品id
    /// </summary>
    [JsonPropertyName("open_api_response")]
    public long? OpenApiResponse { get; set; }

}

