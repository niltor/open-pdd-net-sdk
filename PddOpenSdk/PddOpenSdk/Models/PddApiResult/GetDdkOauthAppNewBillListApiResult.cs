namespace PddOpenSdk.Models.PddApiResult
{
    
public class List
{
    public string pid { get; set; }
    public string order_sn { get; set; }
    public string goods_thumb_url { get; set; }
    public int goods_id { get; set; }
    public string goods_name { get; set; }
    public int money { get; set; }
    public object pay_time { get; set; }
    public int updated_at { get; set; }
    public object verify_time { get; set; }
    public int status { get; set; }
    public string custom_parameters { get; set; }
}


public class AppNewBillListResponse
{
    public List<List> list { get; set; }
    public int total_count { get; set; }
}


public class GetDdkOauthAppNewBillListApiResult
{
    public AppNewBillListResponse app_new_bill_list_response { get; set; }
}

}
