using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class SettingAndCrowdReturnVo
{
    public int id { get; set; }
    public string name { get; set; }
    public int people_num { get; set; }
    public long send_time { get; set; }
}


public class SmsShortMsgStatisticQueryResponse
{
    public SettingAndCrowdReturnVo setting_and_crowd_return_vo { get; set; }
    public object statistic_vo { get; set; }
}


public class QuerySmsShortStatisticApiResult
{
    public SmsShortMsgStatisticQueryResponse sms_short_msg_statistic_query_response { get; set; }
}

}
