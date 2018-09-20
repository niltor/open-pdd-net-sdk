using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetDdkMerchantListResponseModel : PddResponseModel
    {
        /// <summary>
/// 店铺信息列表
/// </summary>
[JsonProperty("mall_search_info_vo_list")]
public MallSearchInfoVoListResponseModel MallSearchInfoVoList {get;set;}
/// <summary>
/// 店铺券列表
/// </summary>
[JsonProperty("mall_coupon_info_list")]
public MallCouponInfoListResponseModel MallCouponInfoList {get;set;}
/// <summary>
/// 商品详情列表
/// </summary>
[JsonProperty("goods_detail_vo_list")]
public GoodsDetailVoListResponseModel GoodsDetailVoList {get;set;}

    public partial class MallSearchInfoVoListResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品类目id列表
/// </summary>
[JsonProperty("cat_id_list")]
public object CatIdList {get;set;}
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
/// 全店推广佣金比
/// </summary>
[JsonProperty("mall_rate")]
public object MallRate {get;set;}
/// <summary>
/// 店铺类型，1-个人，2-企业，3-旗舰店，4-专卖店，5-专营店，6-普通店
/// </summary>
[JsonProperty("merchant_type")]
public int MerchantType {get;set;}
/// <summary>
/// 商品主图
/// </summary>
[JsonProperty("img_url")]
public object ImgUrl {get;set;}
/// <summary>
/// 售卖数量
/// </summary>
[JsonProperty("sold_quantity")]
public object SoldQuantity {get;set;}
/// <summary>
/// 商品数量
/// </summary>
[JsonProperty("goods_num")]
public object GoodsNum {get;set;}
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
/// 描述评分击败同类店铺百分比
/// </summary>
[JsonProperty("desc_pct")]
public object DescPct {get;set;}
/// <summary>
/// 物流评分击败同类店铺百分比
/// </summary>
[JsonProperty("lgst_pct")]
public object LgstPct {get;set;}
/// <summary>
/// 服务评分击败同类店铺百分比
/// </summary>
[JsonProperty("serv_pct")]
public object ServPct {get;set;}

}

    public partial class MallCouponInfoListResponseModel : PddResponseModel
    {
        /// <summary>
/// 店铺id
/// </summary>
[JsonProperty("mall_id")]
public object MallId {get;set;}
/// <summary>
/// 优惠券id
/// </summary>
[JsonProperty("coupon_id")]
public object CouponId {get;set;}
/// <summary>
/// 优惠券类型（224是满减，225是折扣）
/// </summary>
[JsonProperty("coupon_type")]
public object CouponType {get;set;}
/// <summary>
/// 折扣券，折扣力度 60/100 即6折；满减券，优惠券面额（单位为分 即60分）
/// </summary>
[JsonProperty("discount")]
public object Discount {get;set;}
/// <summary>
/// 使用优惠券门槛金额
/// </summary>
[JsonProperty("min_order_amount")]
public object MinOrderAmount {get;set;}
/// <summary>
/// 使用优惠券最高减的金额
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

    public partial class GoodsDetailVoListResponseModel : PddResponseModel
    {
        /// <summary>
/// 创建时间
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
/// 商品详情图
/// </summary>
[JsonProperty("goods_gallery_urls")]
public object GoodsGalleryUrls {get;set;}
/// <summary>
/// 商品售卖件数
/// </summary>
[JsonProperty("sold_quantity")]
public object SoldQuantity {get;set;}
/// <summary>
/// 商品最小成团价（单位为分）
/// </summary>
[JsonProperty("min_group_price")]
public object MinGroupPrice {get;set;}
/// <summary>
/// 商品单买价（单位为分）
/// </summary>
[JsonProperty("min_normal_price")]
public object MinNormalPrice {get;set;}
/// <summary>
/// 店铺名称
/// </summary>
[JsonProperty("mall_name")]
public object MallName {get;set;}
/// <summary>
/// 店铺类型，1-个人，2-企业，3-旗舰店，4-专卖店，5-专营店，6-普通店
/// </summary>
[JsonProperty("merchant_type")]
public int MerchantType {get;set;}
/// <summary>
/// 商品类目
/// </summary>
[JsonProperty("category_id")]
public object CategoryId {get;set;}
/// <summary>
/// 商品类目名
/// </summary>
[JsonProperty("category_name")]
public object CategoryName {get;set;}
/// <summary>
/// 商品标签
/// </summary>
[JsonProperty("opt_id")]
public object OptId {get;set;}
/// <summary>
/// 商品标签名
/// </summary>
[JsonProperty("opt_name")]
public object OptName {get;set;}
/// <summary>
/// 商品标签列表
/// </summary>
[JsonProperty("opt_ids")]
public object OptIds {get;set;}
/// <summary>
/// 商品类目列表
/// </summary>
[JsonProperty("cat_ids")]
public object CatIds {get;set;}
/// <summary>
/// 商品所在店铺是否开通全店推广 0：否，1：是
/// </summary>
[JsonProperty("mall_cps")]
public int MallCps {get;set;}
/// <summary>
/// 商品是否有优惠券（指单品券）
/// </summary>
[JsonProperty("has_coupon")]
public object HasCoupon {get;set;}
/// <summary>
/// 使用优惠券的门槛金额（单位为分）
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
/// 优惠券开始时间
/// </summary>
[JsonProperty("coupon_start_time")]
public object CouponStartTime {get;set;}
/// <summary>
/// 优惠券结束时间
/// </summary>
[JsonProperty("coupon_end_time")]
public object CouponEndTime {get;set;}
/// <summary>
/// 佣金比（单位为分）
/// </summary>
[JsonProperty("promotion_rate")]
public object PromotionRate {get;set;}
/// <summary>
/// 商品评分
/// </summary>
[JsonProperty("goods_eval_score")]
public object GoodsEvalScore {get;set;}
/// <summary>
/// 商品评价数
/// </summary>
[JsonProperty("goods_eval_count")]
public object GoodsEvalCount {get;set;}
/// <summary>
/// 类目id
/// </summary>
[JsonProperty("cat_id")]
public object CatId {get;set;}
/// <summary>
/// 商品描述评分
/// </summary>
[JsonProperty("avg_desc")]
public object AvgDesc {get;set;}
/// <summary>
/// 商品物流评分
/// </summary>
[JsonProperty("avg_lgst")]
public object AvgLgst {get;set;}
/// <summary>
/// 商品服务评分
/// </summary>
[JsonProperty("avg_serv")]
public object AvgServ {get;set;}
/// <summary>
/// 描述评分击败同类店铺百分比
/// </summary>
[JsonProperty("desc_pct")]
public object DescPct {get;set;}
/// <summary>
/// 物流评分击败同类店铺百分比
/// </summary>
[JsonProperty("lgst_pct")]
public object LgstPct {get;set;}
/// <summary>
/// 服务评分击败同类店铺百分比
/// </summary>
[JsonProperty("serv_pct")]
public object ServPct {get;set;}

}

}
}
