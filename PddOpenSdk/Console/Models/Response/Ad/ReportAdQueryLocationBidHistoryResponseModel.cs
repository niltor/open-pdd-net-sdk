using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ad
{
public partial class ReportAdQueryLocationBidHistoryResponseModel : PddResponseModel
{
/// <summary>
/// 开平返回
/// </summary>
[JsonProperty("open_api_response")]
public OpenApiResponseResponseModel OpenApiResponse {get;set;}
public partial class OpenApiResponseResponseModel : PddResponseModel
{
/// <summary>
/// 列表信息
/// </summary>
[JsonProperty("result")]
public List<ResultResponseModel> Result {get;set;}
/// <summary>
/// 总数
/// </summary>
[JsonProperty("total")]
public long? Total {get;set;}
public partial class ResultResponseModel : PddResponseModel
{
/// <summary>
/// 店铺收藏数
/// </summary>
[JsonProperty("mall_fav_num")]
public long? MallFavNum {get;set;}
/// <summary>
/// 千次展现成本
/// </summary>
[JsonProperty("cpm")]
public double? Cpm {get;set;}
/// <summary>
/// 广告投资回报率
/// </summary>
[JsonProperty("roi")]
public double? Roi {get;set;}
/// <summary>
/// 广告转化支付金额，单位厘
/// </summary>
[JsonProperty("gmv")]
public long? Gmv {get;set;}
/// <summary>
/// 广告转化支付订单数
/// </summary>
[JsonProperty("order_num")]
public long? OrderNum {get;set;}
/// <summary>
/// 点击单价，单位厘
/// </summary>
[JsonProperty("cpc")]
public double? Cpc {get;set;}
/// <summary>
/// 广告消耗,单位厘
/// </summary>
[JsonProperty("spend")]
public long? Spend {get;set;}
/// <summary>
/// 广告点击率
/// </summary>
[JsonProperty("ctr")]
public double? Ctr {get;set;}
/// <summary>
/// 广告点击数
/// </summary>
[JsonProperty("click")]
public int? Click {get;set;}
/// <summary>
/// 广告曝光数
/// </summary>
[JsonProperty("impression")]
public int? Impression {get;set;}
/// <summary>
/// 分天数据日期
/// </summary>
[JsonProperty("date")]
public string Date {get;set;}
/// <summary>
/// 定向状态，0表示未删除，1表示已删除
/// </summary>
[JsonProperty("status")]
public int? Status {get;set;}
/// <summary>
/// 资源位id
/// </summary>
[JsonProperty("location_id")]
public long? LocationId {get;set;}
/// <summary>
/// 资源位类型
/// </summary>
[JsonProperty("location_type")]
public int? LocationType {get;set;}
/// <summary>
/// 单元ID
/// </summary>
[JsonProperty("unit_id")]
public long? UnitId {get;set;}
/// <summary>
/// 计划id
/// </summary>
[JsonProperty("plan_id")]
public long? PlanId {get;set;}
/// <summary>
/// 广告主ID
/// </summary>
[JsonProperty("mall_id")]
public long? MallId {get;set;}

}

}

}

}
