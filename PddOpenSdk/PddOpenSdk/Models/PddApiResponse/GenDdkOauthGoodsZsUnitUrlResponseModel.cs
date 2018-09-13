using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GenDdkOauthGoodsZsUnitUrlResponseModel : PddResponseModel
    {
        /// <summary>
/// 单人团推广长链接
/// </summary>
[JsonProperty("url")]
public object Url {get;set;}
/// <summary>
/// 单人团推广短链接
/// </summary>
[JsonProperty("short_url")]
public object ShortUrl {get;set;}
/// <summary>
/// 推广长链接（唤起拼多多app）
/// </summary>
[JsonProperty("mobile_url")]
public object MobileUrl {get;set;}
/// <summary>
/// 推广短链接（可唤起拼多多app）
/// </summary>
[JsonProperty("mobile_short_url")]
public object MobileShortUrl {get;set;}
/// <summary>
/// 双人团推广长链接
/// </summary>
[JsonProperty("multi_group_url")]
public object MultiGroupUrl {get;set;}
/// <summary>
/// 双人团推广短链接
/// </summary>
[JsonProperty("multi_group_short_url")]
public object MultiGroupShortUrl {get;set;}
/// <summary>
/// 推广长链接（可唤起拼多多app）
/// </summary>
[JsonProperty("multi_group_mobile_url")]
public object MultiGroupMobileUrl {get;set;}
/// <summary>
/// 推广短链接（唤起拼多多app）
/// </summary>
[JsonProperty("multi_group_mobile_short_url")]
public object MultiGroupMobileShortUrl {get;set;}

}
}
