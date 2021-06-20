using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Mall
{
public partial class InfoTraceSourceUploadCodeResponseModel : PddResponseModel
{
/// <summary>
/// 1成功，0失败
/// </summary>
[JsonProperty("status")]
public int? Status {get;set;}

}

}
