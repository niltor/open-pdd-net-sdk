using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Sms
{
    public partial class QuerySmsSendRecordListResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("sms_send_record_list_query_response")]
        public SmsSendRecordListQueryResponseResponseModel SmsSendRecordListQueryResponse { get; set; }
        public partial class SmsSendRecordListQueryResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 总量
            /// </summary>
            [JsonProperty("total")]
            public int? Total { get; set; }
            /// <summary>
            /// 结果
            /// </summary>
            [JsonProperty("result")]
            public List<ResultResponseModel> Result { get; set; }
            public partial class ResultResponseModel : PddResponseModel
            {
                /// <summary>
                /// 收件人
                /// </summary>
                [JsonProperty("receiver")]
                public string Receiver { get; set; }
                /// <summary>
                /// 手机号
                /// </summary>
                [JsonProperty("phone")]
                public string Phone { get; set; }
                /// <summary>
                /// 发送时间
                /// </summary>
                [JsonProperty("send_time")]
                public long? SendTime { get; set; }
                /// <summary>
                /// 短信内容
                /// </summary>
                [JsonProperty("content")]
                public string Content { get; set; }
                /// <summary>
                /// 条数
                /// </summary>
                [JsonProperty("items_num")]
                public long? ItemsNum { get; set; }
                /// <summary>
                /// 字数
                /// </summary>
                [JsonProperty("words_num")]
                public long? WordsNum { get; set; }
                /// <summary>
                /// 发送状态
                /// </summary>
                [JsonProperty("status")]
                public int? Status { get; set; }

            }

        }

    }

}
