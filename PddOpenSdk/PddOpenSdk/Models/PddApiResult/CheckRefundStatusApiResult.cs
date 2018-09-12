namespace PddOpenSdk.Models.PddApiResult
{
    
public class OrderSnsExistsRefund
{
    public string order_sn { get; set; }
}


public class RefundStatusCheckResponse
{
    public List<OrderSnsExistsRefund> order_sns_exists_refund { get; set; }
}


public class CheckRefundStatusApiResult
{
    public RefundStatusCheckResponse refund_status_check_response { get; set; }
}

}
