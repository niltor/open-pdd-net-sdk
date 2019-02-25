using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Goods
{
public partial class GetGoodsInformationRequestModel : PddRequestModel
{
/// <summary>
/// 商品编码
/// </summary>
[JsonProperty("goods_id")]
public long GoodsId {get;set;}

}

}
