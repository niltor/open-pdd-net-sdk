using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Order
{
public partial class LogisticsOrderUploadExtraResponseModel : PddResponseModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("upload_extra_logistics_response")]
public UploadExtraLogisticsResponseResponseModel UploadExtraLogisticsResponse {get;set;}
public partial class UploadExtraLogisticsResponseResponseModel : PddResponseModel
{
/// <summary>
/// 是否成功，false-失败，true-成功
/// </summary>
[JsonProperty("success")]
public bool? Success {get;set;}

}

}

}
