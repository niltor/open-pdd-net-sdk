using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Goods
{
public partial class DeleteGoodsSizespecTemplateRequestModel : PddRequestModel
{
/// <summary>
/// 尺码表模板id
/// </summary>
[JsonProperty("id")]
public long Id {get;set;}

}

}
