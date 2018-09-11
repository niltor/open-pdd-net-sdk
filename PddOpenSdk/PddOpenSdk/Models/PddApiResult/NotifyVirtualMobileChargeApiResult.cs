namespace App.Models.PddApiResult
{
    
public class MobileChargeNotifyResponse
{
    public bool success { get; set; }
}


public class NotifyVirtualMobileChargeApiResult
{
    public MobileChargeNotifyResponse mobile_charge_notify_response { get; set; }
}

}
