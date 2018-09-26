using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Erp
{
    public class SyncErpOrderResponseModel
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// Examples: 1000000
        /// </summary>
        [JsonProperty("error_code")]
        public int ErrorCode { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("error_msg")]
        public object ErrorMsg { get; set; }

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("result")]
        public bool Result { get; set; }
    }


}
