using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Goods
{
public partial class GetGoodsSizespecTemplateRequestModel : PddRequestModel
{
/// <summary>
/// 尺码表id
/// </summary>
[JsonProperty("id")]
public long Id {get;set;}

}

}
