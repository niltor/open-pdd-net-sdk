namespace PddOpenSdk.Models.PddApiResult
{
    
public class OrderDetailResponse
{
    public object order_sn { get; set; }
    public object goods_id { get; set; }
    public object goods_name { get; set; }
    public object goods_thumbnail_url { get; set; }
    public object goods_quantity { get; set; }
    public object goods_price { get; set; }
    public object order_amount { get; set; }
    public object promotion_rate { get; set; }
    public object promotion_amount { get; set; }
    public object batch_no { get; set; }
    public object order_status { get; set; }
    public object order_status_desc { get; set; }
    public int order_create_time { get; set; }
    public object order_pay_time { get; set; }
    public object order_group_success_time { get; set; }
    public object order_receive_time { get; set; }
    public object order_verify_time { get; set; }
    public object order_settle_time { get; set; }
    public object order_modify_at { get; set; }
    public int match_channel { get; set; }
    public int type { get; set; }
    public object group_id { get; set; }
    public object auth_duo_id { get; set; }
    public object zs_duo_id { get; set; }
    public object custom_parameters { get; set; }
    public string cps_sign { get; set; }
    public int url_last_generate_time { get; set; }
    public object point_time { get; set; }
    public object return_status { get; set; }
    public string pid { get; set; }
}


public class GetDdkOrderDetailApiResult
{
    public OrderDetailResponse order_detail_response { get; set; }
}

}
