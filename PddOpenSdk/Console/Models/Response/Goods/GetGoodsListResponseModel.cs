using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Goods
{
public partial class GetGoodsListResponseModel : PddResponseModel
{
/// <summary>
/// 商品列表响应对象
/// </summary>
[JsonProperty("goods_list_get_response")]
public GoodsListGetResponseResponseModel GoodsListGetResponse {get;set;}
public partial class GoodsListGetResponseResponseModel : PddResponseModel
{
/// <summary>
/// 返回商品总数
/// </summary>
[JsonProperty("total_count")]
public int? TotalCount {get;set;}
/// <summary>
/// 商品列表对象
/// </summary>
[JsonProperty("goods_list")]
public List<GoodsListResponseModel> GoodsList {get;set;}
public partial class GoodsListResponseModel : PddResponseModel
{
/// <summary>
/// 商品缩略图
/// </summary>
[JsonProperty("thumb_url")]
public string ThumbUrl {get;set;}
/// <summary>
/// 商品编码
/// </summary>
[JsonProperty("goods_id")]
public long? GoodsId {get;set;}
/// <summary>
/// 商品名称
/// </summary>
[JsonProperty("goods_name")]
public string GoodsName {get;set;}
/// <summary>
/// 商品图片
/// </summary>
[JsonProperty("image_url")]
public string ImageUrl {get;set;}
/// <summary>
/// 是否多sku，0-单sku，1-多sku
/// </summary>
[JsonProperty("is_more_sku")]
public int? IsMoreSku {get;set;}
/// <summary>
/// 商品总数量
/// </summary>
[JsonProperty("goods_quantity")]
public long? GoodsQuantity {get;set;}
/// <summary>
/// 是否在架上，0-下架中，1-架上
/// </summary>
[JsonProperty("is_onsale")]
public int? IsOnsale {get;set;}
/// <summary>
/// sku列表对象
/// </summary>
[JsonProperty("sku_list")]
public List<SkuListResponseModel> SkuList {get;set;}
/// <summary>
/// 商品预扣库存
/// </summary>
[JsonProperty("goods_reserve_quantity")]
public long? GoodsReserveQuantity {get;set;}
public partial class SkuListResponseModel : PddResponseModel
{
/// <summary>
/// 规格名称
/// </summary>
[JsonProperty("spec")]
public string Spec {get;set;}
/// <summary>
/// sku编码
/// </summary>
[JsonProperty("sku_id")]
public long? SkuId {get;set;}
/// <summary>
/// sku库存
/// </summary>
[JsonProperty("sku_quantity")]
public long? SkuQuantity {get;set;}
/// <summary>
/// 商家外部编码（sku），同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。
/// </summary>
[JsonProperty("outer_id")]
public string OuterId {get;set;}
/// <summary>
/// 商家外部编码（商品），同其他接口中的outer_goods_id 、out_goods_id、out_goods_sn、outer_goods_sn 都为商家编码（goods维度）。
/// </summary>
[JsonProperty("outer_goods_id")]
public string OuterGoodsId {get;set;}
/// <summary>
/// sku是否在架上，0-下架中，1-架上
/// </summary>
[JsonProperty("is_sku_onsale")]
public int? IsSkuOnsale {get;set;}
/// <summary>
/// sku预扣库存
/// </summary>
[JsonProperty("reserve_quantity")]
public long? ReserveQuantity {get;set;}

}

}

}

}

}
