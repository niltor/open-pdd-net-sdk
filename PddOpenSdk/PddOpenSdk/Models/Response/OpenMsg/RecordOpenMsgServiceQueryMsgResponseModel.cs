using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.OpenMsg
{
public partial class RecordOpenMsgServiceQueryMsgResponseModel : PddResponseModel
{
/// <summary>
/// 请求ID
/// </summary>
[JsonProperty("request_id")]
public string RequestId {get;set;}
/// <summary>
/// 请求状态码
/// </summary>
[JsonProperty("result_code")]
public string ResultCode {get;set;}
/// <summary>
/// 状态码描述
/// </summary>
[JsonProperty("result_message")]
public string ResultMessage {get;set;}
/// <summary>
/// 短信发送明细列表
/// </summary>
[JsonProperty("sms_send_details")]
public List<SmsSendDetailsResponseModel> SmsSendDetails {get;set;}
/// <summary>
/// 短信发送总条数
/// </summary>
[JsonProperty("total_count")]
public int? TotalCount {get;set;}
public partial class SmsSendDetailsResponseModel : PddResponseModel
{
/// <summary>
/// 模板内容
/// </summary>
[JsonProperty("content")]
public string Content {get;set;}
/// <summary>
/// 错误码
/// </summary>
[JsonProperty("error_code")]
public long? ErrorCode {get;set;}
/// <summary>
/// 外部id
/// </summary>
[JsonProperty("out_id")]
public string OutId {get;set;}
/// <summary>
/// 手机号码
/// </summary>
[JsonProperty("phone_number")]
public string PhoneNumber {get;set;}
/// <summary>
/// 接收时间
/// </summary>
[JsonProperty("receive_time")]
public string ReceiveTime {get;set;}
/// <summary>
/// 发送状态
/// </summary>
[JsonProperty("send_status")]
public int? SendStatus {get;set;}
/// <summary>
/// 发送时间
/// </summary>
[JsonProperty("send_time")]
public string SendTime {get;set;}
/// <summary>
/// 模板ID
/// </summary>
[JsonProperty("template_code")]
public long? TemplateCode {get;set;}

}

}

}
