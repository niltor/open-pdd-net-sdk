namespace PddOpenSdk.Models.Response.Goods;
public partial class CommitDeleteGoodsResponse : PddResponseModel
{

    /// <summary>
    /// 操作结果
    /// </summary>
    [JsonPropertyName("open_api_response")]
    public bool? OpenApiResponse { get; set; }

}

