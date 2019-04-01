using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console.PddModels
{
    public partial class CatListResponseModel
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("errorCode")]
        public long ErrorCode { get; set; }

        [JsonProperty("errorMsg")]
        public object ErrorMsg { get; set; }

        [JsonProperty("result")]
        public CatListResult Result { get; set; }
    }

    public class CatListResult
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("catName")]
        public string CatName { get; set; }

        [JsonProperty("docList")]
        public List<DocList> DocList { get; set; }
    }

    public partial class DocList
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("scopeName")]
        public string ScopeName { get; set; }

        [JsonProperty("scopeNameId")]
        public long ScopeNameId { get; set; }

        [JsonProperty("apiName")]
        public string ApiName { get; set; }

        [JsonProperty("usageScenarios")]
        public string UsageScenarios { get; set; }

        [JsonProperty("createdAt")]
        public long CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public long UpdatedAt { get; set; }

        [JsonProperty("scopeTips")]
        public string ScopeTips { get; set; }
    }
}
