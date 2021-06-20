using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ad
{
public partial class CostAdApiPlanQueryCanUpdateMaxRequestModel : PddRequestModel
{
/// <summary>
/// 广告计划Id
/// </summary>
[JsonProperty("planId")]
public long PlanId {get;set;}

}

}
