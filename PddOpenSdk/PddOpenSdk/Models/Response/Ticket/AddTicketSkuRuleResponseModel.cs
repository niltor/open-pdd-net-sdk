using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ticket
{
    public partial class AddTicketSkuRuleResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("response")]
        public ResponseResponseModel Response { get; set; }
        public partial class ResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 规则 ID
            /// </summary>
            [JsonProperty("rule_id")]
            public string RuleId { get; set; }
            /// <summary>
            /// 版本
            /// </summary>
            [JsonProperty("rule_version")]
            public string RuleVersion { get; set; }

        }

    }

}
