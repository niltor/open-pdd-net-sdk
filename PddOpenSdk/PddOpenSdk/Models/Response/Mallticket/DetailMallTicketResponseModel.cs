using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Mallticket
{
    public partial class DetailMallTicketResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("mall_ticket_detail_response")]
        public MallTicketDetailResponseResponseModel MallTicketDetailResponse { get; set; }
        public partial class MallTicketDetailResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 附件(图片)
            /// </summary>
            [JsonProperty("attach_url")]
            public List<AttachUrlResponseModel> AttachUrl { get; set; }
            /// <summary>
            /// 创建时间(秒)
            /// </summary>
            [JsonProperty("created_at")]
            public int? CreatedAt { get; set; }
            /// <summary>
            /// 创建类型
            /// </summary>
            [JsonProperty("create_type")]
            public int? CreateType { get; set; }
            /// <summary>
            /// 逾期时间(秒)
            /// </summary>
            [JsonProperty("deadline")]
            public int? Deadline { get; set; }
            /// <summary>
            /// 问题备注
            /// </summary>
            [JsonProperty("description")]
            public string Description { get; set; }
            /// <summary>
            /// 流水记录
            /// </summary>
            [JsonProperty("history_record")]
            public List<HistoryRecordResponseModel> HistoryRecord { get; set; }
            /// <summary>
            /// 商家工单id
            /// </summary>
            [JsonProperty("id")]
            public string Id { get; set; }
            /// <summary>
            /// 订单号
            /// </summary>
            [JsonProperty("order_sn")]
            public string OrderSn { get; set; }
            /// <summary>
            /// 商家工单状态
            /// </summary>
            [JsonProperty("progress")]
            public int? Progress { get; set; }
            /// <summary>
            /// 问题描述
            /// </summary>
            [JsonProperty("question")]
            public string Question { get; set; }
            /// <summary>
            /// 问题类型描述
            /// </summary>
            [JsonProperty("type_desc")]
            public string TypeDesc { get; set; }
            /// <summary>
            /// 问题类型id
            /// </summary>
            [JsonProperty("type_id")]
            public int? TypeId { get; set; }
            public partial class AttachUrlResponseModel : PddResponseModel
            {
                /// <summary>
                /// url
                /// </summary>
                [JsonProperty("url")]
                public string Url { get; set; }

            }
            public partial class HistoryRecordResponseModel : PddResponseModel
            {
                /// <summary>
                /// 附件(图片)
                /// </summary>
                [JsonProperty("attach_url")]
                public List<AttachUrlResponseModel> AttachUrl { get; set; }
                /// <summary>
                /// content
                /// </summary>
                [JsonProperty("content")]
                public string Content { get; set; }
                /// <summary>
                /// created_at
                /// </summary>
                [JsonProperty("created_at")]
                public int? CreatedAt { get; set; }
                /// <summary>
                /// detail
                /// </summary>
                [JsonProperty("detail")]
                public string Detail { get; set; }
                /// <summary>
                /// role
                /// </summary>
                [JsonProperty("role")]
                public int? Role { get; set; }
                public partial class AttachUrlResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// url
                    /// </summary>
                    [JsonProperty("url")]
                    public string Url { get; set; }

                }

            }

        }

    }

}
