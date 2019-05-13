using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Mall
{
    public partial class QueryMallCpsProtocolStatusResponseModel : PddResponseModel
    {
        /// <summary>
        /// mall_cps_protocol_status_query_response
        /// </summary>
        [JsonProperty("mall_cps_protocol_status_query_response")]
        public MallCpsProtocolStatusQueryResponseResponseModel MallCpsProtocolStatusQueryResponse { get; set; }
        public partial class MallCpsProtocolStatusQueryResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 是否签署协议
            /// </summary>
            [JsonProperty("status")]
            public bool? Status { get; set; }

        }

    }

}
