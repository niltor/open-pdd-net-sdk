using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Sms
{
    public class SmsCrowsPeopleNumberQueryResponse
    {

        /// <summary>
        /// Examples: 9958
        /// </summary>
        [JsonProperty("remain")]
        public int Remain { get; set; }

        /// <summary>
        /// Examples: 8
        /// </summary>
        [JsonProperty("object_num")]
        public int ObjectNum { get; set; }
    }

    public class QuerySmsCrowdsPeopleNumberResponseModel
    {

        /// <summary>
        /// Examples: {"remain":9958,"object_num":8}
        /// </summary>
        [JsonProperty("sms_crows_people_number_query_response")]
        public SmsCrowsPeopleNumberQueryResponse SmsCrowsPeopleNumberQueryResponse { get; set; }
    }


}
