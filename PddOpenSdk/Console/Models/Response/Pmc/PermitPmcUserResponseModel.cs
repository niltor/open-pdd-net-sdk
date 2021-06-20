using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Pmc
{
public partial class PermitPmcUserResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("pmc_user_permit_response")]
public PmcUserPermitResponseResponseModel PmcUserPermitResponse {get;set;}
public partial class PmcUserPermitResponseResponseModel : PddResponseModel
{
/// <summary>
/// 是否成功
/// </summary>
[JsonProperty("is_success")]
public bool? IsSuccess {get;set;}

}

}

}
