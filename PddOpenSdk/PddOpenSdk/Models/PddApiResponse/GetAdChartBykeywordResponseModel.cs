using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetAdChartBykeywordResponseModel : PddResponseModel
    {
        /// <summary>
/// 数据报表对象
/// </summary>
[JsonProperty("keyword_daily_report_list")]
public object KeywordDailyReportList {get;set;}

    public partial class KeywordDailyReportListResponseModel : PddResponseModel
    {
        
}

}
}
