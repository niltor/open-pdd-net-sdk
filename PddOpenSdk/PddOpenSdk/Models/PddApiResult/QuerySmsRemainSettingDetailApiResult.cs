namespace PddOpenSdk.Models.PddApiResult
{
    
public class TriggerCondition
{
    public int unpaid_duration { get; set; }
}


public class Target
{
    public object min_pay_amount { get; set; }
    public object max_pay_amount { get; set; }
    public object pay_amount_limit { get; set; }
    public object region_type { get; set; }
    public object region { get; set; }
    public object goods { get; set; }
    public object goods_invert { get; set; }
}


public class Result
{
    public int mall_id { get; set; }
    public int scene { get; set; }
    public TriggerCondition trigger_condition { get; set; }
    public Target target { get; set; }
    public int template_id { get; set; }
    public int open { get; set; }
    public int send_num { get; set; }
    public int send_failed_num { get; set; }
}


public class SmsRemainSettingDetailQueryResponse
{
    public bool success { get; set; }
    public int error_code { get; set; }
    public object error_msg { get; set; }
    public Result result { get; set; }
}


public class QuerySmsRemainSettingDetailApiResult
{
    public SmsRemainSettingDetailQueryResponse sms_remain_setting_detail_query_response { get; set; }
}

}
