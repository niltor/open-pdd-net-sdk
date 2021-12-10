namespace PddOpenSdk.Models.Response.Ddk;
public partial class QueryDdkMemberAuthorityResponse : PddResponseModel
{

    /// <summary>
    /// 查询结果
    /// </summary>
    [JsonPropertyName("authority_query_response")]
    public AuthorityQueryResponseResponse AuthorityQueryResponse { get; set; }
    public partial class AuthorityQueryResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 1-已绑定；0-未绑定
        /// </summary>
        [JsonPropertyName("bind")]
        public int? Bind { get; set; }

    }

}

