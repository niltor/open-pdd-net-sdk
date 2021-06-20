using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ad
{
public partial class GetAdApiKeywordRelevanceRequestModel : PddRequestModel
{
/// <summary>
/// 商品Id
/// </summary>
[JsonProperty("goodsId")]
public long GoodsId {get;set;}
/// <summary>
/// 关键词数组
/// </summary>
[JsonProperty("words")]
public List<string> Words {get;set;}

}

}
