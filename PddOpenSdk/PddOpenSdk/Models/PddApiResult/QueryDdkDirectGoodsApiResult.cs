namespace PddOpenSdk.Models.PddApiResult
{
    
public class List
{
    public int goods_id { get; set; }
    public string goods_name { get; set; }
    public object goods_desc { get; set; }
    public string goods_thumbnail_url { get; set; }
    public string goods_image_url { get; set; }
    public object goods_gallery_urls { get; set; }
    public int sold_quantity { get; set; }
    public int goods_fact_price { get; set; }
    public int min_group_price { get; set; }
    public int min_normal_price { get; set; }
    public string mall_name { get; set; }
    public int category_id { get; set; }
    public string category_name { get; set; }
    public int opt_id { get; set; }
    public string opt_name { get; set; }
    public List<int> cat_ids { get; set; }
    public bool has_coupon { get; set; }
    public int coupon_id { get; set; }
    public int coupon_min_order_amount { get; set; }
    public int coupon_discount { get; set; }
    public int coupon_total_quantity { get; set; }
    public int coupon_remain_quantity { get; set; }
    public int coupon_start_time { get; set; }
    public int coupon_end_time { get; set; }
    public int promotion_rate { get; set; }
    public int coupon_price { get; set; }
    public int goods_rate { get; set; }
    public double goods_eval_score { get; set; }
    public int goods_eval_count { get; set; }
    public object cat_id { get; set; }
    public int avg_desc { get; set; }
    public int avg_lgst { get; set; }
    public int avg_serv { get; set; }
    public object sale_num24 { get; set; }
}


public class DirectGoodsQueryResponse
{
    public List<List> list { get; set; }
    public int total_count { get; set; }
}


public class QueryDdkDirectGoodsApiResult
{
    public DirectGoodsQueryResponse direct_goods_query_response { get; set; }
}

}
