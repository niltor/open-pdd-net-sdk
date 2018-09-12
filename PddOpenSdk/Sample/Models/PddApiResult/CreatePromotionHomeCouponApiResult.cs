using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class HomeCouponBatchCreateResponse
{
    public long batch_id { get; set; }
}


public class CreatePromotionHomeCouponApiResult
{
    public HomeCouponBatchCreateResponse home_coupon_batch_create_response { get; set; }
}

}
