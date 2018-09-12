namespace PddOpenSdk.Models.PddApiResult
{
    
public class GoodsList
{
    public object create_at { get; set; }
    public int goods_id { get; set; }
    public string goods_name { get; set; }
    public object goods_desc { get; set; }
    public string goods_thumbnail_url { get; set; }
    public string goods_image_url { get; set; }
    public object goods_gallery_urls { get; set; }
    public int sold_quantity { get; set; }
    public int goods_mark_price { get; set; }
    public int goods_fact_price { get; set; }
    public int min_group_price { get; set; }
    public int min_normal_price { get; set; }
    public int mall_id { get; set; }
    public string mall_name { get; set; }
    public int merchant_type { get; set; }
    public int category_id { get; set; }
    public string category_name { get; set; }
    public int opt_id { get; set; }
    public string opt_name { get; set; }
    public List<int> opt_ids { get; set; }
    public object cat_ids { get; set; }
    public int goods_type { get; set; }
    public bool has_coupon { get; set; }
    public object coupon_id { get; set; }
    public int coupon_min_order_amount { get; set; }
    public int coupon_discount { get; set; }
    public object coupon_total_quantity { get; set; }
    public object coupon_remain_quantity { get; set; }
    public object coupon_start_time { get; set; }
    public object coupon_end_time { get; set; }
    public int promotion_rate { get; set; }
    public int coupon_price { get; set; }
    public int goods_rate { get; set; }
    public int market_fee { get; set; }
    public int mall_cps { get; set; }
    public int goods_eval_score { get; set; }
    public int goods_eval_count { get; set; }
    public object cat_id { get; set; }
    public object share_desc { get; set; }
    public object avg_desc { get; set; }
    public object avg_lgst { get; set; }
    public object avg_serv { get; set; }
    public object desc_pct { get; set; }
    public object lgst_pct { get; set; }
    public object serv_pct { get; set; }
    public int sale_num24 { get; set; }
    public object sale_num_today { get; set; }
    public object rank { get; set; }
    public object broker { get; set; }
    public object lock_edit { get; set; }
    public object qr_code_image_url { get; set; }
    public int mall_rate { get; set; }
}


public class GoodsInfoListResponse
{
    public int total { get; set; }
    public List<GoodsList> goods_list { get; set; }
}


public class GetDdkMallGoodsListApiResult
{
    public GoodsInfoListResponse goods_info_list_response { get; set; }
}

}
