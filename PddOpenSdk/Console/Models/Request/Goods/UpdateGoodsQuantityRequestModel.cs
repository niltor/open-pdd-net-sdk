using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Goods
{
public partial class UpdateGoodsQuantityRequestModel : PddRequestModel
{
/// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id")]
public long GoodsId {get;set;}
/// <summary>
/// 库存修改值。当全量更新库存时，quantity必须为大于等于0的正整数；当增量更新库存时，quantity为整数，可小于等于0。若增量更新时传入的库存为负数，则负数与实际库存之和不能小于0。比如当前实际库存为1，传入增量更新quantity=-1，库存改为0
/// </summary>
[JsonProperty("quantity")]
public long Quantity {get;set;}
/// <summary>
/// sku_id和outer_id必填一个，优先使用sku_id
/// </summary>
[JsonProperty("sku_id")]
public long? SkuId {get;set;}
/// <summary>
/// sku商家编码，如果sku_id未填，则使用outer_id
/// </summary>
[JsonProperty("outer_id")]
public string OuterId {get;set;}
/// <summary>
/// 库存更新方式，可选。1为全量更新，2为增量更新。如果不填，默认为全量更新
/// </summary>
[JsonProperty("update_type")]
public int? UpdateType {get;set;}

}

}
