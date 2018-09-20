using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GenerateDdkRpPromUrlResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回链接
/// </summary>
[JsonProperty("url_list")]
public UrlListResponseModel UrlList {get;set;}

    public partial class UrlListResponseModel : PddResponseModel
    {
        /// <summary>
/// 红包推广长链接
/// </summary>
[JsonProperty("url")]
public object Url {get;set;}
/// <summary>
/// 红包推广短链接
/// </summary>
[JsonProperty("short_url")]
public object ShortUrl {get;set;}
/// <summary>
/// 红包推广唤醒拼多多APP长链接
/// </summary>
[JsonProperty("mobile_url")]
public object MobileUrl {get;set;}
/// <summary>
/// 红包推广唤醒拼多多APP短链接
/// </summary>
[JsonProperty("mobile_short_url")]
public object MobileShortUrl {get;set;}
/// <summary>
/// 红包推广唤醒微信长链接
/// </summary>
[JsonProperty("we_app_web_view_url")]
public object WeAppWebViewUrl {get;set;}
/// <summary>
/// 红包推广唤醒微信短链接
/// </summary>
[JsonProperty("we_app_web_view_short_url")]
public object WeAppWebViewShortUrl {get;set;}
/// <summary>
/// 红包推广多人团长链接
/// </summary>
[JsonProperty("multi_group_url")]
public object MultiGroupUrl {get;set;}
/// <summary>
/// 红包推广多人团短链接
/// </summary>
[JsonProperty("multi_group_short_url")]
public object MultiGroupShortUrl {get;set;}
/// <summary>
/// 红包推广多人团唤醒APP长链接
/// </summary>
[JsonProperty("multi_group_mobile_url")]
public object MultiGroupMobileUrl {get;set;}
/// <summary>
/// 红包推广多人团唤醒APP短链接
/// </summary>
[JsonProperty("multi_group_mobile_short_url")]
public object MultiGroupMobileShortUrl {get;set;}
/// <summary>
/// 红包推广多人团唤醒微信长链接
/// </summary>
[JsonProperty("multi_we_app_web_view_url")]
public object MultiWeAppWebViewUrl {get;set;}
/// <summary>
/// 红包推广多人团唤醒微信短链接
/// </summary>
[JsonProperty("multi_we_app_web_view_short_url")]
public object MultiWeAppWebViewShortUrl {get;set;}
/// <summary>
/// 小程序信息
/// </summary>
[JsonProperty("we_app_info")]
public WeAppInfoResponseModel WeAppInfo {get;set;}

    public partial class WeAppInfoResponseModel : PddResponseModel
    {
        
}

}

}
}
