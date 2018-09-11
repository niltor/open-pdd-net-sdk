namespace App.Models.PddApiResult
{
    
public class OrderStatusList
{
    public string orderSn { get; set; }
    public int order_status { get; set; }
    public int refund_status { get; set; }
}


public class OrderStatusGetResponse
{
    public List<OrderStatusList> order_status_list { get; set; }
}


public class GetOrderStatusApiResult
{
    public OrderStatusGetResponse order_status_get_response { get; set; }
}

}
