using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ad
{
public partial class ListAdApiUnitBidQueryResponseModel : PddResponseModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("response")]
public ResponseResponseModel Response {get;set;}
public partial class ResponseResponseModel : PddResponseModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("errorCode")]
public int? ErrorCode {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("errorMsg")]
public string ErrorMsg {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("result")]
public List<ResultResponseModel> Result {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("success")]
public bool? Success {get;set;}
public partial class ResultResponseModel : PddResponseModel
{
/// <summary>
/// 广告单元Id
/// </summary>
[JsonProperty("adId")]
public long? AdId {get;set;}
/// <summary>
/// 定向信息
/// </summary>
[JsonProperty("adTargetingVO")]
public AdTargetingVOResponseModel AdTargetingVO {get;set;}
/// <summary>
/// 每笔成交金额(average pay amount)，单位厘
/// </summary>
[JsonProperty("avgPayAmount")]
public double? AvgPayAmount {get;set;}
/// <summary>
/// 出价Id
/// </summary>
[JsonProperty("bidId")]
public long? BidId {get;set;}
/// <summary>
/// 定向类型 或 资源位类型
/// </summary>
[JsonProperty("bidReferenceId")]
public long? BidReferenceId {get;set;}
/// <summary>
/// 出价，万分比
/// </summary>
[JsonProperty("bidValue")]
public long? BidValue {get;set;}
/// <summary>
/// 广告点击量
/// </summary>
[JsonProperty("click")]
public long? Click {get;set;}
/// <summary>
/// 平均点击花费，单位厘
/// </summary>
[JsonProperty("cpc")]
public double? Cpc {get;set;}
/// <summary>
/// 千次展现成本
/// </summary>
[JsonProperty("cpm")]
public double? Cpm {get;set;}
/// <summary>
/// 广告点击率
/// </summary>
[JsonProperty("ctr")]
public double? Ctr {get;set;}
/// <summary>
/// 点击转化率
/// </summary>
[JsonProperty("cvr")]
public double? Cvr {get;set;}
/// <summary>
/// 广告转化支付金额，单位厘
/// </summary>
[JsonProperty("gmv")]
public long? Gmv {get;set;}
/// <summary>
/// 商品收藏数
/// </summary>
[JsonProperty("goodsFavNum")]
public long? GoodsFavNum {get;set;}
/// <summary>
/// 广告曝光量
/// </summary>
[JsonProperty("impression")]
public long? Impression {get;set;}
/// <summary>
/// 店铺收藏数
/// </summary>
[JsonProperty("mallFavNum")]
public long? MallFavNum {get;set;}
/// <summary>
/// 广告主Id
/// </summary>
[JsonProperty("mallId")]
public long? MallId {get;set;}
/// <summary>
/// 广告转化支付订单量
/// </summary>
[JsonProperty("orderNum")]
public long? OrderNum {get;set;}
/// <summary>
/// 广告投入产出比
/// </summary>
[JsonProperty("roi")]
public double? Roi {get;set;}
/// <summary>
/// 广告消耗，单位厘
/// </summary>
[JsonProperty("spend")]
public long? Spend {get;set;}
/// <summary>
/// 人群定向二级Id。当出价资源为展示场景兴趣点时表示兴趣点Id，当出价资源为展示场景人群包时表示人群包Id，当出价资源为展示场景地域时表示地域Id。
/// </summary>
[JsonProperty("subBidReferenceId")]
public string SubBidReferenceId {get;set;}
/// <summary>
/// 人群定向二级名称。当出价资源为展示场景兴趣点时表示兴趣点名称，当出价资源为展示场景人群包时表示人群包名称，当出价资源为展示场景地域时表示地域名称。
/// </summary>
[JsonProperty("subBidReferenceName")]
public string SubBidReferenceName {get;set;}
/// <summary>
/// 转化成本
/// </summary>
[JsonProperty("transactionCost")]
public double? TransactionCost {get;set;}
public partial class AdTargetingVOResponseModel : PddResponseModel
{
/// <summary>
/// 定向集合
/// </summary>
[JsonProperty("adTargetingSet")]
public AdTargetingSetResponseModel AdTargetingSet {get;set;}
/// <summary>
/// 定向Id
/// </summary>
[JsonProperty("targetingId")]
public long? TargetingId {get;set;}
/// <summary>
/// 定向名称
/// </summary>
[JsonProperty("targetingName")]
public string TargetingName {get;set;}
public partial class AdTargetingSetResponseModel : PddResponseModel
{
/// <summary>
/// 地域定向
/// </summary>
[JsonProperty("areaStruct")]
public AreaStructResponseModel AreaStruct {get;set;}
public partial class AreaStructResponseModel : PddResponseModel
{
/// <summary>
/// 地域Id列表。具体地域Id编码参见接口返回：pdd.ad.api.unit.bid.query.targeting.tag.list
/// </summary>
[JsonProperty("areaIds")]
public int? AreaIds {get;set;}

}

}

}

}

}

}

}
