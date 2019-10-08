using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Smsdetailbill
{
    public partial class PushSmsDetailbillRequestModel : PddRequestModel
    {
        /// <summary>
        /// cmpp账号名
        /// </summary>
        [JsonProperty("account")]
        public string Account { get; set; }
        /// <summary>
        /// 批次版本，每天数据必须属于同一个批次，如果重传可以批次号增加，平台以最大批次号为准。一般情况下，批次号固定数字，只有当某天上传数据错误需要弃用时，使用增加后的新批次号。
        /// </summary>
        [JsonProperty("batch_version")]
        public long BatchVersion { get; set; }
        /// <summary>
        /// 数据日期(格式yyyy-MM-dd)
        /// </summary>
        [JsonProperty("date")]
        public string Date { get; set; }
        /// <summary>
        /// 短信明细，detail的列表，list最大100
        /// </summary>
        [JsonProperty("details")]
        public List<DetailsRequestModel> Details { get; set; }
        public partial class DetailsRequestModel : PddRequestModel
        {
            /// <summary>
            /// 短信下发时间(yyyy-MM-dd HH:mm:ss)
            /// </summary>
            [JsonProperty("deliver_time")]
            public string DeliverTime { get; set; }
            /// <summary>
            /// 回执状态码，发送成功传DELIVRD
            /// </summary>
            [JsonProperty("error_code")]
            public string ErrorCode { get; set; }
            /// <summary>
            /// 短信id,即SubmitResp.msgId,十进制表示
            /// </summary>
            [JsonProperty("msg_id")]
            public long MsgId { get; set; }
            /// <summary>
            /// 短信提交时间(yyyy-MM-dd HH:mm:ss)
            /// </summary>
            [JsonProperty("submit_time")]
            public string SubmitTime { get; set; }

        }

    }

}
