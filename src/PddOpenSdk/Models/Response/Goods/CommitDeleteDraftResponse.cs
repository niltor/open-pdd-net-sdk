namespace PddOpenSdk.Models.Response.Goods;
public partial class CommitDeleteDraftResponse : PddResponseModel
{

    /// <summary>
    /// 操作状态，true
    /// </summary>
    [JsonPropertyName("open_api_response")]
    public bool? OpenApiResponse { get; set; }

}

