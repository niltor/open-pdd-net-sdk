using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ticket
{
public partial class GetTicketScenicRequestModel : PddRequestModel
{
/// <summary>
/// 城市编码
/// </summary>
[JsonProperty("city_code")]
public long? CityCode {get;set;}
/// <summary>
/// 定位类型 1.百度 2.google
/// </summary>
[JsonProperty("location_type")]
public int LocationType {get;set;}
/// <summary>
/// 拼多多景区 ID
/// </summary>
[JsonProperty("scenic_id")]
public long? ScenicId {get;set;}
/// <summary>
/// 景区简称（至少两个字）
/// </summary>
[JsonProperty("scenic_name")]
public string ScenicName {get;set;}

}

}
