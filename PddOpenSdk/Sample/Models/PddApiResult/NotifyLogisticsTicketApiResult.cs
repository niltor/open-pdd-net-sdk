using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class LogisticsTicketNotifyResponse
{
    public bool is_success { get; set; }
}


public class NotifyLogisticsTicketApiResult
{
    public LogisticsTicketNotifyResponse logistics_ticket_notify_response { get; set; }
}

}
