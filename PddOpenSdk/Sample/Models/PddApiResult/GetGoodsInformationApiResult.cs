using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class SkuList
{
    public string spec { get; set; }
    public string sku_id { get; set; }
    public string sku_quantity { get; set; }
    public string outer_id { get; set; }
    public string outer_goods_id { get; set; }
    public string sku_img { get; set; }
    public string group_price { get; set; }
    public string single_price { get; set; }
    public string is_sku_onsale { get; set; }
}


public class GoodsInfo
{
    public string goods_id { get; set; }
    public string goods_sn { get; set; }
    public string goods_type { get; set; }
    public string goods_category { get; set; }
    public string last_category { get; set; }
    public string is_refundable { get; set; }
    public string shipment_limit_second { get; set; }
    public string goods_name { get; set; }
    public string image_url { get; set; }
    public int goods_quantity { get; set; }
    public string is_onsale { get; set; }
    public int second_hand { get; set; }
    public string group_required_customer_num { get; set; }
    public List<SkuList> sku_list { get; set; }
}


public class GoodsInfoGetResponse
{
    public GoodsInfo goods_info { get; set; }
}


public class GetGoodsInformationApiResult
{
    public GoodsInfoGetResponse goods_info_get_response { get; set; }
}

}
