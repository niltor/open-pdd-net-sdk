using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ticket
{
    public partial class NotifycationTicketOrderCreateRequestModel : PddRequestModel
    {
        /// <summary>
        /// 码类型。status=2时必填。1.无凭证(身份证/手机号) 2. 数字码 3.QR图片 4.外链
        /// </summary>
        [JsonProperty("code_type")]
        public int? CodeType { get; set; }
        /// <summary>
        /// 失败错误码。status=3时必填
        /// </summary>
        [JsonProperty("failed_code")]
        public int? FailedCode { get; set; }
        /// <summary>
        /// 失败原因。 status=3时必填
        /// </summary>
        [JsonProperty("failed_reason")]
        public string FailedReason { get; set; }
        /// <summary>
        /// 拼多多制票号
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }
        /// <summary>
        /// isv订单号
        /// </summary>
        [JsonProperty("out_order_sn")]
        public string OutOrderSn { get; set; }
        /// <summary>
        /// 制码状态。 2.制作成功 3.制作失败
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }
        /// <summary>
        /// 凭证信息列表。status=2 且 code_type!=1 时必填
        /// </summary>
        [JsonProperty("tickets")]
        public List<TicketsRequestModel> Tickets { get; set; }
        /// <summary>
        /// 凭证类型。status=2时必填。1.一人一码 2.一人多码
        /// </summary>
        [JsonProperty("ticket_type")]
        public int? TicketType { get; set; }
        public partial class TicketsRequestModel : PddRequestModel
        {
            /// <summary>
            /// 辅助凭证，有辅助凭证时返回
            /// </summary>
            [JsonProperty("additional")]
            public string Additional { get; set; }
            /// <summary>
            /// 主凭证，code_type=2时返回
            /// </summary>
            [JsonProperty("code")]
            public string Code { get; set; }
            /// <summary>
            /// 文件base64流，code_type=3时返回，大小小于800KB
            /// </summary>
            [JsonProperty("file")]
            public string File { get; set; }
            /// <summary>
            /// 外链，code_type=4时返回
            /// </summary>
            [JsonProperty("url")]
            public string Url { get; set; }

        }

    }

}
