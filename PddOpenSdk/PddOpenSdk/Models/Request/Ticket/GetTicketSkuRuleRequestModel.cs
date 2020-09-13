using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ticket
{
public partial class GetTicketSkuRuleRequestModel : PddRequestModel
{
/// <summary>
/// 商户履约规则 id
/// </summary>
[JsonProperty("out_rule_id")]
public string OutRuleId {get;set;}
/// <summary>
/// 上传商品的上传序列 ID
/// </summary>
[JsonProperty("rule_id")]
public string RuleId {get;set;}

}

}
