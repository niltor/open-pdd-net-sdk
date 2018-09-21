using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
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
public PlanRealTimeReportListResponseModel PlanRealTimeReportList {get;set;}

    public partial class PlanRealTimeReportListResponseModel : PddResponseModel
    {
        /// <summary>
/// 计划id
/// </summary>
[JsonProperty("plan_id")]
public int PlanId {get;set;}
/// <summary>
/// 计划名
/// </summary>
[JsonProperty("plan_name")]
public string PlanName {get;set;}
/// <summary>
/// 计划日限额，单位厘
/// </summary>
[JsonProperty("max_cost")]
public int MaxCost {get;set;}
/// <summary>
/// 1：已启用，2：未启用
/// </summary>
[JsonProperty("operate_status")]
public int OperateStatus {get;set;}
/// <summary>
/// 1：余额充足，2：余额不足，3：超出消耗上限
/// </summary>
[JsonProperty("account_status")]
public int AccountStatus {get;set;}
/// <summary>
/// 1：推广中，2：手动暂停，3：余额不足，4：到达日限额，5：无推广单元，6：已删除
/// </summary>
[JsonProperty("status")]
public int Status {get;set;}
/// <summary>
/// 1：已删除，0：未删除
/// </summary>
[JsonProperty("is_deleted")]
public int IsDeleted {get;set;}
/// <summary>
/// 推广单元数量
/// </summary>
[JsonProperty("ad_unit_num")]
public object AdUnitNum {get;set;}
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
public string Date {get;set;}

}

}

}
}
