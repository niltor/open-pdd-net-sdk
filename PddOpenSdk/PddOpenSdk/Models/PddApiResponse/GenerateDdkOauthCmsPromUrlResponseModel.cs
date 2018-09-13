using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GenerateDdkOauthCmsPromUrlResponseModel : PddResponseModel
    {
        /// <summary>
/// 商城推广链接返回对象
/// </summary>
[JsonProperty("cms_promotion_url_generate_response")]
public object CmsPromotionUrlGenerateResponse {get;set;}
/// <summary>
/// 商城推广链接
/// </summary>
[JsonProperty("url")]
public object Url {get;set;}
/// <summary>
/// 商城推广短链接
/// </summary>
[JsonProperty("short_url")]
public object ShortUrl {get;set;}
/// <summary>
/// 商城推广移动链接
/// </summary>
[JsonProperty("mobile_url")]
public object MobileUrl {get;set;}
/// <summary>
/// 商城推广移动短链接
/// </summary>
[JsonProperty("mobile_short_url")]
public object MobileShortUrl {get;set;}
/// <summary>
/// 商城推广多人团链接
/// </summary>
[JsonProperty("multi_group_url")]
public object MultiGroupUrl {get;set;}
/// <summary>
/// 商城推广多人团短链接
/// </summary>
[JsonProperty("multi_group_short_url")]
public object MultiGroupShortUrl {get;set;}
/// <summary>
/// 商城推广多人团移动链接
/// </summary>
[JsonProperty("multi_group_mobile_url")]
public object MultiGroupMobileUrl {get;set;}
/// <summary>
/// 商城推广多人团移动短链接
/// </summary>
[JsonProperty("multi_group_mobile_short_url")]
public object MultiGroupMobileShortUrl {get;set;}

    public partial class CmsPromotionUrlGenerateResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 商城推广链接
/// </summary>
[JsonProperty("url")]
public object Url {get;set;}
/// <summary>
/// 商城推广短链接
/// </summary>
[JsonProperty("short_url")]
public object ShortUrl {get;set;}
/// <summary>
/// 商城推广移动链接
/// </summary>
[JsonProperty("mobile_url")]
public object MobileUrl {get;set;}
/// <summary>
/// 商城推广移动短链接
/// </summary>
[JsonProperty("mobile_short_url")]
public object MobileShortUrl {get;set;}
/// <summary>
/// 商城推广多人团链接
/// </summary>
[JsonProperty("multi_group_url")]
public object MultiGroupUrl {get;set;}
/// <summary>
/// 商城推广多人团短链接
/// </summary>
[JsonProperty("multi_group_short_url")]
public object MultiGroupShortUrl {get;set;}
/// <summary>
/// 商城推广多人团移动链接
/// </summary>
[JsonProperty("multi_group_mobile_url")]
public object MultiGroupMobileUrl {get;set;}
/// <summary>
/// 商城推广多人团移动短链接
/// </summary>
[JsonProperty("multi_group_mobile_short_url")]
public object MultiGroupMobileShortUrl {get;set;}

}

}
}
