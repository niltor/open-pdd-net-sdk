namespace PddOpenSdk.Models.PddApiResult
{
    
public class SmsRemainDetailQueryResponse
{
    public int remain_number { get; set; }
    public int remain_money { get; set; }
}


public class QuerySmsRemainDetailApiResult
{
    public SmsRemainDetailQueryResponse sms_remain_detail_query_response { get; set; }
}

}
