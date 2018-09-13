using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GetTimeResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("time_get_response")]
public object TimeGetResponse {get;set;}
/// <summary>
/// 拼多多系统时间
/// </summary>
[JsonProperty("time")]
public object Time {get;set;}

    public partial class TimeGetResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 拼多多系统时间
/// </summary>
[JsonProperty("time")]
public object Time {get;set;}

}

}
}
