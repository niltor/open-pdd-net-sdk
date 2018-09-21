using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetAdHistoryRtUnitReportResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回response
/// </summary>
[JsonProperty("ad_unit_real_time_report_response")]
public AdUnitRealTimeReportResponseResponseModel AdUnitRealTimeReportResponse {get;set;}

    public partial class AdUnitRealTimeReportResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 报表对象列表
/// </summary>
[JsonProperty("unit_real_time_report_list")]
public UnitRealTimeReportListResponseModel UnitRealTimeReportList {get;set;}

    public partial class UnitRealTimeReportListResponseModel : PddResponseModel
    {
        /// <summary>
/// 1：推广中，2：手动暂停，3：余额不足，4：到达日限额，5：无推广单元，6：已删除
/// </summary>
[JsonProperty("status")]
public int Status {get;set;}
/// <summary>
/// 计划id
/// </summary>
[JsonProperty("plan_id")]
public int PlanId {get;set;}
/// <summary>
/// 单元id
/// </summary>
[JsonProperty("unit_id")]
public int UnitId {get;set;}
/// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id")]
public int GoodsId {get;set;}
/// <summary>
/// 1：已启用，2：未启用
/// </summary>
[JsonProperty("operate_status")]
public int OperateStatus {get;set;}
/// <summary>
/// 商品名
/// </summary>
[JsonProperty("goods_name")]
public string GoodsName {get;set;}
/// <summary>
/// 商品图片url
/// </summary>
[JsonProperty("thumb_url")]
public string ThumbUrl {get;set;}
/// <summary>
/// 最小团购价
/// </summary>
[JsonProperty("min_group_price")]
public int MinGroupPrice {get;set;}
/// <summary>
/// 最大团购价
/// </summary>
[JsonProperty("max_group_price")]
public int MaxGroupPrice {get;set;}
/// <summary>
/// 广告投资回报率
/// </summary>
[JsonProperty("roi")]
public object Roi {get;set;}
/// <summary>
/// 千次展现成本
/// </summary>
[JsonProperty("cpm")]
public object Cpm {get;set;}
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
