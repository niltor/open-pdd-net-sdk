using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ddkoauth
{
public partial class QueryDdkOauthFinanceCpaResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("finance_cpa_query_response")]
public FinanceCpaQueryResponseResponseModel FinanceCpaQueryResponse {get;set;}
public partial class FinanceCpaQueryResponseResponseModel : PddResponseModel
{
/// <summary>
/// CPA补贴并锁佣数量
/// </summary>
[JsonProperty("cpa_new_num")]
public int? CpaNewNum {get;set;}
/// <summary>
/// CPA锁佣数量
/// </summary>
[JsonProperty("cpa_old_num")]
public int? CpaOldNum {get;set;}
/// <summary>
/// 预估补贴，单位分
/// </summary>
[JsonProperty("subsidy_fee")]
public int? SubsidyFee {get;set;}
/// <summary>
/// 首单数
/// </summary>
[JsonProperty("order_num")]
public long? OrderNum {get;set;}

}

}

}
