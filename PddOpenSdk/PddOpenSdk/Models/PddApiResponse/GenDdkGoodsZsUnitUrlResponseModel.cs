using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GenDdkGoodsZsUnitUrlResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("goods_zs_unit_generate_response")]
public object GoodsZsUnitGenerateResponse {get;set;}
/// <summary>
/// 多多推广网址链接
/// </summary>
[JsonProperty("url")]
public object Url {get;set;}
/// <summary>
/// 多多推广网址短连接
/// </summary>
[JsonProperty("short_url")]
public object ShortUrl {get;set;}
/// <summary>
/// 多多推广移动链接
/// </summary>
[JsonProperty("mobile_url")]
public object MobileUrl {get;set;}
/// <summary>
/// 多多推广移动短链接
/// </summary>
[JsonProperty("mobile_short_url")]
public object MobileShortUrl {get;set;}
/// <summary>
/// 多多推广多人团链接
/// </summary>
[JsonProperty("multi_group_url")]
public object MultiGroupUrl {get;set;}
/// <summary>
/// 多多推广多人团短链接
/// </summary>
[JsonProperty("multi_group_short_url")]
public object MultiGroupShortUrl {get;set;}
/// <summary>
/// 多多推广多人团移动链接
/// </summary>
[JsonProperty("multi_group_mobile_url")]
public object MultiGroupMobileUrl {get;set;}
/// <summary>
/// 红包推广多人团移动短链接
/// </summary>
[JsonProperty("multi_group_mobile_short_url")]
public object MultiGroupMobileShortUrl {get;set;}

    public partial class GoodsZsUnitGenerateResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 多多推广网址链接
/// </summary>
[JsonProperty("url")]
public object Url {get;set;}
/// <summary>
/// 多多推广网址短连接
/// </summary>
[JsonProperty("short_url")]
public object ShortUrl {get;set;}
/// <summary>
/// 多多推广移动链接
/// </summary>
[JsonProperty("mobile_url")]
public object MobileUrl {get;set;}
/// <summary>
/// 多多推广移动短链接
/// </summary>
[JsonProperty("mobile_short_url")]
public object MobileShortUrl {get;set;}
/// <summary>
/// 多多推广多人团链接
/// </summary>
[JsonProperty("multi_group_url")]
public object MultiGroupUrl {get;set;}
/// <summary>
/// 多多推广多人团短链接
/// </summary>
[JsonProperty("multi_group_short_url")]
public object MultiGroupShortUrl {get;set;}
/// <summary>
/// 多多推广多人团移动链接
/// </summary>
[JsonProperty("multi_group_mobile_url")]
public object MultiGroupMobileUrl {get;set;}
/// <summary>
/// 红包推广多人团移动短链接
/// </summary>
[JsonProperty("multi_group_mobile_short_url")]
public object MultiGroupMobileShortUrl {get;set;}

}

}
}
