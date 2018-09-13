using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class SendLogisticsCsMessageResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("logistics_cs_message_send_response")]
public object LogisticsCsMessageSendResponse {get;set;}
/// <summary>
/// 是否成功
/// </summary>
[JsonProperty("is_success")]
public object IsSuccess {get;set;}

    public partial class LogisticsCsMessageSendResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 是否成功
/// </summary>
[JsonProperty("is_success")]
public object IsSuccess {get;set;}

}

}
}
