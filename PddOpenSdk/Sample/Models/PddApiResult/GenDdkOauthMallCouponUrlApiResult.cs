using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class List
{
    public string url { get; set; }
    public string short_url { get; set; }
    public string mobile_url { get; set; }
    public string mobile_short_url { get; set; }
    public string we_app_web_view_url { get; set; }
    public string we_app_web_view_short_url { get; set; }
}


public class MallCouponGenerateUrlResponse
{
    public List<List> list { get; set; }
}


public class GenDdkOauthMallCouponUrlApiResult
{
    public MallCouponGenerateUrlResponse mall_coupon_generate_url_response { get; set; }
}

}
