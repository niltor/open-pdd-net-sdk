using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class QuerySmsShortStatisticResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("sms_short_msg_statistic_query_response")]
public object SmsShortMsgStatisticQueryResponse {get;set;}
/// <summary>
/// return
/// </summary>
[JsonProperty("setting_and_crowd_return_vo")]
public object SettingAndCrowdReturnVo {get;set;}
/// <summary>
/// 统计总数量
/// </summary>
[JsonProperty("statistic_vo")]
public int StatisticVo {get;set;}
/// <summary>
/// 人群id
/// </summary>
[JsonProperty("id")]
public object Id {get;set;}
/// <summary>
/// 人群名称
/// </summary>
[JsonProperty("name")]
public object Name {get;set;}
/// <summary>
/// 人群数量
/// </summary>
[JsonProperty("people_num")]
public int PeopleNum {get;set;}
/// <summary>
/// 发送时间
/// </summary>
[JsonProperty("send_time")]
public object SendTime {get;set;}

    public partial class SmsShortMsgStatisticQueryResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// return
/// </summary>
[JsonProperty("setting_and_crowd_return_vo")]
public object SettingAndCrowdReturnVo {get;set;}
/// <summary>
/// 统计总数量
/// </summary>
[JsonProperty("statistic_vo")]
public int StatisticVo {get;set;}

}

    public partial class SettingAndCrowdReturnVoResponseModel : PddResponseModel
    {
        /// <summary>
/// 人群id
/// </summary>
[JsonProperty("id")]
public object Id {get;set;}
/// <summary>
/// 人群名称
/// </summary>
[JsonProperty("name")]
public object Name {get;set;}
/// <summary>
/// 人群数量
/// </summary>
[JsonProperty("people_num")]
public int PeopleNum {get;set;}
/// <summary>
/// 发送时间
/// </summary>
[JsonProperty("send_time")]
public object SendTime {get;set;}

}

}
}
