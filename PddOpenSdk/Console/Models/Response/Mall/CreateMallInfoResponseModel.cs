using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Mall
{
public partial class CreateMallInfoResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("mall_info_create_response")]
public MallInfoCreateResponseResponseModel MallInfoCreateResponse {get;set;}
public partial class MallInfoCreateResponseResponseModel : PddResponseModel
{
/// <summary>
/// 是否成功
/// </summary>
[JsonProperty("success")]
public bool? Success {get;set;}
/// <summary>
/// 授权access_token
/// </summary>
[JsonProperty("access_token")]
public string AccessToken {get;set;}
/// <summary>
/// 店铺id
/// </summary>
[JsonProperty("mall_id")]
public long? MallId {get;set;}

}

}

}
