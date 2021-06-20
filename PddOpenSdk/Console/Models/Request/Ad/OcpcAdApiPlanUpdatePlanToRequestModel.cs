using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ad
{
public partial class OcpcAdApiPlanUpdatePlanToRequestModel : PddRequestModel
{
/// <summary>
/// 单元OCPC信息列表
/// </summary>
[JsonProperty("adUnitUpdateOcpcMessageList")]
public List<AdUnitUpdateOcpcMessageListRequestModel> AdUnitUpdateOcpcMessageList {get;set;}
/// <summary>
/// 广告计划Id
/// </summary>
[JsonProperty("planId")]
public long PlanId {get;set;}
/// <summary>
/// 场景类型。0表示搜索。
/// </summary>
[JsonProperty("scenesType")]
public int ScenesType {get;set;}
public partial class AdUnitUpdateOcpcMessageListRequestModel : PddRequestModel
{
/// <summary>
/// 广告单元Id
/// </summary>
[JsonProperty("adId")]
public long AdId {get;set;}
/// <summary>
/// OCPC信息
/// </summary>
[JsonProperty("optimizationMessage")]
public OptimizationMessageRequestModel OptimizationMessage {get;set;}
public partial class OptimizationMessageRequestModel : PddRequestModel
{
/// <summary>
/// 智能投放期出价
/// </summary>
[JsonProperty("optimizationBid")]
public long OptimizationBid {get;set;}
/// <summary>
/// 优化目标。单元使用OCPC功能时，该值必须传2。
/// </summary>
[JsonProperty("optimizationGoal")]
public int OptimizationGoal {get;set;}
/// <summary>
/// 优化方式。当使用OCPC时，该值必须传2。
/// </summary>
[JsonProperty("optimizationMethod")]
public int OptimizationMethod {get;set;}

}

}

}

}
