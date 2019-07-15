using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Openmsg
{
    public partial class MsgOpenMsgServiceSendExpressResponseModel : PddResponseModel
    {
        /// <summary>
        /// 回执id
        /// </summary>
        [JsonProperty("biz_id")]
        public string BizId { get; set; }
        /// <summary>
        /// 状态码
        /// </summary>
        [JsonProperty("code")]
        public int? Code { get; set; }
        /// <summary>
        /// 状态原因
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
        /// <summary>
        /// 请求标识Id
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

    }

}
