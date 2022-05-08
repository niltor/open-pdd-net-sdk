namespace PddOpenSdk.Models.Response.Stock;
public partial class CreateStockWareResponse : PddResponseModel
{

    /// <summary>
    /// 货品id
    /// </summary>
    [JsonPropertyName("open_api_response")]
    public int? OpenApiResponse { get; set; }

}

