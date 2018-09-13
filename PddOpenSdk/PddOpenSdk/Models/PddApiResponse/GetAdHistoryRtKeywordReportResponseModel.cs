using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GetAdHistoryRtKeywordReportResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回response
/// </summary>
[JsonProperty("ad_keyword_real_time_report_response")]
public object AdKeywordRealTimeReportResponse {get;set;}
/// <summary>
/// report列表
/// </summary>
[JsonProperty("keyword_real_time_report_list")]
public object KeywordRealTimeReportList {get;set;}
/// <summary>
/// 关键词id
/// </summary>
[JsonProperty("keyword_id")]
public int KeywordId {get;set;}
/// <summary>
/// 关键词
/// </summary>
[JsonProperty("word")]
public object Word {get;set;}
/// <summary>
/// 出价
/// </summary>
[JsonProperty("bid")]
public int Bid {get;set;}
/// <summary>
/// 关键词状态 1-推广中 2-已删除
/// </summary>
[JsonProperty("impression_status")]
public int ImpressionStatus {get;set;}
/// <summary>
/// 质量分
/// </summary>
[JsonProperty("quality_score")]
public int QualityScore {get;set;}
/// <summary>
/// 1：推广中，2：手动暂停，3：余额不足，4：到达日限额，5：无推广单元，6：已删除
/// </summary>
[JsonProperty("status")]
public int Status {get;set;}
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
public object Date {get;set;}

    public partial class AdKeywordRealTimeReportResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// report列表
/// </summary>
[JsonProperty("keyword_real_time_report_list")]
public object KeywordRealTimeReportList {get;set;}

}

    public partial class KeywordRealTimeReportListResponseModel : PddResponseModel
    {
        /// <summary>
/// 关键词id
/// </summary>
[JsonProperty("keyword_id")]
public int KeywordId {get;set;}
/// <summary>
/// 关键词
/// </summary>
[JsonProperty("word")]
public object Word {get;set;}
/// <summary>
/// 出价
/// </summary>
[JsonProperty("bid")]
public int Bid {get;set;}
/// <summary>
/// 关键词状态 1-推广中 2-已删除
/// </summary>
[JsonProperty("impression_status")]
public int ImpressionStatus {get;set;}
/// <summary>
/// 质量分
/// </summary>
[JsonProperty("quality_score")]
public int QualityScore {get;set;}
/// <summary>
/// 1：推广中，2：手动暂停，3：余额不足，4：到达日限额，5：无推广单元，6：已删除
/// </summary>
[JsonProperty("status")]
public int Status {get;set;}
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
public object Date {get;set;}

}

}
}
