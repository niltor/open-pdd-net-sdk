namespace App.Models.PddApiResult
{
    
public class VoucherPhysicalVoucherSendResponse
{
    public bool is_success { get; set; }
}


public class SendVoucherPhysicalGoodsApiResult
{
    public VoucherPhysicalVoucherSendResponse voucher_physical_voucher_send_response { get; set; }
}

}
