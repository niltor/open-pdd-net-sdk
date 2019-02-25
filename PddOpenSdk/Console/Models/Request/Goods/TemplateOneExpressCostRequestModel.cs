using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Goods
{
public partial class TemplateOneExpressCostRequestModel : PddRequestModel
{
/// <summary>
/// 运费模板id
/// </summary>
[JsonProperty("cost_template_id")]
public long CostTemplateId {get;set;}

}

}
