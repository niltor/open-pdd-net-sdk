using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GetGoodsDetailResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品详情response
/// </summary>
[JsonProperty("goods_detail_get_response")]
public object GoodsDetailGetResponse {get;set;}
/// <summary>
/// 商品状态 1:上架，2：下架，3：售罄 4：已删除
/// </summary>
[JsonProperty("status")]
public int Status {get;set;}
/// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id")]
public int GoodsId {get;set;}
/// <summary>
/// 购买限制
/// </summary>
[JsonProperty("buy_limit")]
public int BuyLimit {get;set;}
/// <summary>
/// 商品轮播图列表
/// </summary>
[JsonProperty("carousel_gallery_list")]
public object CarouselGalleryList {get;set;}
/// <summary>
/// 叶子类目ID
/// </summary>
[JsonProperty("cat_id")]
public int CatId {get;set;}
/// <summary>
/// 运费模版id
/// </summary>
[JsonProperty("cost_template_id")]
public int CostTemplateId {get;set;}
/// <summary>
/// 国家id
/// </summary>
[JsonProperty("country_id")]
public int CountryId {get;set;}
/// <summary>
/// 团购人数
/// </summary>
[JsonProperty("customer_num")]
public int CustomerNum {get;set;}
/// <summary>
/// 商品类型：1-国内普通商品，2-进口，3-国外海淘，4-直邮 ,5-流量,6-话费,7,优惠券;8-QQ充值,9-加油卡 暂时支持1-普通商品的上架
/// </summary>
[JsonProperty("goods_type")]
public int GoodsType {get;set;}
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
/// 商品短标题
/// </summary>
[JsonProperty("tiny_name")]
public object TinyName {get;set;}
/// <summary>
/// 保税仓
/// </summary>
[JsonProperty("warehouse")]
public object Warehouse {get;set;}
/// <summary>
/// 是否需要上报海关 0:否 1:是
/// </summary>
[JsonProperty("is_customs")]
public int IsCustoms {get;set;}
/// <summary>
/// 海关名称
/// </summary>
[JsonProperty("customs")]
public object Customs {get;set;}
/// <summary>
/// 市场价格，单位为分
/// </summary>
[JsonProperty("market_price")]
public int MarketPrice {get;set;}
/// <summary>
/// 是否预售,1-预售商品，0-非预售商品
/// </summary>
[JsonProperty("is_pre_sale")]
public int IsPreSale {get;set;}
/// <summary>
/// 预售时间
/// </summary>
[JsonProperty("pre_sale_time")]
public int PreSaleTime {get;set;}
/// <summary>
/// 承诺发货时间（ 秒）
/// </summary>
[JsonProperty("shipment_limit_second")]
public int ShipmentLimitSecond {get;set;}
/// <summary>
/// 限购次数
/// </summary>
[JsonProperty("order_limit")]
public int OrderLimit {get;set;}
/// <summary>
/// 是否7天无理由退换货，1-支持，0-不支持
/// </summary>
[JsonProperty("is_refundable")]
public int IsRefundable {get;set;}
/// <summary>
/// 是否支持假一赔十，0-不支持，1-支持
/// </summary>
[JsonProperty("is_folt")]
public int IsFolt {get;set;}
/// <summary>
/// 水果类目温馨提示
/// </summary>
[JsonProperty("warm_tips")]
public object WarmTips {get;set;}
/// <summary>
/// sku列表
/// </summary>
[JsonProperty("sku_list")]
public object SkuList {get;set;}
/// <summary>
/// 普通缩略图
/// </summary>
[JsonProperty("thumb_url")]
public object ThumbUrl {get;set;}
/// <summary>
/// 高清缩略图
/// </summary>
[JsonProperty("hd_thumb_url")]
public object HdThumbUrl {get;set;}
/// <summary>
/// 商品主图
/// </summary>
[JsonProperty("image_url")]
public object ImageUrl {get;set;}
/// <summary>
/// 商品详情图
/// </summary>
[JsonProperty("detail_gallery_list")]
public object DetailGalleryList {get;set;}
/// <summary>
/// 商家编码（商品维度），同其他接口中的outer_goods_id 、out_goods_id、out_goods_sn、outer_goods_sn 都为商家编码（goods维度）。
/// </summary>
[JsonProperty("outer_goods_id")]
public object OuterGoodsId {get;set;}
/// <summary>
/// 是否二手 1:是 0:否
/// </summary>
[JsonProperty("second_hand")]
public int SecondHand {get;set;}
/// <summary>
/// sku编码
/// </summary>
[JsonProperty("sku_id")]
public int SkuId {get;set;}
/// <summary>
/// 上下架状态 1：上架 0 ：下架
/// </summary>
[JsonProperty("is_onsale")]
public int IsOnsale {get;set;}
/// <summary>
/// sku购买限制
/// </summary>
[JsonProperty("limit_quantity")]
public int LimitQuantity {get;set;}
/// <summary>
/// 商品团购价格 单位分
/// </summary>
[JsonProperty("multi_price")]
public int MultiPrice {get;set;}
/// <summary>
/// 商品单买价格 单位分
/// </summary>
[JsonProperty("price")]
public int Price {get;set;}
/// <summary>
/// 库存
/// </summary>
[JsonProperty("quantity")]
public int Quantity {get;set;}
/// <summary>
/// 重量，单位为g
/// </summary>
[JsonProperty("weight")]
public int Weight {get;set;}
/// <summary>
/// sku预览图
/// </summary>
[JsonProperty("thumb_url")]
public object ThumbUrl {get;set;}
/// <summary>
/// 商品规格列表
/// </summary>
[JsonProperty("spec")]
public object Spec {get;set;}
/// <summary>
/// 商家编码（sku维度），同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。
/// </summary>
[JsonProperty("out_sku_sn")]
public object OutSkuSn {get;set;}
/// <summary>
/// 自定义规格所属的规格ID
/// </summary>
[JsonProperty("parent_id")]
public int ParentId {get;set;}
/// <summary>
/// 商品规格ID对应的规格名称
/// </summary>
[JsonProperty("parent_name")]
public object ParentName {get;set;}
/// <summary>
/// 自定义规格ID
/// </summary>
[JsonProperty("spec_id")]
public int SpecId {get;set;}
/// <summary>
/// 自定义规格名称
/// </summary>
[JsonProperty("spec_name")]
public object SpecName {get;set;}

    public partial class GoodsDetailGetResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品状态 1:上架，2：下架，3：售罄 4：已删除
/// </summary>
[JsonProperty("status")]
public int Status {get;set;}
/// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id")]
public int GoodsId {get;set;}
/// <summary>
/// 购买限制
/// </summary>
[JsonProperty("buy_limit")]
public int BuyLimit {get;set;}
/// <summary>
/// 商品轮播图列表
/// </summary>
[JsonProperty("carousel_gallery_list")]
public object CarouselGalleryList {get;set;}
/// <summary>
/// 叶子类目ID
/// </summary>
[JsonProperty("cat_id")]
public int CatId {get;set;}
/// <summary>
/// 运费模版id
/// </summary>
[JsonProperty("cost_template_id")]
public int CostTemplateId {get;set;}
/// <summary>
/// 国家id
/// </summary>
[JsonProperty("country_id")]
public int CountryId {get;set;}
/// <summary>
/// 团购人数
/// </summary>
[JsonProperty("customer_num")]
public int CustomerNum {get;set;}
/// <summary>
/// 商品类型：1-国内普通商品，2-进口，3-国外海淘，4-直邮 ,5-流量,6-话费,7,优惠券;8-QQ充值,9-加油卡 暂时支持1-普通商品的上架
/// </summary>
[JsonProperty("goods_type")]
public int GoodsType {get;set;}
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
/// 商品短标题
/// </summary>
[JsonProperty("tiny_name")]
public object TinyName {get;set;}
/// <summary>
/// 保税仓
/// </summary>
[JsonProperty("warehouse")]
public object Warehouse {get;set;}
/// <summary>
/// 是否需要上报海关 0:否 1:是
/// </summary>
[JsonProperty("is_customs")]
public int IsCustoms {get;set;}
/// <summary>
/// 海关名称
/// </summary>
[JsonProperty("customs")]
public object Customs {get;set;}
/// <summary>
/// 市场价格，单位为分
/// </summary>
[JsonProperty("market_price")]
public int MarketPrice {get;set;}
/// <summary>
/// 是否预售,1-预售商品，0-非预售商品
/// </summary>
[JsonProperty("is_pre_sale")]
public int IsPreSale {get;set;}
/// <summary>
/// 预售时间
/// </summary>
[JsonProperty("pre_sale_time")]
public int PreSaleTime {get;set;}
/// <summary>
/// 承诺发货时间（ 秒）
/// </summary>
[JsonProperty("shipment_limit_second")]
public int ShipmentLimitSecond {get;set;}
/// <summary>
/// 限购次数
/// </summary>
[JsonProperty("order_limit")]
public int OrderLimit {get;set;}
/// <summary>
/// 是否7天无理由退换货，1-支持，0-不支持
/// </summary>
[JsonProperty("is_refundable")]
public int IsRefundable {get;set;}
/// <summary>
/// 是否支持假一赔十，0-不支持，1-支持
/// </summary>
[JsonProperty("is_folt")]
public int IsFolt {get;set;}
/// <summary>
/// 水果类目温馨提示
/// </summary>
[JsonProperty("warm_tips")]
public object WarmTips {get;set;}
/// <summary>
/// sku列表
/// </summary>
[JsonProperty("sku_list")]
public object SkuList {get;set;}
/// <summary>
/// 普通缩略图
/// </summary>
[JsonProperty("thumb_url")]
public object ThumbUrl {get;set;}
/// <summary>
/// 高清缩略图
/// </summary>
[JsonProperty("hd_thumb_url")]
public object HdThumbUrl {get;set;}
/// <summary>
/// 商品主图
/// </summary>
[JsonProperty("image_url")]
public object ImageUrl {get;set;}
/// <summary>
/// 商品详情图
/// </summary>
[JsonProperty("detail_gallery_list")]
public object DetailGalleryList {get;set;}
/// <summary>
/// 商家编码（商品维度），同其他接口中的outer_goods_id 、out_goods_id、out_goods_sn、outer_goods_sn 都为商家编码（goods维度）。
/// </summary>
[JsonProperty("outer_goods_id")]
public object OuterGoodsId {get;set;}
/// <summary>
/// 是否二手 1:是 0:否
/// </summary>
[JsonProperty("second_hand")]
public int SecondHand {get;set;}

}

    public partial class SkuListResponseModel : PddResponseModel
    {
        /// <summary>
/// sku编码
/// </summary>
[JsonProperty("sku_id")]
public int SkuId {get;set;}
/// <summary>
/// 上下架状态 1：上架 0 ：下架
/// </summary>
[JsonProperty("is_onsale")]
public int IsOnsale {get;set;}
/// <summary>
/// sku购买限制
/// </summary>
[JsonProperty("limit_quantity")]
public int LimitQuantity {get;set;}
/// <summary>
/// 商品团购价格 单位分
/// </summary>
[JsonProperty("multi_price")]
public int MultiPrice {get;set;}
/// <summary>
/// 商品单买价格 单位分
/// </summary>
[JsonProperty("price")]
public int Price {get;set;}
/// <summary>
/// 库存
/// </summary>
[JsonProperty("quantity")]
public int Quantity {get;set;}
/// <summary>
/// 重量，单位为g
/// </summary>
[JsonProperty("weight")]
public int Weight {get;set;}
/// <summary>
/// sku预览图
/// </summary>
[JsonProperty("thumb_url")]
public object ThumbUrl {get;set;}
/// <summary>
/// 商品规格列表
/// </summary>
[JsonProperty("spec")]
public object Spec {get;set;}
/// <summary>
/// 商家编码（sku维度），同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。
/// </summary>
[JsonProperty("out_sku_sn")]
public object OutSkuSn {get;set;}

}

    public partial class SpecResponseModel : PddResponseModel
    {
        /// <summary>
/// 自定义规格所属的规格ID
/// </summary>
[JsonProperty("parent_id")]
public int ParentId {get;set;}
/// <summary>
/// 商品规格ID对应的规格名称
/// </summary>
[JsonProperty("parent_name")]
public object ParentName {get;set;}
/// <summary>
/// 自定义规格ID
/// </summary>
[JsonProperty("spec_id")]
public int SpecId {get;set;}
/// <summary>
/// 自定义规格名称
/// </summary>
[JsonProperty("spec_name")]
public object SpecName {get;set;}

}

}
}
