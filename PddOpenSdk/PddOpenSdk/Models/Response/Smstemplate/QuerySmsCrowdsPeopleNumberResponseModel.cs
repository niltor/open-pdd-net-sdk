using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Smstemplate
{
    public partial class QuerySmsCrowdsPeopleNumberResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("sms_crows_people_number_query_response")]
        public SmsCrowsPeopleNumberQueryResponseResponseModel SmsCrowsPeopleNumberQueryResponse { get; set; }
        public partial class SmsCrowsPeopleNumberQueryResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 筛选人数
            /// </summary>
            [JsonProperty("object_num")]
            public long? ObjectNum { get; set; }
            /// <summary>
            /// 短信余量
            /// </summary>
            [JsonProperty("remain")]
            public long? Remain { get; set; }

        }

    }

}
