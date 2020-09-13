using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ddk
{
public partial class QueryDdkFinanceCpaRequestModel : PddRequestModel
{
/// <summary>
/// 查询日期，格式：yyyy-MM-dd
/// </summary>
[JsonProperty("date_query")]
public string DateQuery {get;set;}
/// <summary>
/// 推广位id
/// </summary>
[JsonProperty("pid")]
public string Pid {get;set;}

}

}
