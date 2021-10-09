namespace PddOpenSdk.Models.Response.Stock;
public partial class DeleteStockWareResponse : PddResponseModel
{

    /// <summary>
    /// 操作成功：true
    /// </summary>
    [JsonPropertyName("open_api_response")]
    public bool? OpenApiResponse { get; set; }

}

