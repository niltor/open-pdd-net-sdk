using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Stock
{
public partial class DepotExpressAddResponseModel : PddResponseModel
{
/// <summary>
/// 操作成功
/// </summary>
[JsonProperty("open_api_response")]
public string OpenApiResponse {get;set;}

}

}
