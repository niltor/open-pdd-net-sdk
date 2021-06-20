using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ddk
{
public partial class QueryDdkMemberAuthorityResponseModel : PddResponseModel
{
/// <summary>
/// 查询结果
/// </summary>
[JsonProperty("authority_query_response")]
public AuthorityQueryResponseResponseModel AuthorityQueryResponse {get;set;}
public partial class AuthorityQueryResponseResponseModel : PddResponseModel
{
/// <summary>
/// 1-已绑定；0-未绑定
/// </summary>
[JsonProperty("bind")]
public int? Bind {get;set;}

}

}

}
