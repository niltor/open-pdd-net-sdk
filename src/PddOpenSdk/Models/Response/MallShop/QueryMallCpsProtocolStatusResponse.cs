namespace PddOpenSdk.Models.Response.MallShop;
public partial class QueryMallCpsProtocolStatusResponse : PddResponseModel
{

    /// <summary>
    /// mall_cps_protocol_status_query_response
    /// </summary>
    [JsonPropertyName("mall_cps_protocol_status_query_response")]
    public MallCpsProtocolStatusQueryResponseResponse MallCpsProtocolStatusQueryResponse { get; set; }
    public partial class MallCpsProtocolStatusQueryResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 是否签署协议
        /// </summary>
        [JsonPropertyName("status")]
        public bool? Status { get; set; }

    }

}

