using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class QuerySmsSendRecordListResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("sms_send_record_list_query_response")]
public object SmsSendRecordListQueryResponse {get;set;}
/// <summary>
/// 总量
/// </summary>
[JsonProperty("total")]
public int Total {get;set;}
/// <summary>
/// 结果
/// </summary>
[JsonProperty("result")]
public object Result {get;set;}
/// <summary>
/// 收件人
/// </summary>
[JsonProperty("receiver")]
public object Receiver {get;set;}
/// <summary>
/// 手机号
/// </summary>
[JsonProperty("phone")]
public object Phone {get;set;}
/// <summary>
/// 发送时间
/// </summary>
[JsonProperty("send_time")]
public object SendTime {get;set;}
/// <summary>
/// 短信内容
/// </summary>
[JsonProperty("content")]
public object Content {get;set;}
/// <summary>
/// 条数
/// </summary>
[JsonProperty("items_num")]
public int ItemsNum {get;set;}
/// <summary>
/// 字数
/// </summary>
[JsonProperty("words_num")]
public int WordsNum {get;set;}
/// <summary>
/// 发送状态
/// </summary>
[JsonProperty("status")]
public int Status {get;set;}

    public partial class SmsSendRecordListQueryResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 总量
/// </summary>
[JsonProperty("total")]
public int Total {get;set;}
/// <summary>
/// 结果
/// </summary>
[JsonProperty("result")]
public object Result {get;set;}

}

    public partial class ResultResponseModel : PddResponseModel
    {
        /// <summary>
/// 收件人
/// </summary>
[JsonProperty("receiver")]
public object Receiver {get;set;}
/// <summary>
/// 手机号
/// </summary>
[JsonProperty("phone")]
public object Phone {get;set;}
/// <summary>
/// 发送时间
/// </summary>
[JsonProperty("send_time")]
public object SendTime {get;set;}
/// <summary>
/// 短信内容
/// </summary>
[JsonProperty("content")]
public object Content {get;set;}
/// <summary>
/// 条数
/// </summary>
[JsonProperty("items_num")]
public int ItemsNum {get;set;}
/// <summary>
/// 字数
/// </summary>
[JsonProperty("words_num")]
public int WordsNum {get;set;}
/// <summary>
/// 发送状态
/// </summary>
[JsonProperty("status")]
public int Status {get;set;}

}

}
}
