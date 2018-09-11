namespace PddOpenSdk.Models.PddApiResult
{
    
public class ItemList
{
    public string goods_id { get; set; }
    public string sku_id { get; set; }
    public string outer_id { get; set; }
    public string outer_goods_id { get; set; }
    public string goods_name { get; set; }
    public double goods_price { get; set; }
    public string goods_spec { get; set; }
    public int goods_count { get; set; }
    public string goods_img { get; set; }
}


public class OrderList
{
    public string order_sn { get; set; }
    public string confirm_time { get; set; }
    public string receiver_name { get; set; }
    public string created_time { get; set; }
    public string country { get; set; }
    public string province { get; set; }
    public string city { get; set; }
    public string town { get; set; }
    public string address { get; set; }
    public string receiver_phone { get; set; }
    public double pay_amount { get; set; }
    public double goods_amount { get; set; }
    public int discount_amount { get; set; }
    public int postage { get; set; }
    public string pay_no { get; set; }
    public string pay_type { get; set; }
    public string id_card_num { get; set; }
    public string id_card_name { get; set; }
    public int logistics_id { get; set; }
    public string tracking_number { get; set; }
    public string shipping_time { get; set; }
    public int order_status { get; set; }
    public int is_lucky_flag { get; set; }
    public int refund_status { get; set; }
    public string updated_at { get; set; }
    public string last_ship_time { get; set; }
    public string remark { get; set; }
    public string receive_time { get; set; }
    public int country_id { get; set; }
    public int province_id { get; set; }
    public int city_id { get; set; }
    public int town_id { get; set; }
    public List<ItemList> item_list { get; set; }
    public int platform_discount { get; set; }
    public int seller_discount { get; set; }
    public int capital_free_discount { get; set; }
    public int cat_id_1 { get; set; }
    public int cat_id_2 { get; set; }
    public int cat_id_3 { get; set; }
    public int cat_id_4 { get; set; }
    public int stock_out_handle_status { get; set; }
    public int is_stock_out { get; set; }
    public string inner_transaction_id { get; set; }
    public string buyer_memo { get; set; }
    public int invoice_status { get; set; }
    public int is_pre_sale { get; set; }
    public string pre_sale_time { get; set; }
}


public class OrderListGetResponse
{
    public List<OrderList> order_list { get; set; }
    public int total_count { get; set; }
}


public class GetOrderListApiResult
{
    public OrderListGetResponse order_list_get_response { get; set; }
}

}
