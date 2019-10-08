using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ddk
{
public partial class QueryDdkCouponInfoResponseModel : PddResponseModel
{
/// <summary>
/// ddk_coupon_info_query
/// </summary>
[JsonProperty("ddk_coupon_info_query_response")]
public DdkCouponInfoQueryResponseResponseModel DdkCouponInfoQueryResponse {get;set;}
public partial class DdkCouponInfoQueryResponseResponseModel : PddResponseModel
{
/// <summary>
/// list
/// </summary>
[JsonProperty("list")]
public List<ListResponseModel> List {get;set;}
public partial class ListResponseModel : PddResponseModel
{
/// <summary>
/// 优惠券结束时间
/// </summary>
[JsonProperty("coupon_end_time")]
public long? CouponEndTime {get;set;}
/// <summary>
/// 优惠券id
/// </summary>
[JsonProperty("coupon_id")]
public string CouponId {get;set;}
/// <summary>
/// 优惠券开始时间
/// </summary>
[JsonProperty("coupon_start_time")]
public long? CouponStartTime {get;set;}
/// <summary>
/// 优惠券类型, 45:多多进宝商品优惠券  87:淘客定向商品券  204:招商商品优惠券  225:店铺折扣券
/// </summary>
[JsonProperty("coupon_type")]
public int? CouponType {get;set;}
/// <summary>
/// 优惠券面额 单位：分
/// </summary>
[JsonProperty("discount")]
public long? Discount {get;set;}
/// <summary>
/// 优惠券总量
/// </summary>
[JsonProperty("init_quantity")]
public long? InitQuantity {get;set;}
/// <summary>
/// 优惠券剩余数量
/// </summary>
[JsonProperty("remain_quantity")]
public long? RemainQuantity {get;set;}

}

}

}

}
