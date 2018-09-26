using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Sms
{
    public class Result
    {

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("receiver")]
        public object Receiver { get; set; }

        /// <summary>
        /// Examples: "15026557047"
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Examples: 1534912039000
        /// </summary>
        [JsonProperty("send_time")]
        public long SendTime { get; set; }

        /// <summary>
        /// Examples: "跳跳糖跳跳糖跳跳糖跳跳糖跳跳糖跳跳糖跳跳糖 https://w.url.cn/s/AV44fdU https://w.url.cn/s/An0lp7j"
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// Examples: 2
        /// </summary>
        [JsonProperty("items_num")]
        public int ItemsNum { get; set; }

        /// <summary>
        /// Examples: 80
        /// </summary>
        [JsonProperty("words_num")]
        public int WordsNum { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }
    }

    public class SmsSendRecordListQueryResponse
    {

        /// <summary>
        /// Examples: 16
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// Examples: [{"receiver":null,"phone":"15026557047","send_time":1534912039000,"content":"跳跳糖跳跳糖跳跳糖跳跳糖跳跳糖跳跳糖跳跳糖 https://w.url.cn/s/AV44fdU https://w.url.cn/s/An0lp7j","items_num":2,"words_num":80,"status":1}]
        /// </summary>
        [JsonProperty("result")]
        public IList<Result> Result { get; set; }
    }

    public class QuerySmsSendRecordListResponseModel
    {

        /// <summary>
        /// Examples: {"total":16,"result":[{"receiver":null,"phone":"15026557047","send_time":1534912039000,"content":"跳跳糖跳跳糖跳跳糖跳跳糖跳跳糖跳跳糖跳跳糖 https://w.url.cn/s/AV44fdU https://w.url.cn/s/An0lp7j","items_num":2,"words_num":80,"status":1}]}
        /// </summary>
        [JsonProperty("sms_send_record_list_query_response")]
        public SmsSendRecordListQueryResponse SmsSendRecordListQueryResponse { get; set; }
    }


}
