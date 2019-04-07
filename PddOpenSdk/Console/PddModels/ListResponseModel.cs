using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console.PddModels
{
    public partial class ListResponseModel
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("errorCode")]
        public long ErrorCode { get; set; }

        [JsonProperty("errorMsg")]
        public object ErrorMsg { get; set; }

        [JsonProperty("result")]
        public List<PddCatInfo> Result { get; set; }
    }

    public class PddCatInfo
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
