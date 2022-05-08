
namespace MSDev.PddOpenSdk.Models;

public partial class PddErrorResponseModel
{
    [JsonPropertyName("error_response")]
    public ErrorResponse ErrorResponse { get; set; }
}

public partial class ErrorResponse
{
    [JsonPropertyName("error_msg")]
    public string ErrorMsg { get; set; }

    [JsonPropertyName("sub_msg")]
    public string SubMsg { get; set; }

    [JsonPropertyName("sub_code")]
    public object SubCode { get; set; }

    [JsonPropertyName("error_code")]
    public long ErrorCode { get; set; }

    [JsonPropertyName("request_id")]
    public string RequestId { get; set; }
}
