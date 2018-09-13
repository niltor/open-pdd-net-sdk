using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GetGoodsDetailResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品详情response
/// </summary>
[JsonProperty("商品详情response")]
public object GoodsDetailGetResponse {get;set;}
/// <summary>
/// 商品状态 1:上架，2：下架，3：售罄 4：已删除
/// </summary>
[JsonProperty("商品状态 1:上架，2：下架，3：售罄 4：已删除")]
public int Status {get;set;}
/// <summary>
/// 商品id
/// </summary>
[JsonProperty("商品id")]
public int GoodsId {get;set;}
/// <summary>
/// 购买限制
/// </summary>
[JsonProperty("购买限制")]
public int BuyLimit {get;set;}
/// <summary>
/// 商品轮播图列表
/// </summary>
[JsonProperty("商品轮播图列表")]
public list CarouselGalleryList {get;set;}
/// <summary>
/// 叶子类目ID
/// </summary>
[JsonProperty("叶子类目ID")]
public int CatId {get;set;}
/// <summary>
/// 运费模版id
/// </summary>
[JsonProperty("运费模版id")]
public int CostTemplateId {get;set;}
/// <summary>
/// 国家id
/// </summary>
[JsonProperty("国家id")]
public int CountryId {get;set;}
/// <summary>
/// 团购人数
/// </summary>
[JsonProperty("团购人数")]
public int CustomerNum {get;set;}
/// <summary>
/// 商品类型：1-国内普通商品，2-进口，3-国外海淘，4-直邮 ,5-流量,6-话费,7,优惠券;8-QQ充值,9-加油卡 暂时支持1-普通商品的上架
/// </summary>
[JsonProperty("商品类型：1-国内普通商品，2-进口，3-国外海淘，4-直邮 ,5-流量,6-话费,7,优惠券;8-QQ充值,9-加油卡 暂时支持1-普通商品的上架")]
public int GoodsType {get;set;}
/// <summary>
/// 商品名称
/// </summary>
[JsonProperty("商品名称")]
public string GoodsName {get;set;}
/// <summary>
/// 商品描述
/// </summary>
[JsonProperty("商品描述")]
public string GoodsDesc {get;set;}
/// <summary>
/// 商品短标题
/// </summary>
[JsonProperty("商品短标题")]
public string TinyName {get;set;}
/// <summary>
/// 保税仓
/// </summary>
[JsonProperty("保税仓")]
public string Warehouse {get;set;}
/// <summary>
/// 是否需要上报海关 0:否 1:是
/// </summary>
[JsonProperty("是否需要上报海关 0:否 1:是")]
public int IsCustoms {get;set;}
/// <summary>
/// 海关名称
/// </summary>
[JsonProperty("海关名称")]
public string Customs {get;set;}
/// <summary>
/// 市场价格，单位为分
/// </summary>
[JsonProperty("市场价格，单位为分")]
public int MarketPrice {get;set;}
/// <summary>
/// 是否预售,1-预售商品，0-非预售商品
/// </summary>
[JsonProperty("是否预售,1-预售商品，0-非预售商品")]
public int IsPreSale {get;set;}
/// <summary>
/// 预售时间
/// </summary>
[JsonProperty("预售时间")]
public int PreSaleTime {get;set;}
/// <summary>
/// 承诺发货时间（ 秒）
/// </summary>
[JsonProperty("承诺发货时间（ 秒）")]
public int ShipmentLimitSecond {get;set;}
/// <summary>
/// 限购次数
/// </summary>
[JsonProperty("限购次数")]
public int OrderLimit {get;set;}
/// <summary>
/// 是否7天无理由退换货，1-支持，0-不支持
/// </summary>
[JsonProperty("是否7天无理由退换货，1-支持，0-不支持")]
public int IsRefundable {get;set;}
/// <summary>
/// 是否支持假一赔十，0-不支持，1-支持
/// </summary>
[JsonProperty("是否支持假一赔十，0-不支持，1-支持")]
public int IsFolt {get;set;}
/// <summary>
/// 水果类目温馨提示
/// </summary>
[JsonProperty("水果类目温馨提示")]
public string WarmTips {get;set;}
/// <summary>
/// sku列表
/// </summary>
[JsonProperty("sku列表")]
public  SkuList {get;set;}
/// <summary>
/// 普通缩略图
/// </summary>
[JsonProperty("普通缩略图")]
public string ThumbUrl {get;set;}
/// <summary>
/// 高清缩略图
/// </summary>
[JsonProperty("高清缩略图")]
public string HdThumbUrl {get;set;}
/// <summary>
/// 商品主图
/// </summary>
[JsonProperty("商品主图")]
public string ImageUrl {get;set;}
/// <summary>
/// 商品详情图
/// </summary>
[JsonProperty("商品详情图")]
public list DetailGalleryList {get;set;}
/// <summary>
/// 商家编码（商品维度），同其他接口中的outer_goods_id 、out_goods_id、out_goods_sn、outer_goods_sn 都为商家编码（goods维度）。
/// </summary>
[JsonProperty("商家编码（商品维度），同其他接口中的outer_goods_id 、out_goods_id、out_goods_sn、outer_goods_sn 都为商家编码（goods维度）。")]
public string OuterGoodsId {get;set;}
/// <summary>
/// 是否二手 1:是 0:否
/// </summary>
[JsonProperty("是否二手 1:是 0:否")]
public int SecondHand {get;set;}
/// <summary>
/// sku编码
/// </summary>
[JsonProperty("sku编码")]
public int SkuId {get;set;}
/// <summary>
/// 上下架状态 1：上架 0 ：下架
/// </summary>
[JsonProperty("上下架状态 1：上架 0 ：下架")]
public int IsOnsale {get;set;}
/// <summary>
/// sku购买限制
/// </summary>
[JsonProperty("sku购买限制")]
public int LimitQuantity {get;set;}
/// <summary>
/// 商品团购价格 单位分
/// </summary>
[JsonProperty("商品团购价格 单位分")]
public int MultiPrice {get;set;}
/// <summary>
/// 商品单买价格 单位分
/// </summary>
[JsonProperty("商品单买价格 单位分")]
public int Price {get;set;}
/// <summary>
/// 库存
/// </summary>
[JsonProperty("库存")]
public int Quantity {get;set;}
/// <summary>
/// 重量，单位为g
/// </summary>
[JsonProperty("重量，单位为g")]
public int Weight {get;set;}
/// <summary>
/// sku预览图
/// </summary>
[JsonProperty("sku预览图")]
public string ThumbUrl {get;set;}
/// <summary>
/// 商品规格列表
/// </summary>
[JsonProperty("商品规格列表")]
public list Spec {get;set;}
/// <summary>
/// 商家编码（sku维度），同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。
/// </summary>
[JsonProperty("商家编码（sku维度），同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。")]
public string OutSkuSn {get;set;}
/// <summary>
/// 自定义规格所属的规格ID
/// </summary>
[JsonProperty("自定义规格所属的规格ID")]
public int ParentId {get;set;}
/// <summary>
/// 商品规格ID对应的规格名称
/// </summary>
[JsonProperty("商品规格ID对应的规格名称")]
public string ParentName {get;set;}
/// <summary>
/// 自定义规格ID
/// </summary>
[JsonProperty("自定义规格ID")]
public int SpecId {get;set;}
/// <summary>
/// 自定义规格名称
/// </summary>
[JsonProperty("自定义规格名称")]
public string SpecName {get;set;}
}
}

    public partial class GoodsDetailGetResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品状态 1:上架，2：下架，3：售罄 4：已删除
/// </summary>
[JsonProperty("商品状态 1:上架，2：下架，3：售罄 4：已删除")]
public int Status {get;set;}
/// <summary>
/// 商品id
/// </summary>
[JsonProperty("商品id")]
public int GoodsId {get;set;}
/// <summary>
/// 购买限制
/// </summary>
[JsonProperty("购买限制")]
public int BuyLimit {get;set;}
/// <summary>
/// 商品轮播图列表
/// </summary>
[JsonProperty("商品轮播图列表")]
public list CarouselGalleryList {get;set;}
/// <summary>
/// 叶子类目ID
/// </summary>
[JsonProperty("叶子类目ID")]
public int CatId {get;set;}
/// <summary>
/// 运费模版id
/// </summary>
[JsonProperty("运费模版id")]
public int CostTemplateId {get;set;}
/// <summary>
/// 国家id
/// </summary>
[JsonProperty("国家id")]
public int CountryId {get;set;}
/// <summary>
/// 团购人数
/// </summary>
[JsonProperty("团购人数")]
public int CustomerNum {get;set;}
/// <summary>
/// 商品类型：1-国内普通商品，2-进口，3-国外海淘，4-直邮 ,5-流量,6-话费,7,优惠券;8-QQ充值,9-加油卡 暂时支持1-普通商品的上架
/// </summary>
[JsonProperty("商品类型：1-国内普通商品，2-进口，3-国外海淘，4-直邮 ,5-流量,6-话费,7,优惠券;8-QQ充值,9-加油卡 暂时支持1-普通商品的上架")]
public int GoodsType {get;set;}
/// <summary>
/// 商品名称
/// </summary>
[JsonProperty("商品名称")]
public string GoodsName {get;set;}
/// <summary>
/// 商品描述
/// </summary>
[JsonProperty("商品描述")]
public string GoodsDesc {get;set;}
/// <summary>
/// 商品短标题
/// </summary>
[JsonProperty("商品短标题")]
public string TinyName {get;set;}
/// <summary>
/// 保税仓
/// </summary>
[JsonProperty("保税仓")]
public string Warehouse {get;set;}
/// <summary>
/// 是否需要上报海关 0:否 1:是
/// </summary>
[JsonProperty("是否需要上报海关 0:否 1:是")]
public int IsCustoms {get;set;}
/// <summary>
/// 海关名称
/// </summary>
[JsonProperty("海关名称")]
public string Customs {get;set;}
/// <summary>
/// 市场价格，单位为分
/// </summary>
[JsonProperty("市场价格，单位为分")]
public int MarketPrice {get;set;}
/// <summary>
/// 是否预售,1-预售商品，0-非预售商品
/// </summary>
[JsonProperty("是否预售,1-预售商品，0-非预售商品")]
public int IsPreSale {get;set;}
/// <summary>
/// 预售时间
/// </summary>
[JsonProperty("预售时间")]
public int PreSaleTime {get;set;}
/// <summary>
/// 承诺发货时间（ 秒）
/// </summary>
[JsonProperty("承诺发货时间（ 秒）")]
public int ShipmentLimitSecond {get;set;}
/// <summary>
/// 限购次数
/// </summary>
[JsonProperty("限购次数")]
public int OrderLimit {get;set;}
/// <summary>
/// 是否7天无理由退换货，1-支持，0-不支持
/// </summary>
[JsonProperty("是否7天无理由退换货，1-支持，0-不支持")]
public int IsRefundable {get;set;}
/// <summary>
/// 是否支持假一赔十，0-不支持，1-支持
/// </summary>
[JsonProperty("是否支持假一赔十，0-不支持，1-支持")]
public int IsFolt {get;set;}
/// <summary>
/// 水果类目温馨提示
/// </summary>
[JsonProperty("水果类目温馨提示")]
public string WarmTips {get;set;}
/// <summary>
/// sku列表
/// </summary>
[JsonProperty("sku列表")]
public  SkuList {get;set;}
/// <summary>
/// 普通缩略图
/// </summary>
[JsonProperty("普通缩略图")]
public string ThumbUrl {get;set;}
/// <summary>
/// 高清缩略图
/// </summary>
[JsonProperty("高清缩略图")]
public string HdThumbUrl {get;set;}
/// <summary>
/// 商品主图
/// </summary>
[JsonProperty("商品主图")]
public string ImageUrl {get;set;}
/// <summary>
/// 商品详情图
/// </summary>
[JsonProperty("商品详情图")]
public list DetailGalleryList {get;set;}
/// <summary>
/// 商家编码（商品维度），同其他接口中的outer_goods_id 、out_goods_id、out_goods_sn、outer_goods_sn 都为商家编码（goods维度）。
/// </summary>
[JsonProperty("商家编码（商品维度），同其他接口中的outer_goods_id 、out_goods_id、out_goods_sn、outer_goods_sn 都为商家编码（goods维度）。")]
public string OuterGoodsId {get;set;}
/// <summary>
/// 是否二手 1:是 0:否
/// </summary>
[JsonProperty("是否二手 1:是 0:否")]
public int SecondHand {get;set;}
}


    public partial class SkuListResponseModel : PddResponseModel
    {
        /// <summary>
/// sku编码
/// </summary>
[JsonProperty("sku编码")]
public int SkuId {get;set;}
/// <summary>
/// 上下架状态 1：上架 0 ：下架
/// </summary>
[JsonProperty("上下架状态 1：上架 0 ：下架")]
public int IsOnsale {get;set;}
/// <summary>
/// sku购买限制
/// </summary>
[JsonProperty("sku购买限制")]
public int LimitQuantity {get;set;}
/// <summary>
/// 商品团购价格 单位分
/// </summary>
[JsonProperty("商品团购价格 单位分")]
public int MultiPrice {get;set;}
/// <summary>
/// 商品单买价格 单位分
/// </summary>
[JsonProperty("商品单买价格 单位分")]
public int Price {get;set;}
/// <summary>
/// 库存
/// </summary>
[JsonProperty("库存")]
public int Quantity {get;set;}
/// <summary>
/// 重量，单位为g
/// </summary>
[JsonProperty("重量，单位为g")]
public int Weight {get;set;}
/// <summary>
/// sku预览图
/// </summary>
[JsonProperty("sku预览图")]
public string ThumbUrl {get;set;}
/// <summary>
/// 商品规格列表
/// </summary>
[JsonProperty("商品规格列表")]
public list Spec {get;set;}
/// <summary>
/// 商家编码（sku维度），同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。
/// </summary>
[JsonProperty("商家编码（sku维度），同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。")]
public string OutSkuSn {get;set;}
}


    public partial class SpecResponseModel : PddResponseModel
    {
        /// <summary>
/// 自定义规格所属的规格ID
/// </summary>
[JsonProperty("自定义规格所属的规格ID")]
public int ParentId {get;set;}
/// <summary>
/// 商品规格ID对应的规格名称
/// </summary>
[JsonProperty("商品规格ID对应的规格名称")]
public string ParentName {get;set;}
/// <summary>
/// 自定义规格ID
/// </summary>
[JsonProperty("自定义规格ID")]
public int SpecId {get;set;}
/// <summary>
/// 自定义规格名称
/// </summary>
[JsonProperty("自定义规格名称")]
public string SpecName {get;set;}
}


