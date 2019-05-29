using Newtonsoft.Json;

namespace MSDev.PddOpenSdk.Models
{

    public partial class PddErrorResponseModel
    {
        [JsonProperty("error_response")]
        public ErrorResponse ErrorResponse { get; set; }
    }

    public partial class ErrorResponse
    {
        [JsonProperty("error_msg")]
        public string ErrorMsg { get; set; }

        [JsonProperty("sub_msg")]
        public string SubMsg { get; set; }

        [JsonProperty("sub_code")]
        public object SubCode { get; set; }

        [JsonProperty("error_code")]
        public long ErrorCode { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }
    }

}
