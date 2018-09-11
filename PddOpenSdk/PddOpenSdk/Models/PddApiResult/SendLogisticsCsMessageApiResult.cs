namespace App.Models.PddApiResult
{
    
public class LogisticsCsMessageSendResponse
{
    public bool is_success { get; set; }
}


public class SendLogisticsCsMessageApiResult
{
    public LogisticsCsMessageSendResponse logistics_cs_message_send_response { get; set; }
}

}
