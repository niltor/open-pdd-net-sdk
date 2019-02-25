using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ad
{
public partial class ReportAdKeywordDailyRequestModel : PddRequestModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("unit_id")]
public long UnitId {get;set;}
/// <summary>
/// 0:搜索广告
/// </summary>
[JsonProperty("scene_type")]
public int SceneType {get;set;}
/// <summary>
/// 格式："yyyy-MM-dd" 时区："GMT+8"
/// </summary>
[JsonProperty("begin_date")]
public string BeginDate {get;set;}
/// <summary>
/// 格式："yyyy-MM-dd" 时区："GMT+8"
/// </summary>
[JsonProperty("end_date")]
public string EndDate {get;set;}

}

}
