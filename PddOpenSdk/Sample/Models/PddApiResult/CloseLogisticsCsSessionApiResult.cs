using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class LogisticsCsSessionCloseResponse
{
    public bool is_success { get; set; }
}


public class CloseLogisticsCsSessionApiResult
{
    public LogisticsCsSessionCloseResponse logistics_cs_session_close_response { get; set; }
}

}
