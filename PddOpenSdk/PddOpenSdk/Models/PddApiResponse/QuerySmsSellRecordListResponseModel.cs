using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class QuerySmsSellRecordListResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("sms_sell_record_list_query_response")]
public object SmsSellRecordListQueryResponse {get;set;}
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
/// 删除用的id
/// </summary>
[JsonProperty("id")]
public object Id {get;set;}
/// <summary>
/// 任务名称
/// </summary>
[JsonProperty("name")]
public object Name {get;set;}
/// <summary>
/// 短信类型
/// </summary>
[JsonProperty("scene")]
public int Scene {get;set;}
/// <summary>
/// 计划时间
/// </summary>
[JsonProperty("send_time")]
public object SendTime {get;set;}
/// <summary>
/// status
/// </summary>
[JsonProperty("status")]
public int Status {get;set;}
/// <summary>
/// 发送总数
/// </summary>
[JsonProperty("send_num")]
public int SendNum {get;set;}
/// <summary>
/// 发送失败总数
/// </summary>
[JsonProperty("send_failed_num")]
public int SendFailedNum {get;set;}
/// <summary>
/// 是否开启
/// </summary>
[JsonProperty("open")]
public int Open {get;set;}

    public partial class SmsSellRecordListQueryResponseResponseModel : PddResponseModel
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
/// 删除用的id
/// </summary>
[JsonProperty("id")]
public object Id {get;set;}
/// <summary>
/// 任务名称
/// </summary>
[JsonProperty("name")]
public object Name {get;set;}
/// <summary>
/// 短信类型
/// </summary>
[JsonProperty("scene")]
public int Scene {get;set;}
/// <summary>
/// 计划时间
/// </summary>
[JsonProperty("send_time")]
public object SendTime {get;set;}
/// <summary>
/// status
/// </summary>
[JsonProperty("status")]
public int Status {get;set;}
/// <summary>
/// 发送总数
/// </summary>
[JsonProperty("send_num")]
public int SendNum {get;set;}
/// <summary>
/// 发送失败总数
/// </summary>
[JsonProperty("send_failed_num")]
public int SendFailedNum {get;set;}
/// <summary>
/// 是否开启
/// </summary>
[JsonProperty("open")]
public int Open {get;set;}

}

}
}
