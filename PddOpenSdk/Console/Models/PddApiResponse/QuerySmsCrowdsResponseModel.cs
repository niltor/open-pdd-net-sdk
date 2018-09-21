using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class QuerySmsCrowdsResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("sms_crows_query_response")]
public SmsCrowsQueryResponseResponseModel SmsCrowsQueryResponse {get;set;}

    public partial class SmsCrowsQueryResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 数量
/// </summary>
[JsonProperty("total")]
public int Total {get;set;}
/// <summary>
/// 结果
/// </summary>
[JsonProperty("result")]
public ResultResponseModel Result {get;set;}

    public partial class ResultResponseModel : PddResponseModel
    {
        /// <summary>
/// 人群id
/// </summary>
[JsonProperty("id")]
public int Id {get;set;}
/// <summary>
/// 类型
/// </summary>
[JsonProperty("type")]
public int Type {get;set;}
/// <summary>
/// 场景
/// </summary>
[JsonProperty("scene")]
public int Scene {get;set;}
/// <summary>
/// 店铺id
/// </summary>
[JsonProperty("mall_id")]
public int MallId {get;set;}
/// <summary>
/// 名称
/// </summary>
[JsonProperty("name")]
public string Name {get;set;}
/// <summary>
/// 人群数量
/// </summary>
[JsonProperty("people_num")]
public int PeopleNum {get;set;}
/// <summary>
/// 人群
/// </summary>
[JsonProperty("crowd")]
public CrowdResponseModel Crowd {get;set;}

    public partial class CrowdResponseModel : PddResponseModel
    {
        /// <summary>
/// 对象类型
/// </summary>
[JsonProperty("location_type")]
public int LocationType {get;set;}
/// <summary>
/// 对象
/// </summary>
[JsonProperty("location")]
public int Location {get;set;}
/// <summary>
/// 性别
/// </summary>
[JsonProperty("gender")]
public int Gender {get;set;}
/// <summary>
/// 有购买天数
/// </summary>
[JsonProperty("purchase_days")]
public int PurchaseDays {get;set;}
/// <summary>
/// 无购买天数
/// </summary>
[JsonProperty("none_purchase_days")]
public int NonePurchaseDays {get;set;}
/// <summary>
/// 商品被收藏天数
/// </summary>
[JsonProperty("goods_favor_days")]
public int GoodsFavorDays {get;set;}
/// <summary>
/// 店铺被收藏天数
/// </summary>
[JsonProperty("mall_favor_days")]
public int MallFavorDays {get;set;}
/// <summary>
/// 最小订单金额
/// </summary>
[JsonProperty("min_order_count")]
public int MinOrderCount {get;set;}
/// <summary>
/// 最大订单金额
/// </summary>
[JsonProperty("max_order_count")]
public int MaxOrderCount {get;set;}
/// <summary>
/// 首次购买开始时间
/// </summary>
[JsonProperty("first_buy_start_time")]
public int FirstBuyStartTime {get;set;}
/// <summary>
/// 首次购买结束时间
/// </summary>
[JsonProperty("first_buy_end_time")]
public int FirstBuyEndTime {get;set;}
/// <summary>
/// 店铺有浏览天数
/// </summary>
[JsonProperty("mall_visit_days")]
public int MallVisitDays {get;set;}
/// <summary>
/// 店铺无浏览天数
/// </summary>
[JsonProperty("mall_none_visit_days")]
public int MallNoneVisitDays {get;set;}

}

}

}

}
}
