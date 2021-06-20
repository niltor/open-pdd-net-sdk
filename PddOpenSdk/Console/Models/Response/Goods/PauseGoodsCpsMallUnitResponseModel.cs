using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Goods
{
public partial class PauseGoodsCpsMallUnitResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("goods_cps_mall_unit_pause_response")]
public GoodsCpsMallUnitPauseResponseResponseModel GoodsCpsMallUnitPauseResponse {get;set;}
public partial class GoodsCpsMallUnitPauseResponseResponseModel : PddResponseModel
{
/// <summary>
/// 是否成功
/// </summary>
[JsonProperty("result")]
public bool? Result {get;set;}

}

}

}
