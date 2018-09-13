using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class SendLogisticsCsMessageRequestModel : PddRequestModel
    {
        /// <summary>
/// pdd会话id
/// </summary>
[JsonProperty("session_id")]
public object SessionId {get;set;}
/// <summary>
/// 物流公司会话id
/// </summary>
[JsonProperty("wp_session_id")]
public object WpSessionId {get;set;}
/// <summary>
/// 样式YYYY-MM-DD HH:MM:SS
/// </summary>
[JsonProperty("action_time")]
public object ActionTime {get;set;}
/// <summary>
/// 0：文本1：图片
/// </summary>
[JsonProperty("message_type")]
public object MessageType {get;set;}
/// <summary>
/// message_type为0时不为空
/// </summary>
[JsonProperty("text")]
public object Text {get;set;}
/// <summary>
/// message_type为1时不为空
/// </summary>
[JsonProperty("attach")]
public object Attach {get;set;}
/// <summary>
/// message_type为1时不为空
/// </summary>
[JsonProperty("preview")]
public object Preview {get;set;}

}
}
