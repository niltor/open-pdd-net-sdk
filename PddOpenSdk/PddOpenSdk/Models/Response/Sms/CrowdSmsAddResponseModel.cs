using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Sms
{
    public class SmsAddCrowdResponse
    {

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("result")]
        public object Result { get; set; }
    }

    public class CrowdSmsAddResponseModel
    {

        /// <summary>
        /// Examples: {"result":null}
        /// </summary>
        [JsonProperty("sms_add_crowd_response")]
        public SmsAddCrowdResponse SmsAddCrowdResponse { get; set; }
    }


}
