namespace App.Models.PddApiResult
{
    
public class Target
{
    public object min_pay_amount { get; set; }
    public object max_pay_amount { get; set; }
    public object pay_amount_limit { get; set; }
    public object sex { get; set; }
    public object region { get; set; }
    public object region_type { get; set; }
    public object order_start_time { get; set; }
    public object order_end_time { get; set; }
    public int order_time_type { get; set; }
    public int people_num { get; set; }
}


public class Crowd2
{
    public object location_type { get; set; }
    public object location { get; set; }
    public object gender { get; set; }
    public object purchase_days { get; set; }
    public object none_purchase_days { get; set; }
    public object goods_favor_days { get; set; }
    public object mall_favor_days { get; set; }
    public int min_order_count { get; set; }
    public int max_order_count { get; set; }
    public object first_buy_start_time { get; set; }
    public object first_buy_end_time { get; set; }
    public int mall_visit_days { get; set; }
    public object mall_none_visit_days { get; set; }
}


public class Crowd
{
    public string name { get; set; }
    public object people_num { get; set; }
    public Crowd2 crowd { get; set; }
}


public class SmsSellSettingDetailQueryResponse
{
    public int id { get; set; }
    public int mall_id { get; set; }
    public int scene { get; set; }
    public object trigger_condition { get; set; }
    public Target target { get; set; }
    public int template_id { get; set; }
    public string template_content { get; set; }
    public string send_time { get; set; }
    public int open { get; set; }
    public int send_num { get; set; }
    public int crowd_id { get; set; }
    public Crowd crowd { get; set; }
}


public class QuerySmsSellSettingDetailApiResult
{
    public SmsSellSettingDetailQueryResponse sms_sell_setting_detail_query_response { get; set; }
}

}
