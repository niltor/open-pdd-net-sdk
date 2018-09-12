using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class AdMallRealTimeReportResponse
{
    public int ad_impr_num { get; set; }
    public int ad_clk_num { get; set; }
    public int spend { get; set; }
    public int pay_order_num { get; set; }
    public int pay_gmv { get; set; }
    public int roi { get; set; }
    public int click_rate { get; set; }
}


public class GetAdHistoryRtReportApiResult
{
    public AdMallRealTimeReportResponse ad_mall_real_time_report_response { get; set; }
}

}
