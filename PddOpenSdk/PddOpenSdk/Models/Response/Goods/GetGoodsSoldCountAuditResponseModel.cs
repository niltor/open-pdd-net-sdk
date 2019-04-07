using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class GetGoodsSoldCountAuditResponseModel : PddResponseModel {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty ("goods_sold_count_audit_get_response")]
        public GoodsSoldCountAuditGetResponseResponseModel GoodsSoldCountAuditGetResponse { get; set; }
        public partial class GoodsSoldCountAuditGetResponseResponseModel : PddResponseModel {
            /// <summary>
            /// 审核状态
            /// </summary>
            [JsonProperty ("audit_status")]
            public int AuditStatus { get; set; }

        }

    }

}