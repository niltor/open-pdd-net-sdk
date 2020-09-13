using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Stock
{
public partial class UpdateStockWareSkuRequestModel : PddRequestModel
{
/// <summary>
/// 货品id
/// </summary>
[JsonProperty("ware_id")]
public long WareId {get;set;}
/// <summary>
/// 组合货品中子货品的关联关系
/// </summary>
[JsonProperty("ware_skus")]
public List<WareSkusRequestModel> WareSkus {get;set;}
public partial class WareSkusRequestModel : PddRequestModel
{
/// <summary>
/// sku id
/// </summary>
[JsonProperty("sku_id")]
public long SkuId {get;set;}
/// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id")]
public long GoodsId {get;set;}

}

}

}
