namespace App.Models.PddApiResult
{
    
public class VoucherList
{
    public string card_no { get; set; }
    public string card_code { get; set; }
    public string mark_password { get; set; }
    public int status { get; set; }
    public int refund_status { get; set; }
    public int verification_at { get; set; }
}


public class VoucherVoucherInfoVerifyResponse
{
    public string order_sn { get; set; }
    public long goods_id { get; set; }
    public long sku_id { get; set; }
    public int mall_id { get; set; }
    public List<VoucherList> voucher_list { get; set; }
}


public class VerificationVoucherVirtualCardApiResult
{
    public VoucherVoucherInfoVerifyResponse voucher_voucher_info_verify_response { get; set; }
}

}
