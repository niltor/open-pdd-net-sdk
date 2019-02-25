using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ddk
{
public partial class DetailDdkGoodsResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("goods_detail_response")]
public GoodsDetailResponseResponseModel GoodsDetailResponse {get;set;}
public partial class GoodsDetailResponseResponseModel : PddResponseModel
{
/// <summary>
/// 多多进宝商品对象列表
/// </summary>
[JsonProperty("goods_details")]
public List<GoodsDetailsResponseModel> GoodsDetails {get;set;}
public partial class GoodsDetailsResponseModel : PddResponseModel
{
/// <summary>
/// 店铺优惠券id
/// </summary>
[JsonProperty("mall_coupon_id")]
public long? MallCouponId {get;set;}
/// <summary>
/// 店铺折扣
/// </summary>
[JsonProperty("mall_coupon_discount_pct")]
public int? MallCouponDiscountPct {get;set;}
/// <summary>
/// 最小使用金额
/// </summary>
[JsonProperty("mall_coupon_min_order_amount")]
public int? MallCouponMinOrderAmount {get;set;}
/// <summary>
/// 最大使用金额
/// </summary>
[JsonProperty("mall_coupon_max_discount_amount")]
public int? MallCouponMaxDiscountAmount {get;set;}
/// <summary>
/// 店铺券总量
/// </summary>
[JsonProperty("mall_coupon_total_quantity")]
public long? MallCouponTotalQuantity {get;set;}
/// <summary>
/// 店铺券余量
/// </summary>
[JsonProperty("mall_coupon_remain_quantity")]
public long? MallCouponRemainQuantity {get;set;}
/// <summary>
/// 店铺券使用开始时间
/// </summary>
[JsonProperty("mall_coupon_start_time")]
public long? MallCouponStartTime {get;set;}
/// <summary>
/// 店铺券使用结束时间
/// </summary>
[JsonProperty("mall_coupon_end_time")]
public long? MallCouponEndTime {get;set;}
/// <summary>
/// 参与多多进宝的商品ID
/// </summary>
[JsonProperty("goods_id")]
public long? GoodsId {get;set;}
/// <summary>
/// 参与多多进宝的商品标题
/// </summary>
[JsonProperty("goods_name")]
public string GoodsName {get;set;}
/// <summary>
/// 参与多多进宝的商品描述
/// </summary>
[JsonProperty("goods_desc")]
public string GoodsDesc {get;set;}
/// <summary>
/// 多多进宝商品主图
/// </summary>
[JsonProperty("goods_image_url")]
public string GoodsImageUrl {get;set;}
/// <summary>
/// 商品轮播图
/// </summary>
[JsonProperty("goods_gallery_urls")]
public List<string> GoodsGalleryUrls {get;set;}
/// <summary>
/// 已售卖件数
/// </summary>
[JsonProperty("sold_quantity")]
public long? SoldQuantity {get;set;}
/// <summary>
/// 最低价sku的拼团价，单位为分
/// </summary>
[JsonProperty("min_group_price")]
public long? MinGroupPrice {get;set;}
/// <summary>
/// 最低价sku的单买价，单位为分
/// </summary>
[JsonProperty("min_normal_price")]
public long? MinNormalPrice {get;set;}
/// <summary>
/// 店铺名称
/// </summary>
[JsonProperty("mall_name")]
public string MallName {get;set;}
/// <summary>
/// 商品标签ID，使用pdd.goods.opt.get接口获取
/// </summary>
[JsonProperty("opt_id")]
public long? OptId {get;set;}
/// <summary>
/// 商品标签名称
/// </summary>
[JsonProperty("opt_name")]
public string OptName {get;set;}
/// <summary>
/// 商品标签ID
/// </summary>
[JsonProperty("opt_ids")]
public List<int?> OptIds {get;set;}
/// <summary>
/// 商品一~四级类目ID列表
/// </summary>
[JsonProperty("cat_ids")]
public List<int?> CatIds {get;set;}
/// <summary>
/// 优惠券门槛金额，单位为分
/// </summary>
[JsonProperty("coupon_min_order_amount")]
public long? CouponMinOrderAmount {get;set;}
/// <summary>
/// 优惠券面额，单位为分
/// </summary>
[JsonProperty("coupon_discount")]
public long? CouponDiscount {get;set;}
/// <summary>
/// 优惠券总数量
/// </summary>
[JsonProperty("coupon_total_quantity")]
public long? CouponTotalQuantity {get;set;}
/// <summary>
/// 优惠券剩余数量
/// </summary>
[JsonProperty("coupon_remain_quantity")]
public long? CouponRemainQuantity {get;set;}
/// <summary>
/// 优惠券生效时间，UNIX时间戳
/// </summary>
[JsonProperty("coupon_start_time")]
public long? CouponStartTime {get;set;}
/// <summary>
/// 优惠券失效时间，UNIX时间戳
/// </summary>
[JsonProperty("coupon_end_time")]
public long? CouponEndTime {get;set;}
/// <summary>
/// 佣金比例，千分比
/// </summary>
[JsonProperty("promotion_rate")]
public long? PromotionRate {get;set;}
/// <summary>
/// 商品评价分
/// </summary>
[JsonProperty("goods_eval_score")]
public double? GoodsEvalScore {get;set;}
/// <summary>
/// 商品评价数
/// </summary>
[JsonProperty("goods_eval_count")]
public long? GoodsEvalCount {get;set;}
/// <summary>
/// 商品类目ID，使用pdd.goods.cats.get接口获取
/// </summary>
[JsonProperty("cat_id")]
public long? CatId {get;set;}
/// <summary>
/// 描述评分
/// </summary>
[JsonProperty("avg_desc")]
public long? AvgDesc {get;set;}
/// <summary>
/// 物流评分
/// </summary>
[JsonProperty("avg_lgst")]
public long? AvgLgst {get;set;}
/// <summary>
/// 服务评分
/// </summary>
[JsonProperty("avg_serv")]
public long? AvgServ {get;set;}
/// <summary>
/// 描述评分击败同类店铺百分比
/// </summary>
[JsonProperty("desc_pct")]
public double? DescPct {get;set;}
/// <summary>
/// 物流评分击败同类店铺百分比
/// </summary>
[JsonProperty("lgst_pct")]
public double? LgstPct {get;set;}
/// <summary>
/// 服务评分击败同类店铺百分比
/// </summary>
[JsonProperty("serv_pct")]
public double? ServPct {get;set;}

}

}

}

}
