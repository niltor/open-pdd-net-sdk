namespace PddOpenSdk.Models.PddApiResult
{
    
public class RefundList
{
    public int id { get; set; }
    public string order_sn { get; set; }
    public string confirm_time { get; set; }
    public string after_sale_reason { get; set; }
    public int after_sales_status { get; set; }
    public int after_sales_type { get; set; }
    public string order_amount { get; set; }
    public string refund_amount { get; set; }
    public string sku_id { get; set; }
    public string outer_id { get; set; }
    public string outer_goods_id { get; set; }
    public string discount_amount { get; set; }
    public string goods_price { get; set; }
    public string goods_number { get; set; }
    public int goods_id { get; set; }
    public string goods_name { get; set; }
    public string good_image { get; set; }
    public string tracking_number { get; set; }
    public string created_time { get; set; }
    public string updated_time { get; set; }
}


public class RefundIncrementGetResponse
{
    public int total_count { get; set; }
    public List<RefundList> refund_list { get; set; }
}


public class GetRefundListIncrementApiResult
{
    public RefundIncrementGetResponse refund_increment_get_response { get; set; }
}

}
