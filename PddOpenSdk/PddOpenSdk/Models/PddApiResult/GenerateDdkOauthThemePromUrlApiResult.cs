namespace App.Models.PddApiResult
{
    
public class UrlList
{
    public string url { get; set; }
    public string short_url { get; set; }
    public string mobile_url { get; set; }
    public string mobile_short_url { get; set; }
    public string multi_group_url { get; set; }
    public string multi_group_short_url { get; set; }
    public string multi_group_mobile_url { get; set; }
    public string multi_group_mobile_short_url { get; set; }
}


public class ThemePromotionUrlGenerateResponse
{
    public List<UrlList> url_list { get; set; }
}


public class GenerateDdkOauthThemePromUrlApiResult
{
    public ThemePromotionUrlGenerateResponse theme_promotion_url_generate_response { get; set; }
}

}
