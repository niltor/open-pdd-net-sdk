
namespace Console.PddModels
{
    public partial class CatListResponseModel
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("errorCode")]
        public long ErrorCode { get; set; }

        [JsonPropertyName("errorMsg")]
        public object ErrorMsg { get; set; }

        [JsonPropertyName("result")]
        public CatListResult Result { get; set; }
    }

    public class CatListResult
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("catName")]
        public string CatName { get; set; }

        [JsonPropertyName("docList")]
        public List<PddDocInfo> DocList { get; set; }
    }

    public partial class PddDocInfo
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("scopeName")]
        public string ScopeName { get; set; }

        [JsonPropertyName("scopeNameId")]
        public long ScopeNameId { get; set; }

        [JsonPropertyName("apiName")]
        public string ApiName { get; set; }

        [JsonPropertyName("usageScenarios")]
        public string UsageScenarios { get; set; }

        [JsonPropertyName("createdAt")]
        public long CreatedAt { get; set; }

        [JsonPropertyName("updatedAt")]
        public long UpdatedAt { get; set; }

        [JsonPropertyName("scopeTips")]
        public string ScopeTips { get; set; }
    }
}
