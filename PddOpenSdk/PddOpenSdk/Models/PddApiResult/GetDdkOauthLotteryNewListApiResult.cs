namespace App.Models.PddApiResult
{
    
public class List
{
    public string pid { get; set; }
    public string order_sn { get; set; }
    public object goods_thumb_url { get; set; }
    public object goods_id { get; set; }
    public object goods_name { get; set; }
    public object pay_time { get; set; }
    public int updated_at { get; set; }
    public object verify_time { get; set; }
    public int status { get; set; }
    public string custom_parameters { get; set; }
}


public class LotteryNewShowBillResponse
{
    public List<List> list { get; set; }
    public int page_num { get; set; }
    public int page_size { get; set; }
    public int total_count { get; set; }
}


public class GetDdkOauthLotteryNewListApiResult
{
    public LotteryNewShowBillResponse lottery_new_show_bill_response { get; set; }
}

}
