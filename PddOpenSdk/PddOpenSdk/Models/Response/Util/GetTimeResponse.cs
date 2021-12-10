namespace PddOpenSdk.Models.Response.Util;
public partial class GetTimeResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("time_get_response")]
    public TimeGetResponseResponse TimeGetResponse { get; set; }
    public partial class TimeGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 拼多多系统时间
        /// </summary>
        [JsonPropertyName("time")]
        public string Time { get; set; }

    }

}

