using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ddk
{
public partial class QueryDdkFinanceCpaRequestModel : PddRequestModel
{
/// <summary>
/// 结束时间
/// </summary>
[JsonProperty("date_end")]
public string DateEnd {get;set;}
/// <summary>
/// 开始时间
/// </summary>
[JsonProperty("date_start")]
public string DateStart {get;set;}
/// <summary>
/// 推广位id
/// </summary>
[JsonProperty("pid")]
public string Pid {get;set;}
/// <summary>
/// 场景值(全部-不传值 单品-0 红包-1 转盘免单-55 转盘优惠券-56 新人红包-72)
/// </summary>
[JsonProperty("source_type")]
public int? SourceType {get;set;}

}

}
