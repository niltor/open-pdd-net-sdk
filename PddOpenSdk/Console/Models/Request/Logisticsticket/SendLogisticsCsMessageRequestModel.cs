using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Logisticsticket
{
public partial class SendLogisticsCsMessageRequestModel : PddRequestModel
{
/// <summary>
/// pdd会话id
/// </summary>
[JsonProperty("session_id")]
public string SessionId {get;set;}
/// <summary>
/// 物流公司会话id
/// </summary>
[JsonProperty("wp_session_id")]
public string WpSessionId {get;set;}
/// <summary>
/// 样式YYYY-MM-DD HH:MM:SS
/// </summary>
[JsonProperty("action_time")]
public string ActionTime {get;set;}
/// <summary>
/// 0：文本1：图片
/// </summary>
[JsonProperty("message_type")]
public int MessageType {get;set;}
/// <summary>
/// message_type为0时不为空
/// </summary>
[JsonProperty("text")]
public string Text {get;set;}
/// <summary>
/// message_type为1时不为空
/// </summary>
[JsonProperty("attach")]
public string Attach {get;set;}
/// <summary>
/// message_type为1时不为空
/// </summary>
[JsonProperty("preview")]
public string Preview {get;set;}

}

}
