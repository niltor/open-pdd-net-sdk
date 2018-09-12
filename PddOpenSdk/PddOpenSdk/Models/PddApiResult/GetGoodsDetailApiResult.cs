namespace PddOpenSdk.Models.PddApiResult
{
    
public class SkuList
{
    public int sku_id { get; set; }
    public int is_onsale { get; set; }
    public int limit_quantity { get; set; }
    public int multi_price { get; set; }
    public int price { get; set; }
    public int quantity { get; set; }
    public int weight { get; set; }
    public string thumb_url { get; set; }
    public List<object> spec { get; set; }
    public string out_sku_sn { get; set; }
}


public class GoodsDetailGetResponse
{
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
    public string warm_tips { get; set; }
    public List<SkuList> sku_list { get; set; }
    public string thumb_url { get; set; }
    public string hd_thumb_url { get; set; }
    public string image_url { get; set; }
    public List<string> detail_gallery_list { get; set; }
    public string outer_goods_id { get; set; }
    public int second_hand { get; set; }
}


public class GetGoodsDetailApiResult
{
    public GoodsDetailGetResponse goods_detail_get_response { get; set; }
}

}
