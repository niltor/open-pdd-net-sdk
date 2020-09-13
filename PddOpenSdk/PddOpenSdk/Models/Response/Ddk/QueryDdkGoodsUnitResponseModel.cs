using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ddk
{
public partial class QueryDdkGoodsUnitResponseModel : PddResponseModel
{
/// <summary>
/// ddk_goods_unit_query_response
/// </summary>
[JsonProperty("ddk_goods_unit_query_response")]
public DdkGoodsUnitQueryResponseResponseModel DdkGoodsUnitQueryResponse {get;set;}
public partial class DdkGoodsUnitQueryResponseResponseModel : PddResponseModel
{
/// <summary>
/// 优惠券结束时间，单位：秒
/// </summary>
[JsonProperty("coupon_end_time")]
public long? CouponEndTime {get;set;}
/// <summary>
/// 优惠券id
/// </summary>
[JsonProperty("coupon_id")]
public string CouponId {get;set;}
/// <summary>
/// 优惠券开始时间，单位：秒
/// </summary>
[JsonProperty("coupon_start_time")]
public long? CouponStartTime {get;set;}
/// <summary>
/// 优惠券面额，单位：厘
/// </summary>
[JsonProperty("discount")]
public int? Discount {get;set;}
/// <summary>
/// 优惠券总数量
/// </summary>
[JsonProperty("init_quantity")]
public long? InitQuantity {get;set;}
/// <summary>
/// 商品的佣金比例，单位：千分位，比如100，表示10%
/// </summary>
[JsonProperty("rate")]
public int? Rate {get;set;}
/// <summary>
/// 优惠券剩余数量
/// </summary>
[JsonProperty("remain_quantity")]
public long? RemainQuantity {get;set;}
/// <summary>
/// 商品的推广计划类型，1-通用推广，2-专属推广，3-招商推广，4-全店推广
/// </summary>
[JsonProperty("unit_type")]
public int? UnitType {get;set;}

}

}

}
