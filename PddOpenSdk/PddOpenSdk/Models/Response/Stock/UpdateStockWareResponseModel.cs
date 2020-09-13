using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Stock
{
public partial class UpdateStockWareResponseModel : PddResponseModel
{
/// <summary>
/// 货品id
/// </summary>
[JsonProperty("open_api_response")]
public long? OpenApiResponse {get;set;}

}

}
