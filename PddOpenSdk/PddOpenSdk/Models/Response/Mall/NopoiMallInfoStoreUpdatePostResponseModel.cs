using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Mall
{
public partial class NopoiMallInfoStoreUpdatePostResponseModel : PddResponseModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("res")]
public ResResponseModel Res {get;set;}

}

}
