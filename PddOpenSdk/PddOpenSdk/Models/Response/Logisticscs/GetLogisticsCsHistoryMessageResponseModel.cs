using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Logisticscs
{
    public class MessageInfo
    {

        /// <summary>
        /// Examples: 123
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Examples: "2018-07-12 10: 10: 10"
        /// </summary>
        [JsonProperty("msg_ts")]
        public string MsgTs { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("from_type")]
        public int FromType { get; set; }

        /// <summary>
        /// Examples: "你好"
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class LogisticsCsHistoryMessageGetResponse
    {

        /// <summary>
        /// Examples: [{"id":123,"msg_ts":"2018-07-12 10: 10: 10","from_type":0,"text":"你好"}]
        /// </summary>
        [JsonProperty("message_infos")]
        public IList<MessageInfo> MessageInfos { get; set; }
    }

    public class GetLogisticsCsHistoryMessageResponseModel
    {

        /// <summary>
        /// Examples: {"message_infos":[{"id":123,"msg_ts":"2018-07-12 10: 10: 10","from_type":0,"text":"你好"}]}
        /// </summary>
        [JsonProperty("logistics_cs_history_message_get_response")]
        public LogisticsCsHistoryMessageGetResponse LogisticsCsHistoryMessageGetResponse { get; set; }
    }


}
