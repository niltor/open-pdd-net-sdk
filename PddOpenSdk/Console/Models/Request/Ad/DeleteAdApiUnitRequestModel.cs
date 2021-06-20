using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ad
{
public partial class DeleteAdApiUnitRequestModel : PddRequestModel
{
/// <summary>
/// 广告单元Id
/// </summary>
[JsonProperty("adId")]
public long AdId {get;set;}
/// <summary>
/// 场景类型。0表示搜索，2表示展示。
/// </summary>
[JsonProperty("scenesType")]
public int ScenesType {get;set;}

}

}
