using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Goods
{
public partial class GetGoodsFileInfoRequestModel : PddRequestModel
{
/// <summary>
/// url列表
/// </summary>
[JsonProperty("url_list")]
public List<string> UrlList {get;set;}

}

}
