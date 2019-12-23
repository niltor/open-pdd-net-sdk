using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Mallticket
{
    public partial class ListMallTicketRequestModel : PddRequestModel
    {
        /// <summary>
        /// 结束时间戳(格式:秒)
        /// </summary>
        [JsonProperty("create_end_time")]
        public int CreateEndTime { get; set; }
        /// <summary>
        /// 开始时间戳(格式:秒)
        /// </summary>
        [JsonProperty("create_start_time")]
        public int CreateStartTime { get; set; }
        /// <summary>
        /// 页数(从0开始)
        /// </summary>
        [JsonProperty("page_num")]
        public int? PageNum { get; set; }
        /// <summary>
        /// 每页条数(默认100，最大100)
        /// </summary>
        [JsonProperty("page_size")]
        public int? PageSize { get; set; }
        /// <summary>
        /// 0:待处理 1:已解决 2:超时
        /// </summary>
        [JsonProperty("progress")]
        public int? Progress { get; set; }

    }

}
