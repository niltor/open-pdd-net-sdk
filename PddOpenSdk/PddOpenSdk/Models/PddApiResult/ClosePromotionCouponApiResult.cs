namespace PddOpenSdk.Models.PddApiResult
{
    
public class PromotionCouponBatchCloseResponse
{
    public bool is_success { get; set; }
}


public class ClosePromotionCouponApiResult
{
    public PromotionCouponBatchCloseResponse promotion_coupon_batch_close_response { get; set; }
}

}
