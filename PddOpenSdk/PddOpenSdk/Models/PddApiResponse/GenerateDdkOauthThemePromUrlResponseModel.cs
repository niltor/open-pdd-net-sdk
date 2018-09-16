using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GenerateDdkOauthThemePromUrlResponseModel : PddResponseModel
    {
        /// <summary>
/// 主题活动推广返回对象
/// </summary>
[JsonProperty("theme_promotion_url_generate_response")]
public object ThemePromotionUrlGenerateResponse {get;set;}
/// <summary>
/// 主题活动推广url列表
/// </summary>
[JsonProperty("url_list")]
public object UrlList {get;set;}
/// <summary>
/// 主题活动推广链接
/// </summary>
[JsonProperty("url")]
public object Url {get;set;}
/// <summary>
/// 主题活动推广短链
/// </summary>
[JsonProperty("short_url")]
public object ShortUrl {get;set;}
/// <summary>
/// 主题活动推广移动链接
/// </summary>
[JsonProperty("mobile_url")]
public object MobileUrl {get;set;}
/// <summary>
/// 主题活动推广移动短链接
/// </summary>
[JsonProperty("mobile_short_url")]
public object MobileShortUrl {get;set;}
/// <summary>
/// 主题活动推广开团链接
/// </summary>
[JsonProperty("multi_group_url")]
public object MultiGroupUrl {get;set;}
/// <summary>
/// 主题活动推广开团短链接
/// </summary>
[JsonProperty("multi_group_short_url")]
public object MultiGroupShortUrl {get;set;}
/// <summary>
/// 主题活动推广开团移动端链接
/// </summary>
[JsonProperty("multi_group_mobile_url")]
public object MultiGroupMobileUrl {get;set;}
/// <summary>
/// 主题活动推广开团移动端短链接
/// </summary>
[JsonProperty("multi_group_mobile_short_url")]
public object MultiGroupMobileShortUrl {get;set;}

    public partial class ThemePromotionUrlGenerateResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 主题活动推广url列表
/// </summary>
[JsonProperty("url_list")]
public object UrlList {get;set;}

}

    public partial class UrlListResponseModel : PddResponseModel
    {
        /// <summary>
/// 主题活动推广链接
/// </summary>
[JsonProperty("url")]
public object Url {get;set;}
/// <summary>
/// 主题活动推广短链
/// </summary>
[JsonProperty("short_url")]
public object ShortUrl {get;set;}
/// <summary>
/// 主题活动推广移动链接
/// </summary>
[JsonProperty("mobile_url")]
public object MobileUrl {get;set;}
/// <summary>
/// 主题活动推广移动短链接
/// </summary>
[JsonProperty("mobile_short_url")]
public object MobileShortUrl {get;set;}
/// <summary>
/// 主题活动推广开团链接
/// </summary>
[JsonProperty("multi_group_url")]
public object MultiGroupUrl {get;set;}
/// <summary>
/// 主题活动推广开团短链接
/// </summary>
[JsonProperty("multi_group_short_url")]
public object MultiGroupShortUrl {get;set;}
/// <summary>
/// 主题活动推广开团移动端链接
/// </summary>
[JsonProperty("multi_group_mobile_url")]
public object MultiGroupMobileUrl {get;set;}
/// <summary>
/// 主题活动推广开团移动端短链接
/// </summary>
[JsonProperty("multi_group_mobile_short_url")]
public object MultiGroupMobileShortUrl {get;set;}

}

}
}
