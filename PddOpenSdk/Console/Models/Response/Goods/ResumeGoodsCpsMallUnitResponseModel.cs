using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Goods
{
public partial class ResumeGoodsCpsMallUnitResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("goods_cps_mall_unit_resume_response")]
public GoodsCpsMallUnitResumeResponseResponseModel GoodsCpsMallUnitResumeResponse {get;set;}
public partial class GoodsCpsMallUnitResumeResponseResponseModel : PddResponseModel
{
/// <summary>
/// 是否成功
/// </summary>
[JsonProperty("result")]
public bool? Result {get;set;}

}

}

}
