namespace App.Models.PddApiResult
{
    
public class Crowd
{
    public object location_type { get; set; }
    public object location { get; set; }
    public object gender { get; set; }
    public int purchase_days { get; set; }
    public object none_purchase_days { get; set; }
    public object goods_favor_days { get; set; }
    public object mall_favor_days { get; set; }
    public object min_order_count { get; set; }
    public object max_order_count { get; set; }
    public object first_buy_start_time { get; set; }
    public object first_buy_end_time { get; set; }
    public object mall_visit_days { get; set; }
    public object mall_none_visit_days { get; set; }
}


public class Result
{
    public int id { get; set; }
    public int type { get; set; }
    public object scene { get; set; }
    public object mall_id { get; set; }
    public string name { get; set; }
    public int people_num { get; set; }
    public Crowd crowd { get; set; }
}


public class SmsCrowsQueryResponse
{
    public int total { get; set; }
    public List<Result> result { get; set; }
}


public class QuerySmsCrowdsApiResult
{
    public SmsCrowsQueryResponse sms_crows_query_response { get; set; }
}

}
