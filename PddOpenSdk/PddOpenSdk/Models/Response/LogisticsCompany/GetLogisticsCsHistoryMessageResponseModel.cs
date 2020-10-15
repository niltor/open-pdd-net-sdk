using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.LogisticsCompany
{
    public partial class GetLogisticsCsHistoryMessageResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("logistics_cs_history_message_get_response")]
        public LogisticsCsHistoryMessageGetResponseResponseModel LogisticsCsHistoryMessageGetResponse { get; set; }
        public partial class LogisticsCsHistoryMessageGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 消息列表
            /// </summary>
            [JsonProperty("message_infos")]
            public List<MessageInfosResponseModel> MessageInfos { get; set; }
            public partial class MessageInfosResponseModel : PddResponseModel
            {
                /// <summary>
                /// 消息id
                /// </summary>
                [JsonProperty("id")]
                public long? Id { get; set; }
                /// <summary>
                /// 消息时间戳,样式YYYY-MM-DD HH:MM:SS
                /// </summary>
                [JsonProperty("msg_ts")]
                public string MsgTs { get; set; }
                /// <summary>
                /// 0为用户 1为机器人
                /// </summary>
                [JsonProperty("from_type")]
                public int? FromType { get; set; }
                /// <summary>
                /// 聊天内容，如果是图片的话，则是图片的url
                /// </summary>
                [JsonProperty("text")]
                public string Text { get; set; }

            }

        }

    }

}
