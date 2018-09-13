using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class CloseLogisticsCsSessionRequestModel : PddRequestModel
    {
        /// <summary>
/// pdd会话id
/// </summary>
[JsonProperty("session_id")]
public string(64) SessionId {get;set;}
/// <summary>
/// 物流公司会话id
/// </summary>
[JsonProperty("wp_session_id")]
public string(64) WpSessionId {get;set;}
/// <summary>
/// 样式YYYY-MM-DD HH:MM:SS
/// </summary>
[JsonProperty("action_time")]
public string ActionTime {get;set;}
}
}

