using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ad
{
public partial class GetAdHistoryRtPlanReportResponseModel : PddResponseModel
{
/// <summary>
/// 返回response
/// </summary>
[JsonProperty("ad_plan_real_time_report_response")]
public AdPlanRealTimeReportResponseResponseModel AdPlanRealTimeReportResponse {get;set;}
public partial class AdPlanRealTimeReportResponseResponseModel : PddResponseModel
{
/// <summary>
/// 报表对象列表
/// </summary>
[JsonProperty("plan_real_time_report_list")]
public List<PlanRealTimeReportListResponseModel> PlanRealTimeReportList {get;set;}
public partial class PlanRealTimeReportListResponseModel : PddResponseModel
{
/// <summary>
/// 计划id
/// </summary>
[JsonProperty("plan_id")]
public long? PlanId {get;set;}
/// <summary>
/// 计划名
/// </summary>
[JsonProperty("plan_name")]
public string PlanName {get;set;}
/// <summary>
/// 计划日限额，单位厘
/// </summary>
[JsonProperty("max_cost")]
public long? MaxCost {get;set;}
/// <summary>
/// 1：已启用，2：未启用
/// </summary>
[JsonProperty("operate_status")]
public int? OperateStatus {get;set;}
/// <summary>
/// 1：余额充足，2：余额不足，3：超出消耗上限
/// </summary>
[JsonProperty("account_status")]
public int? AccountStatus {get;set;}
/// <summary>
/// 1：推广中，2：手动暂停，3：余额不足，4：到达日限额，5：无推广单元，6：已删除
/// </summary>
[JsonProperty("status")]
public int? Status {get;set;}
/// <summary>
/// 1：已删除，0：未删除
/// </summary>
[JsonProperty("is_deleted")]
public int? IsDeleted {get;set;}
/// <summary>
/// 推广单元数量
/// </summary>
[JsonProperty("ad_unit_num")]
public long? AdUnitNum {get;set;}
/// <summary>
/// 广告投资回报率
/// </summary>
[JsonProperty("roi")]
public double? Roi {get;set;}
/// <summary>
/// 广告曝光数
/// </summary>
[JsonProperty("impression")]
public long? Impression {get;set;}
/// <summary>
/// 广告点击数
/// </summary>
[JsonProperty("click")]
public long? Click {get;set;}
/// <summary>
/// 广告点击率
/// </summary>
[JsonProperty("ctr")]
public double? Ctr {get;set;}
/// <summary>
/// 广告消耗,单位厘
/// </summary>
[JsonProperty("spend")]
public long? Spend {get;set;}
/// <summary>
/// 点击单价，单位厘
/// </summary>
[JsonProperty("cpc")]
public double? Cpc {get;set;}
/// <summary>
/// 广告转化支付订单数
/// </summary>
[JsonProperty("order_num")]
public long? OrderNum {get;set;}
/// <summary>
/// 广告转化支付金额，单位厘
/// </summary>
[JsonProperty("gmv")]
public long? Gmv {get;set;}
/// <summary>
/// 日期
/// </summary>
[JsonProperty("date")]
public string Date {get;set;}

}

}

}

}
