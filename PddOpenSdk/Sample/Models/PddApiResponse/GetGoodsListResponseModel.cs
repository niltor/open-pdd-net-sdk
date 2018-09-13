using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GetGoodsListResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品列表响应对象
/// </summary>
[JsonProperty("商品列表响应对象")]
public List<GoodsListGetResponse> GoodsListGetResponse {get;set;}
/// <summary>
/// 返回商品总数
/// </summary>
[JsonProperty("返回商品总数")]
public int TotalCount {get;set;}
/// <summary>
/// 商品列表对象
/// </summary>
[JsonProperty("商品列表对象")]
public List<GoodsList> GoodsList {get;set;}
/// <summary>
/// 商品缩略图
/// </summary>
[JsonProperty("商品缩略图")]
public string ThumbUrl {get;set;}
/// <summary>
/// 商品编码
/// </summary>
[JsonProperty("商品编码")]
public string GoodsId {get;set;}
/// <summary>
/// 商品名称
/// </summary>
[JsonProperty("商品名称")]
public string GoodsName {get;set;}
/// <summary>
/// 商品图片
/// </summary>
[JsonProperty("商品图片")]
public string ImageUrl {get;set;}
/// <summary>
/// 是否多sku，0-单sku，1-多sku
/// </summary>
[JsonProperty("是否多sku，0-单sku，1-多sku")]
public int IsMoreSku {get;set;}
/// <summary>
/// 商品总数量
/// </summary>
[JsonProperty("商品总数量")]
public int GoodsQuantity {get;set;}
/// <summary>
/// 是否在架上，0-下架中，1-架上
/// </summary>
[JsonProperty("是否在架上，0-下架中，1-架上")]
public int IsOnsale {get;set;}
/// <summary>
/// sku列表对象
/// </summary>
[JsonProperty("sku列表对象")]
public List<SkuList> SkuList {get;set;}
/// <summary>
/// 规格名称
/// </summary>
[JsonProperty("规格名称")]
public string Spec {get;set;}
/// <summary>
/// sku编码
/// </summary>
[JsonProperty("sku编码")]
public int SkuId {get;set;}
/// <summary>
/// sku库存
/// </summary>
[JsonProperty("sku库存")]
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
/// sku是否在架上，0-下架中，1-架上
/// </summary>
[JsonProperty("sku是否在架上，0-下架中，1-架上")]
public int IsSkuOnsale {get;set;}
}
}

    public partial class GoodsListGetResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回商品总数
/// </summary>
[JsonProperty("返回商品总数")]
public int TotalCount {get;set;}
/// <summary>
/// 商品列表对象
/// </summary>
[JsonProperty("商品列表对象")]
public List<GoodsList> GoodsList {get;set;}
}


    public partial class GoodsListResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品缩略图
/// </summary>
[JsonProperty("商品缩略图")]
public string ThumbUrl {get;set;}
/// <summary>
/// 商品编码
/// </summary>
[JsonProperty("商品编码")]
public string GoodsId {get;set;}
/// <summary>
/// 商品名称
/// </summary>
[JsonProperty("商品名称")]
public string GoodsName {get;set;}
/// <summary>
/// 商品图片
/// </summary>
[JsonProperty("商品图片")]
public string ImageUrl {get;set;}
/// <summary>
/// 是否多sku，0-单sku，1-多sku
/// </summary>
[JsonProperty("是否多sku，0-单sku，1-多sku")]
public int IsMoreSku {get;set;}
/// <summary>
/// 商品总数量
/// </summary>
[JsonProperty("商品总数量")]
public int GoodsQuantity {get;set;}
/// <summary>
/// 是否在架上，0-下架中，1-架上
/// </summary>
[JsonProperty("是否在架上，0-下架中，1-架上")]
public int IsOnsale {get;set;}
/// <summary>
/// sku列表对象
/// </summary>
[JsonProperty("sku列表对象")]
public List<SkuList> SkuList {get;set;}
}


    public partial class SkuListResponseModel : PddResponseModel
    {
        /// <summary>
/// 规格名称
/// </summary>
[JsonProperty("规格名称")]
public string Spec {get;set;}
/// <summary>
/// sku编码
/// </summary>
[JsonProperty("sku编码")]
public int SkuId {get;set;}
/// <summary>
/// sku库存
/// </summary>
[JsonProperty("sku库存")]
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
/// sku是否在架上，0-下架中，1-架上
/// </summary>
[JsonProperty("sku是否在架上，0-下架中，1-架上")]
public int IsSkuOnsale {get;set;}
}


