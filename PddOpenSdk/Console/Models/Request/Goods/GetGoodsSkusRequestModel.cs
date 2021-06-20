using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Goods
{
public partial class GetGoodsSkusRequestModel : PddRequestModel
{
/// <summary>
/// 商品Id
/// </summary>
[JsonProperty("goods_id")]
public long GoodsId {get;set;}
/// <summary>
/// sku id
/// </summary>
[JsonProperty("sku_id")]
public long SkuId {get;set;}

}

}
