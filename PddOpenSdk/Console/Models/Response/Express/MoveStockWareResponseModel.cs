using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Express
{
public partial class MoveStockWareResponseModel : PddResponseModel
{
/// <summary>
/// 调整单ID
/// </summary>
[JsonProperty("open_api_response")]
public long? OpenApiResponse {get;set;}

}

}
