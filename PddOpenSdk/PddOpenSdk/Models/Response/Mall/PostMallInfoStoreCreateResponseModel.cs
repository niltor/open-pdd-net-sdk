using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Mall
{
public partial class PostMallInfoStoreCreateResponseModel : PddResponseModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("mall_info_store_create_post_response")]
public MallInfoStoreCreatePostResponseResponseModel MallInfoStoreCreatePostResponse {get;set;}
public partial class MallInfoStoreCreatePostResponseResponseModel : PddResponseModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("is_success")]
public bool? IsSuccess {get;set;}

}

}

}
