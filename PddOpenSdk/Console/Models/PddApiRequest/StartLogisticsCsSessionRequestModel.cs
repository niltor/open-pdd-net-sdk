using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class StartLogisticsCsSessionRequestModel : PddRequestModel
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
/// 可选值：1：已分配 2：排队中 3：分配异常
/// </summary>
[JsonProperty("biz_type")]
public object BizType {get;set;}
/// <summary>
/// 客服id，biz_type为1时必填
/// </summary>
[JsonProperty("dealer_id")]
public string DealerId {get;set;}
/// <summary>
/// 队列id，biz_type为1时必填
/// </summary>
[JsonProperty("queue_id")]
public string QueueId {get;set;}
/// <summary>
/// 对列名，biz_type为1时必填
/// </summary>
[JsonProperty("queue_name")]
public string QueueName {get;set;}
/// <summary>
/// 排队位置，biz_type为2时必填
/// </summary>
[JsonProperty("queue_index")]
public object QueueIndex {get;set;}
/// <summary>
/// 分配遇到的异常，示例：33222，biz_type为3时不为空
/// </summary>
[JsonProperty("exception_code")]
public object ExceptionCode {get;set;}
/// <summary>
/// 物流客服系统遇到的异常，biz_type为3时不为空
/// </summary>
[JsonProperty("exception_msg")]
public string ExceptionMsg {get;set;}

}
}
