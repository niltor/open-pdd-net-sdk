using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ad
{
public partial class ListAdQueryLocationBidPvRequestModel : PddRequestModel
{
/// <summary>
/// 推广类型  2-展示推广
/// </summary>
[JsonProperty("scene_type")]
public int SceneType {get;set;}

}

}
