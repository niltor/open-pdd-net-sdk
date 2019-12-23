using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Mallticket
{
    public partial class ListMallTicketResponseModel : PddResponseModel
    {
        /// <summary>
        /// respone
        /// </summary>
        [JsonProperty("mall_ticket_list_response")]
        public MallTicketListResponseResponseModel MallTicketListResponse { get; set; }
        public partial class MallTicketListResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// list
            /// </summary>
            [JsonProperty("list")]
            public List<ListResponseModel> List { get; set; }
            /// <summary>
            /// 总数
            /// </summary>
            [JsonProperty("total")]
            public int? Total { get; set; }
            public partial class ListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 创建时间(秒)
                /// </summary>
                [JsonProperty("created_at")]
                public int? CreatedAt { get; set; }
                /// <summary>
                /// 问题类型id
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
                /// 创建类型
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
                /// 问题备注
                /// </summary>
                [JsonProperty("question")]
                public string Question { get; set; }
                /// <summary>
                /// 问题描述
                /// </summary>
                [JsonProperty("type_desc")]
                public string TypeDesc { get; set; }
                /// <summary>
                /// 问题类型描述
                /// </summary>
                [JsonProperty("type_id")]
                public int? TypeId { get; set; }

            }

        }

    }

}
