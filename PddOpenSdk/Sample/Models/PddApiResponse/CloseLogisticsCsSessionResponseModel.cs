using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class CloseLogisticsCsSessionResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("logistics_cs_session_close_response")]
public object LogisticsCsSessionCloseResponse {get;set;}
/// <summary>
/// 是否成功
/// </summary>
[JsonProperty("is_success")]
public object IsSuccess {get;set;}

    public partial class LogisticsCsSessionCloseResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 是否成功
/// </summary>
[JsonProperty("is_success")]
public object IsSuccess {get;set;}

}

}
}
