using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Logisticscs
{
    public partial class StartLogisticsCsSessionResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("logistics_cs_session_start_response")]
        public LogisticsCsSessionStartResponseResponseModel LogisticsCsSessionStartResponse { get; set; }
        public partial class LogisticsCsSessionStartResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 是否成功
            /// </summary>
            [JsonProperty("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}
