using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Mall
{
    public partial class GetMallInfoAuditResponseModel : PddResponseModel {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty ("mall_info_audit_get_response")]
        public MallInfoAuditGetResponseResponseModel MallInfoAuditGetResponse { get; set; }
        public partial class MallInfoAuditGetResponseResponseModel : PddResponseModel {
            /// <summary>
            /// 审核状态
            /// </summary>
            [JsonProperty ("audit_status")]
            public int AuditStatus { get; set; }
            /// <summary>
            /// 生效状态
            /// </summary>
            [JsonProperty ("validate_status")]
            public int ValidateStatus { get; set; }

        }

    }

}