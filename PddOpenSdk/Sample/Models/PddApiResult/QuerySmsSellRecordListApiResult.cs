using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class Result
{
    public int id { get; set; }
    public string name { get; set; }
    public int scene { get; set; }
    public long send_time { get; set; }
    public int status { get; set; }
    public int send_num { get; set; }
    public int send_failed_num { get; set; }
    public int open { get; set; }
}


public class SmsSellRecordListQueryResponse
{
    public int total { get; set; }
    public List<Result> result { get; set; }
}


public class QuerySmsSellRecordListApiResult
{
    public SmsSellRecordListQueryResponse sms_sell_record_list_query_response { get; set; }
}

}
