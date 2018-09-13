using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GetGoodsInformationResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品详情响应对象
/// </summary>
[JsonProperty("商品详情响应对象")]
public List<GoodsInfoGetResponse> GoodsInfoGetResponse {get;set;}
/// <summary>
/// 商品详情对象
/// </summary>
[JsonProperty("商品详情对象")]
public List<GoodsInfo> GoodsInfo {get;set;}
/// <summary>
/// 商品编码
/// </summary>
[JsonProperty("商品编码")]
public string GoodsId {get;set;}
/// <summary>
/// 商品序列编码
/// </summary>
[JsonProperty("商品序列编码")]
public string GoodsSn {get;set;}
/// <summary>
/// 商品类型，1-普通商品，2-进口商品，3-直供，4-直邮
/// </summary>
[JsonProperty("商品类型，1-普通商品，2-进口商品，3-直供，4-直邮")]
public int GoodsType {get;set;}
/// <summary>
/// 商品一级类目
/// </summary>
[JsonProperty("商品一级类目")]
public string GoodsCategory {get;set;}
/// <summary>
/// 叶子类目
/// </summary>
[JsonProperty("叶子类目")]
public string LastCategory {get;set;}
/// <summary>
/// 是否七天无理由售后，0-不支持，1-支持
/// </summary>
[JsonProperty("是否七天无理由售后，0-不支持，1-支持")]
public int IsRefundable {get;set;}
/// <summary>
/// 承诺发货时间
/// </summary>
[JsonProperty("承诺发货时间")]
public string ShipmentLimitSecond {get;set;}
/// <summary>
/// 商品名称
/// </summary>
[JsonProperty("商品名称")]
public string GoodsName {get;set;}
/// <summary>
/// 商品图片 url
/// </summary>
[JsonProperty("商品图片 url")]
public string ImageUrl {get;set;}
/// <summary>
/// 商品库存
/// </summary>
[JsonProperty("商品库存")]
public int GoodsQuantity {get;set;}
/// <summary>
/// 商品是否上架，0-下架，1-上架；
/// </summary>
[JsonProperty("商品是否上架，0-下架，1-上架；")]
public int IsOnsale {get;set;}
/// <summary>
/// 商品是否全新，0-全新商品，1-二手商品
/// </summary>
[JsonProperty("商品是否全新，0-全新商品，1-二手商品")]
public int SecondHand {get;set;}
/// <summary>
/// 成团人数
/// </summary>
[JsonProperty("成团人数")]
public int GroupRequiredCustomerNum {get;set;}
/// <summary>
/// sku列表对象
/// </summary>
[JsonProperty("sku列表对象")]
public List<SkuList> SkuList {get;set;}
/// <summary>
/// 商品规格名称
/// </summary>
[JsonProperty("商品规格名称")]
public string Spec {get;set;}
/// <summary>
/// 商品sku编码
/// </summary>
[JsonProperty("商品sku编码")]
public int SkuId {get;set;}
/// <summary>
/// 商品sku库存
/// </summary>
[JsonProperty("商品sku库存")]
public int SkuQuantity {get;set;}
/// <summary>
/// 商家外部编码（sku），同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。
/// </summary>
[JsonProperty("商家外部编码（sku），同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。")]
public string OuterId {get;set;}
/// <summary>
/// 商家外部编码（商品），同其他接口中的outer_goods_id 、out_goods_id、out_goods_sn、outer_goods_sn 都为商家编码（goods维度）。
/// </summary>
[JsonProperty("商家外部编码（商品），同其他接口中的outer_goods_id 、out_goods_id、out_goods_sn、outer_goods_sn 都为商家编码（goods维度）。")]
public string OuterGoodsId {get;set;}
/// <summary>
/// sku预览图
/// </summary>
[JsonProperty("sku预览图")]
public string SkuImg {get;set;}
/// <summary>
/// 拼团价格（元）
/// </summary>
[JsonProperty("拼团价格（元）")]
public int GroupPrice {get;set;}
/// <summary>
/// 单买价格（元）
/// </summary>
[JsonProperty("单买价格（元）")]
public int SinglePrice {get;set;}
/// <summary>
/// 商品sku是否上架，0-下架，1-上架
/// </summary>
[JsonProperty("商品sku是否上架，0-下架，1-上架")]
public int IsSkuOnsale {get;set;}
}
}

    public partial class GoodsInfoGetResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品详情对象
/// </summary>
[JsonProperty("商品详情对象")]
public List<GoodsInfo> GoodsInfo {get;set;}
}


    public partial class GoodsInfoResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品编码
/// </summary>
[JsonProperty("商品编码")]
public string GoodsId {get;set;}
/// <summary>
/// 商品序列编码
/// </summary>
[JsonProperty("商品序列编码")]
public string GoodsSn {get;set;}
/// <summary>
/// 商品类型，1-普通商品，2-进口商品，3-直供，4-直邮
/// </summary>
[JsonProperty("商品类型，1-普通商品，2-进口商品，3-直供，4-直邮")]
public int GoodsType {get;set;}
/// <summary>
/// 商品一级类目
/// </summary>
[JsonProperty("商品一级类目")]
public string GoodsCategory {get;set;}
/// <summary>
/// 叶子类目
/// </summary>
[JsonProperty("叶子类目")]
public string LastCategory {get;set;}
/// <summary>
/// 是否七天无理由售后，0-不支持，1-支持
/// </summary>
[JsonProperty("是否七天无理由售后，0-不支持，1-支持")]
public int IsRefundable {get;set;}
/// <summary>
/// 承诺发货时间
/// </summary>
[JsonProperty("承诺发货时间")]
public string ShipmentLimitSecond {get;set;}
/// <summary>
/// 商品名称
/// </summary>
[JsonProperty("商品名称")]
public string GoodsName {get;set;}
/// <summary>
/// 商品图片 url
/// </summary>
[JsonProperty("商品图片 url")]
public string ImageUrl {get;set;}
/// <summary>
/// 商品库存
/// </summary>
[JsonProperty("商品库存")]
public int GoodsQuantity {get;set;}
/// <summary>
/// 商品是否上架，0-下架，1-上架；
/// </summary>
[JsonProperty("商品是否上架，0-下架，1-上架；")]
public int IsOnsale {get;set;}
/// <summary>
/// 商品是否全新，0-全新商品，1-二手商品
/// </summary>
[JsonProperty("商品是否全新，0-全新商品，1-二手商品")]
public int SecondHand {get;set;}
/// <summary>
/// 成团人数
/// </summary>
[JsonProperty("成团人数")]
public int GroupRequiredCustomerNum {get;set;}
/// <summary>
/// sku列表对象
/// </summary>
[JsonProperty("sku列表对象")]
public List<SkuList> SkuList {get;set;}
}


    public partial class SkuListResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品规格名称
/// </summary>
[JsonProperty("商品规格名称")]
public string Spec {get;set;}
/// <summary>
/// 商品sku编码
/// </summary>
[JsonProperty("商品sku编码")]
public int SkuId {get;set;}
/// <summary>
/// 商品sku库存
/// </summary>
[JsonProperty("商品sku库存")]
public int SkuQuantity {get;set;}
/// <summary>
/// 商家外部编码（sku），同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。
/// </summary>
[JsonProperty("商家外部编码（sku），同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。")]
public string OuterId {get;set;}
/// <summary>
/// 商家外部编码（商品），同其他接口中的outer_goods_id 、out_goods_id、out_goods_sn、outer_goods_sn 都为商家编码（goods维度）。
/// </summary>
[JsonProperty("商家外部编码（商品），同其他接口中的outer_goods_id 、out_goods_id、out_goods_sn、outer_goods_sn 都为商家编码（goods维度）。")]
public string OuterGoodsId {get;set;}
/// <summary>
/// sku预览图
/// </summary>
[JsonProperty("sku预览图")]
public string SkuImg {get;set;}
/// <summary>
/// 拼团价格（元）
/// </summary>
[JsonProperty("拼团价格（元）")]
public int GroupPrice {get;set;}
/// <summary>
/// 单买价格（元）
/// </summary>
[JsonProperty("单买价格（元）")]
public int SinglePrice {get;set;}
/// <summary>
/// 商品sku是否上架，0-下架，1-上架
/// </summary>
[JsonProperty("商品sku是否上架，0-下架，1-上架")]
public int IsSkuOnsale {get;set;}
}


