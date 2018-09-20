using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class DetailDdkGoodsResponseModel : PddResponseModel
    {
        /// <summary>
/// 多多进宝商品对象列表
/// </summary>
[JsonProperty("goods_details")]
public GoodsDetailsResponseModel GoodsDetails {get;set;}

    public partial class GoodsDetailsResponseModel : PddResponseModel
    {
        /// <summary>
/// 服务评分击败同类店铺百分比
/// </summary>
[JsonProperty("serv_pct")]
public object ServPct {get;set;}
/// <summary>
/// 物流评分击败同类店铺百分比
/// </summary>
[JsonProperty("lgst_pct")]
public object LgstPct {get;set;}
/// <summary>
/// 描述评分击败同类店铺百分比
/// </summary>
[JsonProperty("desc_pct")]
public object DescPct {get;set;}
/// <summary>
/// 商品标签ID
/// </summary>
[JsonProperty("opt_ids")]
public object[] OptIds {get;set;}
/// <summary>
/// 服务评分
/// </summary>
[JsonProperty("avg_serv")]
public object AvgServ {get;set;}
/// <summary>
/// 物流评分
/// </summary>
[JsonProperty("avg_lgst")]
public object AvgLgst {get;set;}
/// <summary>
/// 描述评分
/// </summary>
[JsonProperty("avg_desc")]
public object AvgDesc {get;set;}
/// <summary>
/// 商品一~四级类目ID列表
/// </summary>
[JsonProperty("cat_ids")]
public object CatIds {get;set;}
/// <summary>
/// 商品类目ID，使用pdd.goods.cats.get接口获取
/// </summary>
[JsonProperty("cat_id")]
public int CatId {get;set;}
/// <summary>
/// 优惠券剩余数量
/// </summary>
[JsonProperty("coupon_remain_quantity")]
public int CouponRemainQuantity {get;set;}
/// <summary>
/// 商品评价数
/// </summary>
[JsonProperty("goods_eval_count")]
public object GoodsEvalCount {get;set;}
/// <summary>
/// 商品评价分
/// </summary>
[JsonProperty("goods_eval_score")]
public object GoodsEvalScore {get;set;}
/// <summary>
/// 商品标签名称
/// </summary>
[JsonProperty("opt_name")]
public object OptName {get;set;}
/// <summary>
/// 优惠券门槛金额，单位为分
/// </summary>
[JsonProperty("coupon_min_order_amount")]
public int CouponMinOrderAmount {get;set;}
/// <summary>
/// 优惠券面额，单位为分
/// </summary>
[JsonProperty("coupon_discount")]
public int CouponDiscount {get;set;}
/// <summary>
/// 优惠券总数量
/// </summary>
[JsonProperty("coupon_total_quantity")]
public int CouponTotalQuantity {get;set;}
/// <summary>
/// 优惠券生效时间，UNIX时间戳
/// </summary>
[JsonProperty("coupon_start_time")]
public object CouponStartTime {get;set;}
/// <summary>
/// 优惠券失效时间，UNIX时间戳
/// </summary>
[JsonProperty("coupon_end_time")]
public object CouponEndTime {get;set;}
/// <summary>
/// 佣金比例，千分比
/// </summary>
[JsonProperty("promotion_rate")]
public int PromotionRate {get;set;}
/// <summary>
/// 店铺名称
/// </summary>
[JsonProperty("mall_name")]
public object MallName {get;set;}
/// <summary>
/// 商品标签ID，使用pdd.goods.opt.get接口获取
/// </summary>
[JsonProperty("opt_id")]
public int OptId {get;set;}
/// <summary>
/// 参与多多进宝的商品ID
/// </summary>
[JsonProperty("goods_id")]
public object GoodsId {get;set;}
/// <summary>
/// 参与多多进宝的商品标题
/// </summary>
[JsonProperty("goods_name")]
public object GoodsName {get;set;}
/// <summary>
/// 参与多多进宝的商品描述
/// </summary>
[JsonProperty("goods_desc")]
public object GoodsDesc {get;set;}
/// <summary>
/// 多多进宝商品主图
/// </summary>
[JsonProperty("goods_image_url")]
public object GoodsImageUrl {get;set;}
/// <summary>
/// 商品轮播图
/// </summary>
[JsonProperty("goods_gallery_urls")]
public object GoodsGalleryUrls {get;set;}
/// <summary>
/// 已售卖件数
/// </summary>
[JsonProperty("sold_quantity")]
public int SoldQuantity {get;set;}
/// <summary>
/// 最低价sku的拼团价，单位为分
/// </summary>
[JsonProperty("min_group_price")]
public int MinGroupPrice {get;set;}
/// <summary>
/// 最低价sku的单买价，单位为分
/// </summary>
[JsonProperty("min_normal_price")]
public int MinNormalPrice {get;set;}

}

}
}
