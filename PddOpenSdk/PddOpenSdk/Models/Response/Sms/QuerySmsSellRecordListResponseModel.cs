using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Sms
{
    public class SmsSellRecordResult
    {

        /// <summary>
        /// Examples: 311827
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Examples: "新客转化2018-08-31"
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Examples: 4
        /// </summary>
        [JsonProperty("scene")]
        public int Scene { get; set; }

        /// <summary>
        /// Examples: 1535723911000
        /// </summary>
        [JsonProperty("send_time")]
        public long SendTime { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("send_num")]
        public int SendNum { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("send_failed_num")]
        public int SendFailedNum { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("open")]
        public int Open { get; set; }
    }

    public class SmsSellRecordListQueryResponse
    {

        /// <summary>
        /// Examples: 306
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// Examples: [{"id":311827,"name":"新客转化2018-08-31","scene":4,"send_time":1535723911000,"status":1,"send_num":0,"send_failed_num":0,"open":1}]
        /// </summary>
        [JsonProperty("result")]
        public IList<SmsSellRecordResult> Result { get; set; }
    }

    public class QuerySmsSellRecordListResponseModel
    {

        /// <summary>
        /// Examples: {"total":306,"result":[{"id":311827,"name":"新客转化2018-08-31","scene":4,"send_time":1535723911000,"status":1,"send_num":0,"send_failed_num":0,"open":1}]}
        /// </summary>
        [JsonProperty("sms_sell_record_list_query_response")]
        public SmsSellRecordListQueryResponse SmsSellRecordListQueryResponse { get; set; }
    }


}
