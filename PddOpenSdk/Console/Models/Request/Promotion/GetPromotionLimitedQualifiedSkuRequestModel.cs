using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Promotion
{
public partial class GetPromotionLimitedQualifiedSkuRequestModel : PddRequestModel
{
/// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id")]
public long GoodsId {get;set;}

}

}
