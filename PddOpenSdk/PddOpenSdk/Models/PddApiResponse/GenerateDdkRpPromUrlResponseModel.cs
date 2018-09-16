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
public object UrlList {get;set;}
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
public object WeAppInfo {get;set;}
/// <summary>
/// 小程序id
/// </summary>
[JsonProperty("app_id")]
public object AppId {get;set;}
/// <summary>
/// icon的链接
/// </summary>
[JsonProperty("we_app_icon_url")]
public object WeAppIconUrl {get;set;}
/// <summary>
/// banner图url
/// </summary>
[JsonProperty("banner_url")]
public object BannerUrl {get;set;}
/// <summary>
/// 描述
/// </summary>
[JsonProperty("desc")]
public object Desc {get;set;}
/// <summary>
/// 展示标题名
/// </summary>
[JsonProperty("source_display_name")]
public object SourceDisplayName {get;set;}
/// <summary>
/// 跳转目标小程序地址
/// </summary>
[JsonProperty("page_path")]
public object PagePath {get;set;}
/// <summary>
/// 用户名
/// </summary>
[JsonProperty("user_name")]
public object UserName {get;set;}
/// <summary>
/// 小程序标题
/// </summary>
[JsonProperty("title")]
public object Title {get;set;}

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
public object WeAppInfo {get;set;}

}

    public partial class WeAppInfoResponseModel : PddResponseModel
    {
        /// <summary>
/// 小程序id
/// </summary>
[JsonProperty("app_id")]
public object AppId {get;set;}
/// <summary>
/// icon的链接
/// </summary>
[JsonProperty("we_app_icon_url")]
public object WeAppIconUrl {get;set;}
/// <summary>
/// banner图url
/// </summary>
[JsonProperty("banner_url")]
public object BannerUrl {get;set;}
/// <summary>
/// 描述
/// </summary>
[JsonProperty("desc")]
public object Desc {get;set;}
/// <summary>
/// 展示标题名
/// </summary>
[JsonProperty("source_display_name")]
public object SourceDisplayName {get;set;}
/// <summary>
/// 跳转目标小程序地址
/// </summary>
[JsonProperty("page_path")]
public object PagePath {get;set;}
/// <summary>
/// 用户名
/// </summary>
[JsonProperty("user_name")]
public object UserName {get;set;}
/// <summary>
/// 小程序标题
/// </summary>
[JsonProperty("title")]
public object Title {get;set;}

}

}
}
