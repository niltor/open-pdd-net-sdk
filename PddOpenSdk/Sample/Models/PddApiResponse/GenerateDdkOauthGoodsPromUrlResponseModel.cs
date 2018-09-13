using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GenerateDdkOauthGoodsPromUrlResponseModel : PddResponseModel
    {
        /// <summary>
/// 多多进宝推广链接对象列表
/// </summary>
[JsonProperty("goods_promotion_url_list[]")]
public object GoodsPromotionUrlList[] {get;set;}
/// <summary>
/// 唤起微信app推广短链接
/// </summary>
[JsonProperty("we_app_web_view_short_url")]
public object WeAppWebViewShortUrl {get;set;}
/// <summary>
/// 唤起微信app推广链接
/// </summary>
[JsonProperty("we_app_web_wiew_url")]
public object WeAppWebWiewUrl {get;set;}
/// <summary>
/// 唤醒拼多多app的推广短链接
/// </summary>
[JsonProperty("mobile_short_url")]
public object MobileShortUrl {get;set;}
/// <summary>
/// 唤醒拼多多app的推广长链接
/// </summary>
[JsonProperty("mobile_url")]
public object MobileUrl {get;set;}
/// <summary>
/// 推广短链接
/// </summary>
[JsonProperty("short_url")]
public object ShortUrl {get;set;}
/// <summary>
/// 推广长链接
/// </summary>
[JsonProperty("url")]
public object Url {get;set;}

    public partial class GoodsPromotionUrlList[]ResponseModel : PddResponseModel
    {
        /// <summary>
/// 唤起微信app推广短链接
/// </summary>
[JsonProperty("we_app_web_view_short_url")]
public object WeAppWebViewShortUrl {get;set;}
/// <summary>
/// 唤起微信app推广链接
/// </summary>
[JsonProperty("we_app_web_wiew_url")]
public object WeAppWebWiewUrl {get;set;}
/// <summary>
/// 唤醒拼多多app的推广短链接
/// </summary>
[JsonProperty("mobile_short_url")]
public object MobileShortUrl {get;set;}
/// <summary>
/// 唤醒拼多多app的推广长链接
/// </summary>
[JsonProperty("mobile_url")]
public object MobileUrl {get;set;}
/// <summary>
/// 推广短链接
/// </summary>
[JsonProperty("short_url")]
public object ShortUrl {get;set;}
/// <summary>
/// 推广长链接
/// </summary>
[JsonProperty("url")]
public object Url {get;set;}

}

}
}
