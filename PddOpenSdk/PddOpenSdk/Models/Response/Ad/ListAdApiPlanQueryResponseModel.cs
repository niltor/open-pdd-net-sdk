using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ad
{
public partial class ListAdApiPlanQueryResponseModel : PddResponseModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("response")]
public ResponseResponseModel Response {get;set;}
public partial class ResponseResponseModel : PddResponseModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("errorCode")]
public int? ErrorCode {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("errorMsg")]
public string ErrorMsg {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("result")]
public List<ResultResponseModel> Result {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("success")]
public bool? Success {get;set;}
public partial class ResultResponseModel : PddResponseModel
{
/// <summary>
/// 计划日限额今日剩余可修改次数。一个计划一天可修改五次日限额。
/// </summary>
[JsonProperty("availableBudgetChangeNumberToday")]
public int? AvailableBudgetChangeNumberToday {get;set;}
/// <summary>
/// 每笔成交金额(average pay amount)，单位厘
/// </summary>
[JsonProperty("avgPayAmount")]
public double? AvgPayAmount {get;set;}
/// <summary>
/// 计划日限额今日已修改次数
/// </summary>
[JsonProperty("budgetChangedNumberToday")]
public int? BudgetChangedNumberToday {get;set;}
/// <summary>
/// 广告点击量
/// </summary>
[JsonProperty("click")]
public long? Click {get;set;}
/// <summary>
/// 平均点击花费，单位厘
/// </summary>
[JsonProperty("cpc")]
public double? Cpc {get;set;}
/// <summary>
/// 千次展现成本
/// </summary>
[JsonProperty("cpm")]
public double? Cpm {get;set;}
/// <summary>
/// 广告点击率
/// </summary>
[JsonProperty("ctr")]
public double? Ctr {get;set;}
/// <summary>
/// 点击转化率
/// </summary>
[JsonProperty("cvr")]
public double? Cvr {get;set;}
/// <summary>
/// 分时折扣比例。千分比。
/// </summary>
[JsonProperty("discountRate")]
public int? DiscountRate {get;set;}
/// <summary>
/// 广告转化支付金额，单位厘
/// </summary>
[JsonProperty("gmv")]
public long? Gmv {get;set;}
/// <summary>
/// 商品收藏数
/// </summary>
[JsonProperty("goodsFavNum")]
public long? GoodsFavNum {get;set;}
/// <summary>
/// 广告曝光量
/// </summary>
[JsonProperty("impression")]
public long? Impression {get;set;}
/// <summary>
/// 店铺收藏数
/// </summary>
[JsonProperty("mallFavNum")]
public long? MallFavNum {get;set;}
/// <summary>
/// 日消耗上限。单位厘
/// </summary>
[JsonProperty("maxCost")]
public long? MaxCost {get;set;}
/// <summary>
/// 广告主账户状态。1表示余额充足，2表示余额不足，3表示超出消耗上限。
/// </summary>
[JsonProperty("merchantAccountStatus")]
public int? MerchantAccountStatus {get;set;}
/// <summary>
/// 操作状态。1表示开启，2表示暂停。
/// </summary>
[JsonProperty("merchantOperateStatus")]
public int? MerchantOperateStatus {get;set;}
/// <summary>
/// 广告转化支付订单量
/// </summary>
[JsonProperty("orderNum")]
public long? OrderNum {get;set;}
/// <summary>
/// 计划ID
/// </summary>
[JsonProperty("planId")]
public long? PlanId {get;set;}
/// <summary>
/// 计划名称
/// </summary>
[JsonProperty("planName")]
public string PlanName {get;set;}
/// <summary>
/// 推广策略。1表示自定义推广，2表示智能推广。
/// </summary>
[JsonProperty("planStrategy")]
public int? PlanStrategy {get;set;}
/// <summary>
/// 广告惩罚原因
/// </summary>
[JsonProperty("punishReason")]
public string PunishReason {get;set;}
/// <summary>
/// 广告投入产出比
/// </summary>
[JsonProperty("roi")]
public double? Roi {get;set;}
/// <summary>
/// 广告消耗,单位厘
/// </summary>
[JsonProperty("spend")]
public long? Spend {get;set;}
/// <summary>
/// 单元状态。1表示推广中，2表示手动暂停，3表示余额不足，4表示到达日限额，5表示无推广中单元，6表示已删除，7表示系统暂停-投放已结束，8表示系统暂停-投放未开始，9表示不在投放时段，10表示待确认推广单，11表示推广费用待锁定，12表示合约已失效，13表示限制推广，14表示部分推广中，15表示店铺限制推广。
/// </summary>
[JsonProperty("status")]
public int? Status {get;set;}
/// <summary>
/// 转化成本
/// </summary>
[JsonProperty("transactionCost")]
public double? TransactionCost {get;set;}
/// <summary>
/// 计划下的单元数量
/// </summary>
[JsonProperty("unitNum")]
public int? UnitNum {get;set;}

}

}

}

}
