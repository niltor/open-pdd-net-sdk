using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Fds
{
public partial class GetFdsRoleResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("pdd_fds_role_get_response")]
public PddFdsRoleGetResponseResponseModel PddFdsRoleGetResponse {get;set;}
public partial class PddFdsRoleGetResponseResponseModel : PddResponseModel
{
/// <summary>
/// 店铺身份 0：未知身份 2：厂家
/// </summary>
[JsonProperty("mall_role")]
public int? MallRole {get;set;}

}

}

}
