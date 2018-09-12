using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class CouponBatchList
{
    public long id { get; set; }
    public string batch_desc { get; set; }
    public int discount_param { get; set; }
    public int min_order_amount { get; set; }
    public int init_quantity { get; set; }
    public int remain_quantity { get; set; }
    public int used_quantity { get; set; }
    public int user_limit { get; set; }
    public long batch_start_time { get; set; }
    public long batch_end_time { get; set; }
    public int source_type { get; set; }
    public int goods_id { get; set; }
    public string goods_name { get; set; }
    public string image_url { get; set; }
    public int status { get; set; }
    public long created_at { get; set; }
}


public class GoodsCouponBatchListResponse
{
    public int total_size { get; set; }
    public List<CouponBatchList> coupon_batch_list { get; set; }
}


public class GetPromotionGoodsCouponListApiResult
{
    public GoodsCouponBatchListResponse goods_coupon_batch_list_response { get; set; }
}

}
