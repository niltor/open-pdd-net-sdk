using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Goods
{
public partial class CommitDeleteDraftResponseModel : PddResponseModel
{
/// <summary>
/// 操作状态，true
/// </summary>
[JsonProperty("open_api_response")]
public bool? OpenApiResponse {get;set;}

}

}
