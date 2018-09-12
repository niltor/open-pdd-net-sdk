namespace PddOpenSdk.Models.PddApiResult
{
    
public class Spec
{
    public int parent_id { get; set; }
    public string parent_name { get; set; }
    public int spec_id { get; set; }
    public string spec_name { get; set; }
}


public class SkuList
{
    public object sku_id { get; set; }
    public int is_onsale { get; set; }
    public int limit_quantity { get; set; }
    public int multi_price { get; set; }
    public int price { get; set; }
    public int quantity { get; set; }
    public int weight { get; set; }
    public string thumb_url { get; set; }
    public List<Spec> spec { get; set; }
    public string out_sku_sn { get; set; }
}


public class GoodsCommitDetailResponse
{
    public long goods_commit_id { get; set; }
    public int goods_status { get; set; }
    public object commit_message { get; set; }
    public int deleted { get; set; }
    public int goods_id { get; set; }
    public int buy_limit { get; set; }
    public List<string> carousel_gallery_list { get; set; }
    public int cat_id { get; set; }
    public int cost_template_id { get; set; }
    public int country_id { get; set; }
    public int customer_num { get; set; }
    public int goods_type { get; set; }
    public string goods_name { get; set; }
    public string goods_desc { get; set; }
    public string tiny_name { get; set; }
    public string warehouse { get; set; }
    public int is_customs { get; set; }
    public string customs { get; set; }
    public int market_price { get; set; }
    public int is_pre_sale { get; set; }
    public int pre_sale_time { get; set; }
    public int shipment_limit_second { get; set; }
    public int order_limit { get; set; }
    public int is_refundable { get; set; }
    public int is_folt { get; set; }
    public object fabric_id { get; set; }
    public object fabric_content_id { get; set; }
    public string warm_tips { get; set; }
    public List<SkuList> sku_list { get; set; }
    public string thumb_url { get; set; }
    public string hd_thumb_url { get; set; }
    public string image_url { get; set; }
    public List<string> detail_gallery_list { get; set; }
    public string outer_goods_id { get; set; }
    public object shelf_life { get; set; }
    public object start_production_date { get; set; }
    public object end_production_date { get; set; }
    public object production_license { get; set; }
    public object production_standard_number { get; set; }
    public int second_hand { get; set; }
    public object paper_net_weight { get; set; }
    public object paper_length { get; set; }
    public object paper_width { get; set; }
    public object paper_plies_num { get; set; }
}


public class GetGoodsCommitDetailApiResult
{
    public GoodsCommitDetailResponse goods_commit_detail_response { get; set; }
}

}
