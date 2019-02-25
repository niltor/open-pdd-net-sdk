using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Goods
{
public partial class CreateGoodsCpsMallUnitRequestModel : PddRequestModel
{
/// <summary>
/// 佣金比（千分比）
/// </summary>
[JsonProperty("rate")]
public long Rate {get;set;}
/// <summary>
/// 合作方code
/// </summary>
[JsonProperty("erp_code")]
public string ErpCode {get;set;}

}

}
