using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Sms
{
    public class SettingAndCrowdReturnVo
    {

        /// <summary>
        /// Examples: 311609
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Examples: "感兴趣的用户"
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("people_num")]
        public int PeopleNum { get; set; }

        /// <summary>
        /// Examples: 1534312800000
        /// </summary>
        [JsonProperty("send_time")]
        public long SendTime { get; set; }
    }

    public class SmsShortMsgStatisticQueryResponse
    {

        /// <summary>
        /// Examples: {"id":311609,"name":"感兴趣的用户","people_num":0,"send_time":1534312800000}
        /// </summary>
        [JsonProperty("setting_and_crowd_return_vo")]
        public SettingAndCrowdReturnVo SettingAndCrowdReturnVo { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("statistic_vo")]
        public object StatisticVo { get; set; }
    }

    public class QuerySmsShortStatisticResponseModel
    {

        /// <summary>
        /// Examples: {"setting_and_crowd_return_vo":{"id":311609,"name":"感兴趣的用户","people_num":0,"send_time":1534312800000},"statistic_vo":null}
        /// </summary>
        [JsonProperty("sms_short_msg_statistic_query_response")]
        public SmsShortMsgStatisticQueryResponse SmsShortMsgStatisticQueryResponse { get; set; }
    }


}
