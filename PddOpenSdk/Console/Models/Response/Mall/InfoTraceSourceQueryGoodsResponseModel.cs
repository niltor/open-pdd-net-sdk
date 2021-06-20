using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Mall
{
public partial class InfoTraceSourceQueryGoodsResponseModel : PddResponseModel
{
/// <summary>
/// 返回参数
/// </summary>
[JsonProperty("response")]
public string Response {get;set;}

}

}
