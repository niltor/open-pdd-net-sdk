using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Sms
{
public partial class QuerySmsCrowdsPeopleNumberRequestModel : PddRequestModel
{
/// <summary>
/// 人群id
/// </summary>
[JsonProperty("crowd_id")]
public long? CrowdId {get;set;}
/// <summary>
/// //0-全部 1-江浙沪 2-自定义
/// </summary>
[JsonProperty("location_type")]
public int? LocationType {get;set;}
/// <summary>
/// [1,34] //  //选自定义的时候列表存省代表的id
/// </summary>
[JsonProperty("location")]
public List<long?> Location {get;set;}
/// <summary>
/// //0-全部 1-男 2-女
/// </summary>
[JsonProperty("gender")]
public int? Gender {get;set;}
/// <summary>
/// 店铺有购买天数
/// </summary>
[JsonProperty("purchase_days")]
public long? PurchaseDays {get;set;}
/// <summary>
/// 店铺无购买天数
/// </summary>
[JsonProperty("none_purchase_days")]
public long? NonePurchaseDays {get;set;}
/// <summary>
/// 收藏物品天数
/// </summary>
[JsonProperty("goods_favor_days")]
public long? GoodsFavorDays {get;set;}
/// <summary>
/// 收藏店铺天数
/// </summary>
[JsonProperty("mall_favor_days")]
public long? MallFavorDays {get;set;}
/// <summary>
/// 历史订单成交次数
/// </summary>
[JsonProperty("min_order_count")]
public long? MinOrderCount {get;set;}
/// <summary>
/// 历史订单成交次数
/// </summary>
[JsonProperty("max_order_count")]
public long? MaxOrderCount {get;set;}
/// <summary>
/// 第一次购买时间
/// </summary>
[JsonProperty("first_buy_start_time")]
public string FirstBuyStartTime {get;set;}
/// <summary>
/// 最后一次购买时间
/// </summary>
[JsonProperty("first_buy_end_time")]
public string FirstBuyEndTime {get;set;}
/// <summary>
/// 店铺有访问天数
/// </summary>
[JsonProperty("mall_visit_days")]
public long? MallVisitDays {get;set;}

}

}
