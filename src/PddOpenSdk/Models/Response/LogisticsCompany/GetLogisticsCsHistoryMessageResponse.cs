namespace PddOpenSdk.Models.Response.LogisticsCompany;
public partial class GetLogisticsCsHistoryMessageResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("logistics_cs_history_message_get_response")]
    public LogisticsCsHistoryMessageGetResponseResponse LogisticsCsHistoryMessageGetResponse { get; set; }
    public partial class LogisticsCsHistoryMessageGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 消息列表
        /// </summary>
        [JsonPropertyName("message_infos")]
        public List<MessageInfosResponse> MessageInfos { get; set; }
        public partial class MessageInfosResponse : PddResponseModel
        {

            /// <summary>
            /// 消息id
            /// </summary>
            [JsonPropertyName("id")]
            public long? Id { get; set; }

            /// <summary>
            /// 消息时间戳,样式YYYY-MM-DD HH:MM:SS
            /// </summary>
            [JsonPropertyName("msg_ts")]
            public string MsgTs { get; set; }

            /// <summary>
            /// 0为用户 1为机器人
            /// </summary>
            [JsonPropertyName("from_type")]
            public int? FromType { get; set; }

            /// <summary>
            /// 聊天内容，如果是图片的话，则是图片的url
            /// </summary>
            [JsonPropertyName("text")]
            public string Text { get; set; }

        }

    }

}

