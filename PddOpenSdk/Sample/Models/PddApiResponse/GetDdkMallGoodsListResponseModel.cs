using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GetDdkMallGoodsListResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回商品总数
/// </summary>
[JsonProperty("total")]
public object Total {get;set;}
/// <summary>
/// 商品信息列表，具体信息见下（注：目前仅返回商品基础信息，其余为空，凡示例中为null的目前均返回为空，获取这些字段请调用pdd.ddk.goods,detail接口）
/// </summary>
[JsonProperty("goods_list")]
public object GoodsList {get;set;}
/// <summary>
/// 商品创建时间（UNIX时间戳）
/// </summary>
[JsonProperty("create_at")]
public object CreateAt {get;set;}
/// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id")]
public object GoodsId {get;set;}
/// <summary>
/// 商品名称
/// </summary>
[JsonProperty("goods_name")]
public object GoodsName {get;set;}
/// <summary>
/// 商品描述
/// </summary>
[JsonProperty("goods_desc")]
public object GoodsDesc {get;set;}
/// <summary>
/// 商品缩略图
/// </summary>
[JsonProperty("goods_thumbnail_url")]
public object GoodsThumbnailUrl {get;set;}
/// <summary>
/// 商品主图
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
/// 商品市场价（单位为分）
/// </summary>
[JsonProperty("goods_mark_price")]
public int GoodsMarkPrice {get;set;}
/// <summary>
/// 商品实际价格（单位为分）
/// </summary>
[JsonProperty("goods_fact_price")]
public int GoodsFactPrice {get;set;}
/// <summary>
/// 商品拼团价（单位为分）
/// </summary>
[JsonProperty("min_group_price")]
public int MinGroupPrice {get;set;}
/// <summary>
/// 商品单买价（单位为分）
/// </summary>
[JsonProperty("min_normal_price")]
public int MinNormalPrice {get;set;}
/// <summary>
/// 店铺id
/// </summary>
[JsonProperty("mall_id")]
public object MallId {get;set;}
/// <summary>
/// 店铺名称
/// </summary>
[JsonProperty("mall_name")]
public object MallName {get;set;}
/// <summary>
/// 店铺类型，1-个人，2-企业，3-旗舰店，4-专卖店，5-专营店，6-普通店（未传为全部）
/// </summary>
[JsonProperty("merchant_type")]
public int MerchantType {get;set;}
/// <summary>
/// 商品类目id
/// </summary>
[JsonProperty("category_id")]
public int CategoryId {get;set;}
/// <summary>
/// 商品类目名
/// </summary>
[JsonProperty("category_name")]
public object CategoryName {get;set;}
/// <summary>
/// 商品标签id
/// </summary>
[JsonProperty("opt_id")]
public int OptId {get;set;}
/// <summary>
/// 商品标签名
/// </summary>
[JsonProperty("opt_name")]
public object OptName {get;set;}
/// <summary>
/// 商品标签ID
/// </summary>
[JsonProperty("opt_ids")]
public object OptIds {get;set;}
/// <summary>
/// 商品标签ID（多级）
/// </summary>
[JsonProperty("cat_ids")]
public object CatIds {get;set;}
/// <summary>
/// 商品类型，1-普通商品，2-进口商品，3-直供，4-直邮
/// </summary>
[JsonProperty("goods_type")]
public int GoodsType {get;set;}
/// <summary>
/// 是否有优惠券
/// </summary>
[JsonProperty("has_coupon")]
public object HasCoupon {get;set;}
/// <summary>
/// 优惠券ID
/// </summary>
[JsonProperty("coupon_id")]
public object CouponId {get;set;}
/// <summary>
/// 优惠券最小门槛价（单位为分）
/// </summary>
[JsonProperty("coupon_min_order_amount")]
public object CouponMinOrderAmount {get;set;}
/// <summary>
/// 优惠券面额（单位为分）
/// </summary>
[JsonProperty("coupon_discount")]
public object CouponDiscount {get;set;}
/// <summary>
/// 优惠券总数量
/// </summary>
[JsonProperty("coupon_total_quantity")]
public object CouponTotalQuantity {get;set;}
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
/// <summary>
/// 佣金比（千分比）
/// </summary>
[JsonProperty("promotion_rate")]
public object PromotionRate {get;set;}
/// <summary>
/// 优惠券面额
/// </summary>
[JsonProperty("coupon_price")]
public object CouponPrice {get;set;}
/// <summary>
/// 商品佣金比（千分比）
/// </summary>
[JsonProperty("goods_rate")]
public object GoodsRate {get;set;}
/// <summary>
/// 佣金（单位为分）
/// </summary>
[JsonProperty("market_fee")]
public object MarketFee {get;set;}
/// <summary>
/// 该商品所在店铺是否参与全店推广，0：否，1：是
/// </summary>
[JsonProperty("mall_cps")]
public int MallCps {get;set;}
/// <summary>
/// 商品评价分
/// </summary>
[JsonProperty("goods_eval_score")]
public object GoodsEvalScore {get;set;}
/// <summary>
/// 商品评价数
/// </summary>
[JsonProperty("goods_eval_count")]
public object GoodsEvalCount {get;set;}
/// <summary>
/// 商品类目ID
/// </summary>
[JsonProperty("cat_id")]
public object CatId {get;set;}
/// <summary>
/// 分享文案
/// </summary>
[JsonProperty("share_desc")]
public object ShareDesc {get;set;}
/// <summary>
/// 描述评分
/// </summary>
[JsonProperty("avg_desc")]
public object AvgDesc {get;set;}
/// <summary>
/// 物流评分
/// </summary>
[JsonProperty("avg_lgst")]
public object AvgLgst {get;set;}
/// <summary>
/// 服务评分
/// </summary>
[JsonProperty("avg_serv")]
public object AvgServ {get;set;}
/// <summary>
/// 描述分击败同类店铺百分比
/// </summary>
[JsonProperty("desc_pct")]
public object DescPct {get;set;}
/// <summary>
/// 物流分击败同类店铺百分比
/// </summary>
[JsonProperty("lgst_pct")]
public object LgstPct {get;set;}
/// <summary>
/// 服务分击败同类店铺百分比
/// </summary>
[JsonProperty("serv_pct")]
public object ServPct {get;set;}
/// <summary>
/// 最近24小时多多进宝商品销量
/// </summary>
[JsonProperty("sale_num24")]
public object SaleNum24 {get;set;}
/// <summary>
/// 今日销量
/// </summary>
[JsonProperty("sale_num_today")]
public object SaleNumToday {get;set;}
/// <summary>
/// 商品排名
/// </summary>
[JsonProperty("rank")]
public object Rank {get;set;}
/// <summary>
/// 对接小二
/// </summary>
[JsonProperty("broker")]
public object Broker {get;set;}
/// <summary>
/// 锁定编辑状态
/// </summary>
[JsonProperty("lock_edit")]
public bool LockEdit {get;set;}
/// <summary>
/// 聊天二维码图片url
/// </summary>
[JsonProperty("qr_code_image_url")]
public object QrCodeImageUrl {get;set;}
/// <summary>
/// 全店推广店铺佣金比（千分比）
/// </summary>
[JsonProperty("mall_rate")]
public object MallRate {get;set;}

    public partial class GoodsListResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品创建时间（UNIX时间戳）
/// </summary>
[JsonProperty("create_at")]
public object CreateAt {get;set;}
/// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id")]
public object GoodsId {get;set;}
/// <summary>
/// 商品名称
/// </summary>
[JsonProperty("goods_name")]
public object GoodsName {get;set;}
/// <summary>
/// 商品描述
/// </summary>
[JsonProperty("goods_desc")]
public object GoodsDesc {get;set;}
/// <summary>
/// 商品缩略图
/// </summary>
[JsonProperty("goods_thumbnail_url")]
public object GoodsThumbnailUrl {get;set;}
/// <summary>
/// 商品主图
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
/// 商品市场价（单位为分）
/// </summary>
[JsonProperty("goods_mark_price")]
public int GoodsMarkPrice {get;set;}
/// <summary>
/// 商品实际价格（单位为分）
/// </summary>
[JsonProperty("goods_fact_price")]
public int GoodsFactPrice {get;set;}
/// <summary>
/// 商品拼团价（单位为分）
/// </summary>
[JsonProperty("min_group_price")]
public int MinGroupPrice {get;set;}
/// <summary>
/// 商品单买价（单位为分）
/// </summary>
[JsonProperty("min_normal_price")]
public int MinNormalPrice {get;set;}
/// <summary>
/// 店铺id
/// </summary>
[JsonProperty("mall_id")]
public object MallId {get;set;}
/// <summary>
/// 店铺名称
/// </summary>
[JsonProperty("mall_name")]
public object MallName {get;set;}
/// <summary>
/// 店铺类型，1-个人，2-企业，3-旗舰店，4-专卖店，5-专营店，6-普通店（未传为全部）
/// </summary>
[JsonProperty("merchant_type")]
public int MerchantType {get;set;}
/// <summary>
/// 商品类目id
/// </summary>
[JsonProperty("category_id")]
public int CategoryId {get;set;}
/// <summary>
/// 商品类目名
/// </summary>
[JsonProperty("category_name")]
public object CategoryName {get;set;}
/// <summary>
/// 商品标签id
/// </summary>
[JsonProperty("opt_id")]
public int OptId {get;set;}
/// <summary>
/// 商品标签名
/// </summary>
[JsonProperty("opt_name")]
public object OptName {get;set;}
/// <summary>
/// 商品标签ID
/// </summary>
[JsonProperty("opt_ids")]
public object OptIds {get;set;}
/// <summary>
/// 商品标签ID（多级）
/// </summary>
[JsonProperty("cat_ids")]
public object CatIds {get;set;}
/// <summary>
/// 商品类型，1-普通商品，2-进口商品，3-直供，4-直邮
/// </summary>
[JsonProperty("goods_type")]
public int GoodsType {get;set;}
/// <summary>
/// 是否有优惠券
/// </summary>
[JsonProperty("has_coupon")]
public object HasCoupon {get;set;}
/// <summary>
/// 优惠券ID
/// </summary>
[JsonProperty("coupon_id")]
public object CouponId {get;set;}
/// <summary>
/// 优惠券最小门槛价（单位为分）
/// </summary>
[JsonProperty("coupon_min_order_amount")]
public object CouponMinOrderAmount {get;set;}
/// <summary>
/// 优惠券面额（单位为分）
/// </summary>
[JsonProperty("coupon_discount")]
public object CouponDiscount {get;set;}
/// <summary>
/// 优惠券总数量
/// </summary>
[JsonProperty("coupon_total_quantity")]
public object CouponTotalQuantity {get;set;}
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
/// <summary>
/// 佣金比（千分比）
/// </summary>
[JsonProperty("promotion_rate")]
public object PromotionRate {get;set;}
/// <summary>
/// 优惠券面额
/// </summary>
[JsonProperty("coupon_price")]
public object CouponPrice {get;set;}
/// <summary>
/// 商品佣金比（千分比）
/// </summary>
[JsonProperty("goods_rate")]
public object GoodsRate {get;set;}
/// <summary>
/// 佣金（单位为分）
/// </summary>
[JsonProperty("market_fee")]
public object MarketFee {get;set;}
/// <summary>
/// 该商品所在店铺是否参与全店推广，0：否，1：是
/// </summary>
[JsonProperty("mall_cps")]
public int MallCps {get;set;}
/// <summary>
/// 商品评价分
/// </summary>
[JsonProperty("goods_eval_score")]
public object GoodsEvalScore {get;set;}
/// <summary>
/// 商品评价数
/// </summary>
[JsonProperty("goods_eval_count")]
public object GoodsEvalCount {get;set;}
/// <summary>
/// 商品类目ID
/// </summary>
[JsonProperty("cat_id")]
public object CatId {get;set;}
/// <summary>
/// 分享文案
/// </summary>
[JsonProperty("share_desc")]
public object ShareDesc {get;set;}
/// <summary>
/// 描述评分
/// </summary>
[JsonProperty("avg_desc")]
public object AvgDesc {get;set;}
/// <summary>
/// 物流评分
/// </summary>
[JsonProperty("avg_lgst")]
public object AvgLgst {get;set;}
/// <summary>
/// 服务评分
/// </summary>
[JsonProperty("avg_serv")]
public object AvgServ {get;set;}
/// <summary>
/// 描述分击败同类店铺百分比
/// </summary>
[JsonProperty("desc_pct")]
public object DescPct {get;set;}
/// <summary>
/// 物流分击败同类店铺百分比
/// </summary>
[JsonProperty("lgst_pct")]
public object LgstPct {get;set;}
/// <summary>
/// 服务分击败同类店铺百分比
/// </summary>
[JsonProperty("serv_pct")]
public object ServPct {get;set;}
/// <summary>
/// 最近24小时多多进宝商品销量
/// </summary>
[JsonProperty("sale_num24")]
public object SaleNum24 {get;set;}
/// <summary>
/// 今日销量
/// </summary>
[JsonProperty("sale_num_today")]
public object SaleNumToday {get;set;}
/// <summary>
/// 商品排名
/// </summary>
[JsonProperty("rank")]
public object Rank {get;set;}
/// <summary>
/// 对接小二
/// </summary>
[JsonProperty("broker")]
public object Broker {get;set;}
/// <summary>
/// 锁定编辑状态
/// </summary>
[JsonProperty("lock_edit")]
public bool LockEdit {get;set;}
/// <summary>
/// 聊天二维码图片url
/// </summary>
[JsonProperty("qr_code_image_url")]
public object QrCodeImageUrl {get;set;}
/// <summary>
/// 全店推广店铺佣金比（千分比）
/// </summary>
[JsonProperty("mall_rate")]
public object MallRate {get;set;}

}

}
}
