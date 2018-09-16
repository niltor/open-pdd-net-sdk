using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class SendLogisticsOnlineResponseModel : PddResponseModel
    {
        /// <summary>
/// 发货通知响应对象
/// </summary>
[JsonProperty("logistics_online_send_response")]
public object LogisticsOnlineSendResponse {get;set;}
/// <summary>
/// 是否成功，0-失败，1-成功
/// </summary>
[JsonProperty("is_success")]
public int IsSuccess {get;set;}

    public partial class LogisticsOnlineSendResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 是否成功，0-失败，1-成功
/// </summary>
[JsonProperty("is_success")]
public int IsSuccess {get;set;}

}

}
}
