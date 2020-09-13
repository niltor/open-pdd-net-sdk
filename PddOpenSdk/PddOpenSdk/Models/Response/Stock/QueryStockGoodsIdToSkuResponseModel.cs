using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Stock
{
public partial class QueryStockGoodsIdToSkuResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("open_api_response")]
public OpenApiResponseResponseModel OpenApiResponse {get;set;}
public partial class OpenApiResponseResponseModel : PddResponseModel
{
/// <summary>
/// 总数
/// </summary>
[JsonProperty("total")]
public int? Total {get;set;}
/// <summary>
/// sku信息
/// </summary>
[JsonProperty("skus")]
public List<SkusResponseModel> Skus {get;set;}
public partial class SkusResponseModel : PddResponseModel
{
/// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id")]
public long? GoodsId {get;set;}
/// <summary>
/// sku_id
/// </summary>
[JsonProperty("sku_id")]
public long? SkuId {get;set;}
/// <summary>
/// 货品id
/// </summary>
[JsonProperty("ware_id")]
public long? WareId {get;set;}
/// <summary>
/// 是否已经绑定货品false/true
/// </summary>
[JsonProperty("exist_ware")]
public bool? ExistWare {get;set;}
/// <summary>
/// 上下架状态，true表示上架，false表示下架
/// </summary>
[JsonProperty("is_onsale")]
public bool? IsOnsale {get;set;}
/// <summary>
/// 规格信息
/// </summary>
[JsonProperty("specs")]
public List<SpecsResponseModel> Specs {get;set;}
public partial class SpecsResponseModel : PddResponseModel
{
/// <summary>
/// 规格id
/// </summary>
[JsonProperty("spec_id")]
public long? SpecId {get;set;}
/// <summary>
/// 规格名称
/// </summary>
[JsonProperty("spec_key")]
public string SpecKey {get;set;}
/// <summary>
/// 规格值
/// </summary>
[JsonProperty("spec_value")]
public string SpecValue {get;set;}

}

}

}

}

}
