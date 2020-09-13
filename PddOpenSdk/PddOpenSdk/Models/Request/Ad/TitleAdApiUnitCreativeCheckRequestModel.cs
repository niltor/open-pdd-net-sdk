using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ad
{
public partial class TitleAdApiUnitCreativeCheckRequestModel : PddRequestModel
{
/// <summary>
/// 商品Id
/// </summary>
[JsonProperty("goodsId")]
public long GoodsId {get;set;}
/// <summary>
/// 创意标题
/// </summary>
[JsonProperty("title")]
public string Title {get;set;}

}

}
