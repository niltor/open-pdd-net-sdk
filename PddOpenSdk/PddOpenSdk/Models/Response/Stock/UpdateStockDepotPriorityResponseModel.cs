using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Stock
{
public partial class UpdateStockDepotPriorityResponseModel : PddResponseModel
{
/// <summary>
/// 请求结果
/// </summary>
[JsonProperty("open_api_response")]
public string OpenApiResponse {get;set;}

}

}
