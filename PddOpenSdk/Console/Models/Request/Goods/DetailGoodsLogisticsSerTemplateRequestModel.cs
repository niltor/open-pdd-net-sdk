using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Goods
{
public partial class DetailGoodsLogisticsSerTemplateRequestModel : PddRequestModel
{
/// <summary>
/// 模版id
/// </summary>
[JsonProperty("template_id")]
public string TemplateId {get;set;}

}

}
