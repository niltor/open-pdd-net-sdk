namespace App.Models.PddApiResult
{
    
public class CouponQuantityAddResponse
{
    public bool is_success { get; set; }
}


public class AddPromotionCouponQuantityApiResult
{
    public CouponQuantityAddResponse coupon_quantity_add_response { get; set; }
}

}
