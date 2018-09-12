using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class GoodsCouponBatchCreateResponse
{
    public long batch_id { get; set; }
}


public class CreatePromotionGoodsCouponApiResult
{
    public GoodsCouponBatchCreateResponse goods_coupon_batch_create_response { get; set; }
}

}
