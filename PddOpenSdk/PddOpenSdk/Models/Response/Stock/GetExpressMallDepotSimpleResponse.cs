namespace PddOpenSdk.Models.Response.Stock;
public partial class GetExpressMallDepotSimpleResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("open_api_response")]
    public List<OpenApiResponseResponse> OpenApiResponse { get; set; }
    public partial class OpenApiResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 仓库Id
        /// </summary>
        [JsonPropertyName("depot_id")]
        public long? DepotId { get; set; }

        /// <summary>
        /// 仓库id的string表示
        /// </summary>
        [JsonPropertyName("depot_str")]
        public string DepotStr { get; set; }

        /// <summary>
        /// 仓库类型(暂时1表示自建仓)
        /// </summary>
        [JsonPropertyName("depot_type")]
        public int? DepotType { get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

    }

}

