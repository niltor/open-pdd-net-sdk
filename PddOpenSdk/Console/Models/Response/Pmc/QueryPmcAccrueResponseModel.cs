using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Pmc
{
public partial class QueryPmcAccrueResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("pmc_user_get_response")]
public PmcUserGetResponseResponseModel PmcUserGetResponse {get;set;}
public partial class PmcUserGetResponseResponseModel : PddResponseModel
{
/// <summary>
/// 消息积压数量
/// </summary>
[JsonProperty("number")]
public long? Number {get;set;}

}

}

}
