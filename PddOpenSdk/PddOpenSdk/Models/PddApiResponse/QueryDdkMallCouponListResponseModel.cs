using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class QueryDdkMallCouponListResponseModel : PddResponseModel
    {
        /// <summary>
/// 店铺信息列表
/// </summary>
[JsonProperty("mall_info_list")]
public object MallInfoList {get;set;}
/// <summary>
/// 返回总数
/// </summary>
[JsonProperty("total")]
public object Total {get;set;}
/// <summary>
/// 店铺id
/// </summary>
[JsonProperty("mall_id")]
public object MallId {get;set;}
/// <summary>
/// 店铺名字
/// </summary>
[JsonProperty("mall_name")]
public object MallName {get;set;}
/// <summary>
/// 店铺类型，1-个人，2-企业，3-旗舰店，4-专卖店，5-专营店，6-普通店
/// </summary>
[JsonProperty("merchant_type")]
public object MerchantType {get;set;}
/// <summary>
/// 店铺类目
/// </summary>
[JsonProperty("cat_id_list")]
public object CatIdList {get;set;}
/// <summary>
/// 店铺参与全店推广的佣金比（千分比）
/// </summary>
[JsonProperty("mall_rate")]
public object MallRate {get;set;}
/// <summary>
/// 店铺优惠券id
/// </summary>
[JsonProperty("coupon_id")]
public object CouponId {get;set;}
/// <summary>
/// 店铺优惠券类型：224, "多多进宝店铺满减券";225, "多多进宝店铺折扣券"
/// </summary>
[JsonProperty("coupon_type")]
public object CouponType {get;set;}
/// <summary>
/// 优惠券面额（单位为分）
/// </summary>
[JsonProperty("discount")]
public object Discount {get;set;}
/// <summary>
/// 优惠券门槛面额（单位为分）
/// </summary>
[JsonProperty("min_order_amount")]
public object MinOrderAmount {get;set;}
/// <summary>
/// 使用优惠券后最大优惠金额（单位为分）
/// </summary>
[JsonProperty("max_discount_amount")]
public object MaxDiscountAmount {get;set;}
/// <summary>
/// 优惠券总数量
/// </summary>
[JsonProperty("coupon_quantity")]
public object CouponQuantity {get;set;}
/// <summary>
/// 优惠券剩余数量
/// </summary>
[JsonProperty("coupon_remain_quantity")]
public object CouponRemainQuantity {get;set;}
/// <summary>
/// 优惠券开始时间（unix时间戳）
/// </summary>
[JsonProperty("coupon_start_time")]
public object CouponStartTime {get;set;}
/// <summary>
/// 优惠券结束时间（unix时间戳）
/// </summary>
[JsonProperty("coupon_end_time")]
public object CouponEndTime {get;set;}

    public partial class MallInfoListResponseModel : PddResponseModel
    {
        /// <summary>
/// 店铺id
/// </summary>
[JsonProperty("mall_id")]
public object MallId {get;set;}
/// <summary>
/// 店铺名字
/// </summary>
[JsonProperty("mall_name")]
public object MallName {get;set;}
/// <summary>
/// 店铺类型，1-个人，2-企业，3-旗舰店，4-专卖店，5-专营店，6-普通店
/// </summary>
[JsonProperty("merchant_type")]
public object MerchantType {get;set;}
/// <summary>
/// 店铺类目
/// </summary>
[JsonProperty("cat_id_list")]
public object CatIdList {get;set;}
/// <summary>
/// 店铺参与全店推广的佣金比（千分比）
/// </summary>
[JsonProperty("mall_rate")]
public object MallRate {get;set;}
/// <summary>
/// 店铺优惠券id
/// </summary>
[JsonProperty("coupon_id")]
public object CouponId {get;set;}
/// <summary>
/// 店铺优惠券类型：224, "多多进宝店铺满减券";225, "多多进宝店铺折扣券"
/// </summary>
[JsonProperty("coupon_type")]
public object CouponType {get;set;}
/// <summary>
/// 优惠券面额（单位为分）
/// </summary>
[JsonProperty("discount")]
public object Discount {get;set;}
/// <summary>
/// 优惠券门槛面额（单位为分）
/// </summary>
[JsonProperty("min_order_amount")]
public object MinOrderAmount {get;set;}
/// <summary>
/// 使用优惠券后最大优惠金额（单位为分）
/// </summary>
[JsonProperty("max_discount_amount")]
public object MaxDiscountAmount {get;set;}
/// <summary>
/// 优惠券总数量
/// </summary>
[JsonProperty("coupon_quantity")]
public object CouponQuantity {get;set;}
/// <summary>
/// 优惠券剩余数量
/// </summary>
[JsonProperty("coupon_remain_quantity")]
public object CouponRemainQuantity {get;set;}
/// <summary>
/// 优惠券开始时间（unix时间戳）
/// </summary>
[JsonProperty("coupon_start_time")]
public object CouponStartTime {get;set;}
/// <summary>
/// 优惠券结束时间（unix时间戳）
/// </summary>
[JsonProperty("coupon_end_time")]
public object CouponEndTime {get;set;}

}

}
}
