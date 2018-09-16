using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetAdHistoryPlanReportResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回response
/// </summary>
[JsonProperty("ad_plan_history_report_get_response")]
public object AdPlanHistoryReportGetResponse {get;set;}
/// <summary>
/// 总数
/// </summary>
[JsonProperty("total")]
public int Total {get;set;}
/// <summary>
/// 计划report列表
/// </summary>
[JsonProperty("result")]
public object Result {get;set;}
/// <summary>
/// 扩展字段
/// </summary>
[JsonProperty("external_fields")]
public object ExternalFields {get;set;}
/// <summary>
/// 广告投资回报率
/// </summary>
[JsonProperty("roi")]
public object Roi {get;set;}
/// <summary>
/// 广告曝光数
/// </summary>
[JsonProperty("impression")]
public int Impression {get;set;}
/// <summary>
/// 广告点击数
/// </summary>
[JsonProperty("click")]
public int Click {get;set;}
/// <summary>
/// 广告点击率
/// </summary>
[JsonProperty("ctr")]
public object Ctr {get;set;}
/// <summary>
/// 广告消耗,单位厘
/// </summary>
[JsonProperty("spend")]
public int Spend {get;set;}
/// <summary>
/// 点击单价，单位厘
/// </summary>
[JsonProperty("cpc")]
public object Cpc {get;set;}
/// <summary>
/// 广告转化支付订单数
/// </summary>
[JsonProperty("orderNum")]
public int Ordernum {get;set;}
/// <summary>
/// 广告转化支付金额，单位厘
/// </summary>
[JsonProperty("gmv")]
public int Gmv {get;set;}
/// <summary>
/// 日期
/// </summary>
[JsonProperty("date")]
public object Date {get;set;}

    public partial class AdPlanHistoryReportGetResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 总数
/// </summary>
[JsonProperty("total")]
public int Total {get;set;}
/// <summary>
/// 计划report列表
/// </summary>
[JsonProperty("result")]
public object Result {get;set;}

}

    public partial class ResultResponseModel : PddResponseModel
    {
        /// <summary>
/// 扩展字段
/// </summary>
[JsonProperty("external_fields")]
public object ExternalFields {get;set;}
/// <summary>
/// 广告投资回报率
/// </summary>
[JsonProperty("roi")]
public object Roi {get;set;}
/// <summary>
/// 广告曝光数
/// </summary>
[JsonProperty("impression")]
public int Impression {get;set;}
/// <summary>
/// 广告点击数
/// </summary>
[JsonProperty("click")]
public int Click {get;set;}
/// <summary>
/// 广告点击率
/// </summary>
[JsonProperty("ctr")]
public object Ctr {get;set;}
/// <summary>
/// 广告消耗,单位厘
/// </summary>
[JsonProperty("spend")]
public int Spend {get;set;}
/// <summary>
/// 点击单价，单位厘
/// </summary>
[JsonProperty("cpc")]
public object Cpc {get;set;}
/// <summary>
/// 广告转化支付订单数
/// </summary>
[JsonProperty("orderNum")]
public int Ordernum {get;set;}
/// <summary>
/// 广告转化支付金额，单位厘
/// </summary>
[JsonProperty("gmv")]
public int Gmv {get;set;}
/// <summary>
/// 日期
/// </summary>
[JsonProperty("date")]
public object Date {get;set;}

}

}
}
