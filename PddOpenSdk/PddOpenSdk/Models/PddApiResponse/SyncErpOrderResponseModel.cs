using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class SyncErpOrderResponseModel : PddResponseModel
    {
        /// <summary>
/// 是否成功
/// </summary>
[JsonProperty("success")]
public bool Success {get;set;}
/// <summary>
/// 错误代码
/// </summary>
[JsonProperty("error_code")]
public object ErrorCode {get;set;}
/// <summary>
/// 错误参数
/// </summary>
[JsonProperty("error_msg")]
public object ErrorMsg {get;set;}
/// <summary>
/// 是否有结果
/// </summary>
[JsonProperty("result")]
public bool Result {get;set;}

}
}
