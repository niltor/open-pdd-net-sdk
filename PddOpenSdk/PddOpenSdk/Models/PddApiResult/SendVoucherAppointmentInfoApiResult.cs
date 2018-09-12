namespace PddOpenSdk.Models.PddApiResult
{
    
public class VoucherAppointmentInfoSendResponse
{
    public bool is_success { get; set; }
}


public class SendVoucherAppointmentInfoApiResult
{
    public VoucherAppointmentInfoSendResponse voucher_appointment_info_send_response { get; set; }
}

}
