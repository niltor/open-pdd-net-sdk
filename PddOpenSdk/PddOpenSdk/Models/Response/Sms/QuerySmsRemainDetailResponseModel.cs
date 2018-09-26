using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Sms
{
    public class SmsRemainDetailQueryResponse
    {

        /// <summary>
        /// Examples: 1000
        /// </summary>
        [JsonProperty("remain_number")]
        public int RemainNumber { get; set; }

        /// <summary>
        /// Examples: 2200
        /// </summary>
        [JsonProperty("remain_money")]
        public int RemainMoney { get; set; }
    }

    public class QuerySmsRemainDetailResponseModel
    {

        /// <summary>
        /// Examples: {"remain_number":1000,"remain_money":2200}
        /// </summary>
        [JsonProperty("sms_remain_detail_query_response")]
        public SmsRemainDetailQueryResponse SmsRemainDetailQueryResponse { get; set; }
    }


}
