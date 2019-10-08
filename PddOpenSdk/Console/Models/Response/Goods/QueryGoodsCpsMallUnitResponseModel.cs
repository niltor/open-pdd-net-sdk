using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Goods
{
public partial class QueryGoodsCpsMallUnitResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("goods_cps_mall_unit_query_response")]
public GoodsCpsMallUnitQueryResponseResponseModel GoodsCpsMallUnitQueryResponse {get;set;}
public partial class GoodsCpsMallUnitQueryResponseResponseModel : PddResponseModel
{
/// <summary>
/// 全店推广计划佣金比（千分比）
/// </summary>
[JsonProperty("rate")]
public int? Rate {get;set;}
/// <summary>
/// 修改后生效的佣金费率（千分比）
/// </summary>
[JsonProperty("rate_to_be")]
public int? RateToBe {get;set;}
/// <summary>
/// 全店推广计划状态：1-推广中，2-暂停推广
/// </summary>
[JsonProperty("status")]
public int? Status {get;set;}
/// <summary>
/// 修改后生效的状态，1-推广中，2-暂停，3-删除
/// </summary>
[JsonProperty("status_to_be")]
public string StatusToBe {get;set;}
/// <summary>
/// 全店推广计划佣金生效时间
/// </summary>
[JsonProperty("rate_to_be_day")]
public string RateToBeDay {get;set;}
/// <summary>
/// 全店推广计划状态生效时间
/// </summary>
[JsonProperty("status_to_be_day")]
public string StatusToBeDay {get;set;}

}

}

}
