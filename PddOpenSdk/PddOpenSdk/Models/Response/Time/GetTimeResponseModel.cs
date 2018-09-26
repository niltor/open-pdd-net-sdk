using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Time
{
    public class TimeGetResponse
    {

        /// <summary>
        /// Examples: "2018-08-27 13:54:06"
        /// </summary>
        [JsonProperty("time")]
        public string Time { get; set; }
    }

    public class GetTimeResponseModel
    {

        /// <summary>
        /// Examples: {"time":"2018-08-27 13:54:06"}
        /// </summary>
        [JsonProperty("time_get_response")]
        public TimeGetResponse TimeGetResponse { get; set; }
    }


}
