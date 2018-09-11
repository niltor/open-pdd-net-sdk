namespace App.Models.PddApiResult
{
    
public class OrderList
{
    public string order_sn { get; set; }
    public int goods_id { get; set; }
    public string goods_name { get; set; }
    public string goods_thumbnail_url { get; set; }
    public int goods_quantity { get; set; }
    public int goods_price { get; set; }
    public int order_amount { get; set; }
    public int order_create_time { get; set; }
    public int order_receive_time { get; set; }
    public int order_verify_time { get; set; }
    public int order_pay_time { get; set; }
    public int promotion_rate { get; set; }
    public int promotion_amount { get; set; }
    public int order_status { get; set; }
    public string order_status_desc { get; set; }
    public int order_group_success_time { get; set; }
    public int order_modify_at { get; set; }
    public int type { get; set; }
    public string p_id { get; set; }
}


public class OrderListGetResponse
{
    public List<OrderList> order_list { get; set; }
    public int total_count { get; set; }
}


public class GetDdkOauthOrderListIncrementApiResult
{
    public OrderListGetResponse order_list_get_response { get; set; }
}

}
