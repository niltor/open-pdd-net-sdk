using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GenDdkResourceUrlResponseModel : PddResponseModel
    {
        /// <summary>
/// 单人团链接
/// </summary>
[JsonProperty("single_url_list")]
public object SingleUrlList {get;set;}
/// <summary>
/// 多人团链接
/// </summary>
[JsonProperty("multi_url_list")]
public object MultiUrlList {get;set;}
/// <summary>
/// 自定义参数
/// </summary>
[JsonProperty("sign")]
public object Sign {get;set;}
/// <summary>
/// 频道推广长链接
/// </summary>
[JsonProperty("url")]
public object Url {get;set;}
/// <summary>
/// 频道推广短链接
/// </summary>
[JsonProperty("short_url")]
public object ShortUrl {get;set;}
/// <summary>
/// 频道推广唤醒拼多多APP长链接
/// </summary>
[JsonProperty("mobile_url")]
public object MobileUrl {get;set;}
/// <summary>
/// 频道推广唤醒拼多多APP短链接
/// </summary>
[JsonProperty("mobile_short_url")]
public object MobileShortUrl {get;set;}
/// <summary>
/// 频道推广唤醒微信长链接
/// </summary>
[JsonProperty("we_app_web_view_url")]
public object WeAppWebViewUrl {get;set;}
/// <summary>
/// 频道推广唤醒微信短链接
/// </summary>
[JsonProperty("we_app_web_view_short_url")]
public object WeAppWebViewShortUrl {get;set;}
/// <summary>
/// 小程序信息
/// </summary>
[JsonProperty("we_app_page_path")]
public object WeAppPagePath {get;set;}
/// <summary>
/// 频道推广长链接
/// </summary>
[JsonProperty("url")]
public object Url {get;set;}
/// <summary>
/// 频道推广短链接
/// </summary>
[JsonProperty("short_url")]
public object ShortUrl {get;set;}
/// <summary>
/// 频道推广唤醒拼多多APP长链接
/// </summary>
[JsonProperty("mobile_url")]
public object MobileUrl {get;set;}
/// <summary>
/// 频道推广唤醒拼多多APP短链接
/// </summary>
[JsonProperty("mobile_short_url")]
public object MobileShortUrl {get;set;}
/// <summary>
/// 频道推广唤醒微信长链接
/// </summary>
[JsonProperty("we_app_web_view_url")]
public object WeAppWebViewUrl {get;set;}
/// <summary>
/// 频道推广唤醒微信短链接
/// </summary>
[JsonProperty("we_app_web_view_short_url")]
public object WeAppWebViewShortUrl {get;set;}
/// <summary>
/// 小程序红包推广路径
/// </summary>
[JsonProperty("we_app_page_path")]
public object WeAppPagePath {get;set;}

    public partial class SingleUrlListResponseModel : PddResponseModel
    {
        /// <summary>
/// 频道推广长链接
/// </summary>
[JsonProperty("url")]
public object Url {get;set;}
/// <summary>
/// 频道推广短链接
/// </summary>
[JsonProperty("short_url")]
public object ShortUrl {get;set;}
/// <summary>
/// 频道推广唤醒拼多多APP长链接
/// </summary>
[JsonProperty("mobile_url")]
public object MobileUrl {get;set;}
/// <summary>
/// 频道推广唤醒拼多多APP短链接
/// </summary>
[JsonProperty("mobile_short_url")]
public object MobileShortUrl {get;set;}
/// <summary>
/// 频道推广唤醒微信长链接
/// </summary>
[JsonProperty("we_app_web_view_url")]
public object WeAppWebViewUrl {get;set;}
/// <summary>
/// 频道推广唤醒微信短链接
/// </summary>
[JsonProperty("we_app_web_view_short_url")]
public object WeAppWebViewShortUrl {get;set;}
/// <summary>
/// 小程序信息
/// </summary>
[JsonProperty("we_app_page_path")]
public object WeAppPagePath {get;set;}

}

    public partial class MultiUrlListResponseModel : PddResponseModel
    {
        /// <summary>
/// 频道推广长链接
/// </summary>
[JsonProperty("url")]
public object Url {get;set;}
/// <summary>
/// 频道推广短链接
/// </summary>
[JsonProperty("short_url")]
public object ShortUrl {get;set;}
/// <summary>
/// 频道推广唤醒拼多多APP长链接
/// </summary>
[JsonProperty("mobile_url")]
public object MobileUrl {get;set;}
/// <summary>
/// 频道推广唤醒拼多多APP短链接
/// </summary>
[JsonProperty("mobile_short_url")]
public object MobileShortUrl {get;set;}
/// <summary>
/// 频道推广唤醒微信长链接
/// </summary>
[JsonProperty("we_app_web_view_url")]
public object WeAppWebViewUrl {get;set;}
/// <summary>
/// 频道推广唤醒微信短链接
/// </summary>
[JsonProperty("we_app_web_view_short_url")]
public object WeAppWebViewShortUrl {get;set;}
/// <summary>
/// 小程序红包推广路径
/// </summary>
[JsonProperty("we_app_page_path")]
public object WeAppPagePath {get;set;}

}

}
}
