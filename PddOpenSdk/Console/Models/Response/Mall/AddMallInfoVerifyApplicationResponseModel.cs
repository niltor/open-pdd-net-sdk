using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Mall
{
public partial class AddMallInfoVerifyApplicationResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("mall_info_verify_application_add_response")]
public MallInfoVerifyApplicationAddResponseResponseModel MallInfoVerifyApplicationAddResponse {get;set;}
public partial class MallInfoVerifyApplicationAddResponseResponseModel : PddResponseModel
{
/// <summary>
/// 是否成功
/// </summary>
[JsonProperty("is_success")]
public bool? IsSuccess {get;set;}

}

}

}
