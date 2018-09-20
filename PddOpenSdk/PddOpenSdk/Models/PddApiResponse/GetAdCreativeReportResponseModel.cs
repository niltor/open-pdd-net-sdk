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
public AdCreativeReportGetResponseResponseModel AdCreativeReportGetResponse {get;set;}

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
public ResultResponseModel Result {get;set;}

    public partial class ResultResponseModel : PddResponseModel
    {
        /// <summary>
/// 日期
/// </summary>
[JsonProperty("date")]
public string Date {get;set;}
/// <summary>
/// 商家id
/// </summary>
[JsonProperty("mall_id")]
public string MallId {get;set;}
/// <summary>
/// 计划编号
/// </summary>
[JsonProperty("plan_id")]
public string PlanId {get;set;}
/// <summary>
/// 计划名称
/// </summary>
[JsonProperty("plan_name")]
public string PlanName {get;set;}
/// <summary>
/// 单元id
/// </summary>
[JsonProperty("unit_id")]
public string UnitId {get;set;}
/// <summary>
/// 单元名称
/// </summary>
[JsonProperty("unit_name")]
public string UnitName {get;set;}
/// <summary>
/// 创意id
/// </summary>
[JsonProperty("creative_id")]
public string CreativeId {get;set;}
/// <summary>
/// 点位编号
/// </summary>
[JsonProperty("scene_info")]
public string SceneInfo {get;set;}
/// <summary>
/// 点位名称
/// </summary>
[JsonProperty("idx")]
public string Idx {get;set;}
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
public string PageUrl {get;set;}
/// <summary>
/// 素材URL
/// </summary>
[JsonProperty("image_url")]
public string ImageUrl {get;set;}

}

}

}
}
