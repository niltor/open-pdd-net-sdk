namespace App.Models.PddApiResult
{
    
public class SingleUrlList
{
    public string url { get; set; }
    public string short_url { get; set; }
    public object mobile_url { get; set; }
    public string mobile_short_url { get; set; }
    public string we_app_web_view_url { get; set; }
    public string we_app_web_view_short_url { get; set; }
    public string we_app_page_path { get; set; }
}


public class UrlList
{
    public SingleUrlList single_url_list { get; set; }
    public object multi_url_list { get; set; }
    public string url { get; set; }
    public string short_url { get; set; }
    public object mobile_url { get; set; }
    public string mobile_short_url { get; set; }
    public string we_app_web_view_url { get; set; }
    public string we_app_web_view_short_url { get; set; }
    public string we_app_page_path { get; set; }
    public string multi_group_url { get; set; }
    public string multi_group_short_url { get; set; }
    public object multi_group_mobile_url { get; set; }
    public string multi_group_mobile_short_url { get; set; }
    public string multi_we_app_web_view_url { get; set; }
    public string multi_we_app_web_view_short_url { get; set; }
    public string multi_we_app_page_path { get; set; }
    public string sign { get; set; }
    public object we_app_info { get; set; }
}


public class LotteryUrlResponse
{
    public int total { get; set; }
    public List<UrlList> url_list { get; set; }
}


public class GenDdkLotteryUrlApiResult
{
    public LotteryUrlResponse lottery_url_response { get; set; }
}

}
