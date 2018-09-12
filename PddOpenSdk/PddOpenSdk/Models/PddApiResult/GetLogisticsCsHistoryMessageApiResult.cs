namespace PddOpenSdk.Models.PddApiResult
{
    
public class MessageInfo
{
    public int id { get; set; }
    public string msg_ts { get; set; }
    public int from_type { get; set; }
    public string text { get; set; }
}


public class LogisticsCsHistoryMessageGetResponse
{
    public List<MessageInfo> message_infos { get; set; }
}


public class GetLogisticsCsHistoryMessageApiResult
{
    public LogisticsCsHistoryMessageGetResponse logistics_cs_history_message_get_response { get; set; }
}

}
