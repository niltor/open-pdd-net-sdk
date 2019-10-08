using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Goods
{
public partial class ChangeGoodsCpsMallUnitRequestModel : PddRequestModel
{
/// <summary>
/// 全店推广计划佣金比（千分比）
/// </summary>
[JsonProperty("rate")]
public int? Rate {get;set;}

}

}
