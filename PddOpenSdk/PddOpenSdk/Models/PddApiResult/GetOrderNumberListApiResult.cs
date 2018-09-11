namespace PddOpenSdk.Models.PddApiResult
{
    
public class OrderSnList
{
    public string order_sn { get; set; }
}


public class OrderSnListGetResponse
{
    public List<OrderSnList> order_sn_list { get; set; }
    public int total_count { get; set; }
}


public class GetOrderNumberListApiResult
{
    public OrderSnListGetResponse order_sn_list_get_response { get; set; }
}

}
