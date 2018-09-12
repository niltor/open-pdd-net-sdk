using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class Result
{
    public object receiver { get; set; }
    public string phone { get; set; }
    public long send_time { get; set; }
    public string content { get; set; }
    public int items_num { get; set; }
    public int words_num { get; set; }
    public int status { get; set; }
}


public class SmsSendRecordListQueryResponse
{
    public int total { get; set; }
    public List<Result> result { get; set; }
}


public class QuerySmsSendRecordListApiResult
{
    public SmsSendRecordListQueryResponse sms_send_record_list_query_response { get; set; }
}

}
