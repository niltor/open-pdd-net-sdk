using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.DdkTools
{
public partial class QueryDdkOauthGoodsPidRequestModel : PddRequestModel
{
/// <summary>
/// 返回的页数
/// </summary>
[JsonProperty("page")]
public int? Page {get;set;}
/// <summary>
/// 返回的每页推广位数量
/// </summary>
[JsonProperty("page_size")]
public int? PageSize {get;set;}
/// <summary>
/// 推广位列表，例如：["60005_612"]
/// </summary>
[JsonProperty("pid_list")]
public List<string> PidList {get;set;}

}

}
