using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetAdHistoryReportResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回response
/// </summary>
[JsonProperty("ad_mall_history_report_response")]
public AdMallHistoryReportResponseResponseModel AdMallHistoryReportResponse {get;set;}

    public partial class AdMallHistoryReportResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 历史report列表
/// </summary>
[JsonProperty("mall_history_report_list")]
public MallHistoryReportListResponseModel MallHistoryReportList {get;set;}

    public partial class MallHistoryReportListResponseModel : PddResponseModel
    {
        /// <summary>
/// 广告投资回报率
/// </summary>
[JsonProperty("roi")]
public double Roi {get;set;}
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
public double Ctr {get;set;}
/// <summary>
/// 广告消耗,单位厘
/// </summary>
[JsonProperty("spend")]
public int Spend {get;set;}
/// <summary>
/// 点击单价，单位厘
/// </summary>
[JsonProperty("cpc")]
public double Cpc {get;set;}
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
