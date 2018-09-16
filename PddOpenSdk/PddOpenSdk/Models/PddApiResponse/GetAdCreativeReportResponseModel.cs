using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetAdCreativeReportResponseModel : PddResponseModel
    {
        /// <summary>
/// ad_creative_report_get_response
/// </summary>
[JsonProperty("ad_creative_report_get_response")]
public object AdCreativeReportGetResponse {get;set;}
/// <summary>
/// 数量
/// </summary>
[JsonProperty("total")]
public object Total {get;set;}
/// <summary>
/// 结果
/// </summary>
[JsonProperty("result")]
public object Result {get;set;}
/// <summary>
/// 日期
/// </summary>
[JsonProperty("date")]
public object Date {get;set;}
/// <summary>
/// 商家id
/// </summary>
[JsonProperty("mall_id")]
public object MallId {get;set;}
/// <summary>
/// 计划编号
/// </summary>
[JsonProperty("plan_id")]
public object PlanId {get;set;}
/// <summary>
/// 计划名称
/// </summary>
[JsonProperty("plan_name")]
public object PlanName {get;set;}
/// <summary>
/// 单元id
/// </summary>
[JsonProperty("unit_id")]
public object UnitId {get;set;}
/// <summary>
/// 单元名称
/// </summary>
[JsonProperty("unit_name")]
public object UnitName {get;set;}
/// <summary>
/// 创意id
/// </summary>
[JsonProperty("creative_id")]
public object CreativeId {get;set;}
/// <summary>
/// 点位编号
/// </summary>
[JsonProperty("scene_info")]
public object SceneInfo {get;set;}
/// <summary>
/// 点位名称
/// </summary>
[JsonProperty("idx")]
public object Idx {get;set;}
/// <summary>
/// 展现量
/// </summary>
[JsonProperty("impr_num")]
public int ImprNum {get;set;}
/// <summary>
/// 点击量
/// </summary>
[JsonProperty("click_num")]
public int ClickNum {get;set;}
/// <summary>
/// 花费
/// </summary>
[JsonProperty("spend")]
public int Spend {get;set;}
/// <summary>
/// 成交订单数
/// </summary>
[JsonProperty("pay_order_num")]
public int PayOrderNum {get;set;}
/// <summary>
/// 成交订单金额
/// </summary>
[JsonProperty("pay_gmv")]
public int PayGmv {get;set;}
/// <summary>
/// CPT日消耗
/// </summary>
[JsonProperty("plan_cpt_spend")]
public int PlanCptSpend {get;set;}
/// <summary>
/// 跳转URL
/// </summary>
[JsonProperty("page_url")]
public object PageUrl {get;set;}
/// <summary>
/// 素材URL
/// </summary>
[JsonProperty("image_url")]
public object ImageUrl {get;set;}

    public partial class AdCreativeReportGetResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 数量
/// </summary>
[JsonProperty("total")]
public object Total {get;set;}
/// <summary>
/// 结果
/// </summary>
[JsonProperty("result")]
public object Result {get;set;}

}

    public partial class ResultResponseModel : PddResponseModel
    {
        /// <summary>
/// 日期
/// </summary>
[JsonProperty("date")]
public object Date {get;set;}
/// <summary>
/// 商家id
/// </summary>
[JsonProperty("mall_id")]
public object MallId {get;set;}
/// <summary>
/// 计划编号
/// </summary>
[JsonProperty("plan_id")]
public object PlanId {get;set;}
/// <summary>
/// 计划名称
/// </summary>
[JsonProperty("plan_name")]
public object PlanName {get;set;}
/// <summary>
/// 单元id
/// </summary>
[JsonProperty("unit_id")]
public object UnitId {get;set;}
/// <summary>
/// 单元名称
/// </summary>
[JsonProperty("unit_name")]
public object UnitName {get;set;}
/// <summary>
/// 创意id
/// </summary>
[JsonProperty("creative_id")]
public object CreativeId {get;set;}
/// <summary>
/// 点位编号
/// </summary>
[JsonProperty("scene_info")]
public object SceneInfo {get;set;}
/// <summary>
/// 点位名称
/// </summary>
[JsonProperty("idx")]
public object Idx {get;set;}
/// <summary>
/// 展现量
/// </summary>
[JsonProperty("impr_num")]
public int ImprNum {get;set;}
/// <summary>
/// 点击量
/// </summary>
[JsonProperty("click_num")]
public int ClickNum {get;set;}
/// <summary>
/// 花费
/// </summary>
[JsonProperty("spend")]
public int Spend {get;set;}
/// <summary>
/// 成交订单数
/// </summary>
[JsonProperty("pay_order_num")]
public int PayOrderNum {get;set;}
/// <summary>
/// 成交订单金额
/// </summary>
[JsonProperty("pay_gmv")]
public int PayGmv {get;set;}
/// <summary>
/// CPT日消耗
/// </summary>
[JsonProperty("plan_cpt_spend")]
public int PlanCptSpend {get;set;}
/// <summary>
/// 跳转URL
/// </summary>
[JsonProperty("page_url")]
public object PageUrl {get;set;}
/// <summary>
/// 素材URL
/// </summary>
[JsonProperty("image_url")]
public object ImageUrl {get;set;}

}

}
}
