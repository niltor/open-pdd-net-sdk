using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.OpenMsg
{
    public partial class RecordOpenMsgServiceQueryMsgRequestModel : PddRequestModel
    {
        /// <summary>
        /// 短信发送流水
        /// </summary>
        [JsonProperty("biz_id")]
        public string BizId { get; set; }
        /// <summary>
        /// 分页参数,页码
        /// </summary>
        [JsonProperty("page_number")]
        public int PageNumber { get; set; }
        /// <summary>
        /// 分页参数，每页数量。最大值50
        /// </summary>
        [JsonProperty("page_size")]
        public int PageSize { get; set; }
        /// <summary>
        /// 查询手机号码
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 短信发送日期，支持近30天记录查询，格式yyyyMMdd
        /// </summary>
        [JsonProperty("send_date")]
        public string SendDate { get; set; }

    }

}
