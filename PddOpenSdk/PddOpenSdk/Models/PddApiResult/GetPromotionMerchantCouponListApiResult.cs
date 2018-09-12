namespace PddOpenSdk.Models.PddApiResult
{
    
public class CouponBatchList
{
    public long id { get; set; }
    public string batch_name { get; set; }
    public string batch_desc { get; set; }
    public object discount_type { get; set; }
    public int discount_param { get; set; }
    public int init_quantity { get; set; }
    public int remain_quantity { get; set; }
    public int used_quantity { get; set; }
    public int user_limit { get; set; }
    public long max_discount_amount { get; set; }
    public int duration { get; set; }
    public int period_type { get; set; }
    public long batch_start_time { get; set; }
    public long batch_end_time { get; set; }
    public int source_type { get; set; }
    public int type { get; set; }
    public int status { get; set; }
    public string rules { get; set; }
    public int display_type { get; set; }
    public long created_at { get; set; }
}


public class MerchantCouponBatchListResponse
{
    public int total_size { get; set; }
    public List<CouponBatchList> coupon_batch_list { get; set; }
}


public class GetPromotionMerchantCouponListApiResult
{
    public MerchantCouponBatchListResponse merchant_coupon_batch_list_response { get; set; }
}

}
