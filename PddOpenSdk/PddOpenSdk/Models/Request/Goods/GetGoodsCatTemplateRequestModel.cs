using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Goods
{
public partial class GetGoodsCatTemplateRequestModel : PddRequestModel
{
/// <summary>
/// 类目id
/// </summary>
[JsonProperty("cat_id")]
public long CatId {get;set;}

}

}
