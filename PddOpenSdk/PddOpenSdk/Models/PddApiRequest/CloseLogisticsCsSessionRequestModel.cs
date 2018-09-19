using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class CloseLogisticsCsSessionRequestModel : PddRequestModel
    {
        /// <summary>
        /// pdd会话id
        /// </summary>
        [JsonProperty("session_id")]
        public object SessionId { get; set; }
        /// <summary>
        /// 物流公司会话id
        /// </summary>
        [JsonProperty("wp_session_id")]
        public object WpSessionId { get; set; }
        /// <summary>
        /// 样式YYYY-MM-DD HH:MM:SS
        /// </summary>
        [JsonProperty("action_time")]
        public object ActionTime { get; set; }

    }
}