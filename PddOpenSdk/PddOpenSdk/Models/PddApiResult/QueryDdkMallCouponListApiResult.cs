namespace PddOpenSdk.Models.PddApiResult
{
    
public class MallInfoList
{
    public int mall_id { get; set; }
    public string mall_name { get; set; }
    public int merchant_type { get; set; }
    public List<int> cat_id_list { get; set; }
    public int mall_rate { get; set; }
    public long coupon_id { get; set; }
    public int coupon_type { get; set; }
    public int discount { get; set; }
    public int min_order_amount { get; set; }
    public long max_discount_amount { get; set; }
    public int coupon_quantity { get; set; }
    public int coupon_remain_quantity { get; set; }
    public int coupon_start_time { get; set; }
    public int coupon_end_time { get; set; }
}


public class MallCouponQueryInfoListResponse
{
    public List<MallInfoList> mall_info_list { get; set; }
    public int total { get; set; }
}


public class QueryDdkMallCouponListApiResult
{
    public MallCouponQueryInfoListResponse mall_coupon_query_info_list_response { get; set; }
}

}
