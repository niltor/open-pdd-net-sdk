using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ddk
{
public partial class GenerateDdkRpPromUrlResponseModel : PddResponseModel
{
/// <summary>
/// 红包推广链接返回对象
/// </summary>
[JsonProperty("rp_promotion_url_generate_response")]
public RpPromotionUrlGenerateResponseResponseModel RpPromotionUrlGenerateResponse {get;set;}
public partial class RpPromotionUrlGenerateResponseResponseModel : PddResponseModel
{
/// <summary>
/// url_list
/// </summary>
[JsonProperty("url_list")]
public List<UrlListResponseModel> UrlList {get;set;}
public partial class UrlListResponseModel : PddResponseModel
{
/// <summary>
/// 红包推广链接
/// </summary>
[JsonProperty("url")]
public string Url {get;set;}
/// <summary>
/// 红包推广短链接
/// </summary>
[JsonProperty("short_url")]
public string ShortUrl {get;set;}
/// <summary>
/// 红包推广移动链接
/// </summary>
[JsonProperty("mobile_url")]
public string MobileUrl {get;set;}
/// <summary>
/// 红包推广移动短链接
/// </summary>
[JsonProperty("mobile_short_url")]
public string MobileShortUrl {get;set;}
/// <summary>
/// 红包推广多人团链接
/// </summary>
[JsonProperty("multi_group_url")]
public string MultiGroupUrl {get;set;}
/// <summary>
/// 红包推广多人团短链接
/// </summary>
[JsonProperty("multi_group_short_url")]
public string MultiGroupShortUrl {get;set;}
/// <summary>
/// 红包推广多人团移动链接
/// </summary>
[JsonProperty("multi_group_mobile_url")]
public string MultiGroupMobileUrl {get;set;}
/// <summary>
/// 红包推广多人团移动短链接
/// </summary>
[JsonProperty("multi_group_mobile_short_url")]
public string MultiGroupMobileShortUrl {get;set;}
/// <summary>
/// 小程序信息
/// </summary>
[JsonProperty("we_app_info")]
public WeAppInfoResponseModel WeAppInfo {get;set;}
/// <summary>
/// schema的链接
/// </summary>
[JsonProperty("schema_url")]
public string SchemaUrl {get;set;}
public partial class WeAppInfoResponseModel : PddResponseModel
{
/// <summary>
/// 拼多多小程序id
/// </summary>
[JsonProperty("app_id")]
public string AppId {get;set;}
/// <summary>
/// Banner图
/// </summary>
[JsonProperty("banner_url")]
public string BannerUrl {get;set;}
/// <summary>
/// 描述
/// </summary>
[JsonProperty("desc")]
public string Desc {get;set;}
/// <summary>
/// 小程序path值
/// </summary>
[JsonProperty("page_path")]
public string PagePath {get;set;}
/// <summary>
/// 来源名
/// </summary>
[JsonProperty("source_display_name")]
public string SourceDisplayName {get;set;}
/// <summary>
/// 小程序标题
/// </summary>
[JsonProperty("title")]
public string Title {get;set;}
/// <summary>
/// 用户名
/// </summary>
[JsonProperty("user_name")]
public string UserName {get;set;}
/// <summary>
/// 小程序icon
/// </summary>
[JsonProperty("we_app_icon_url")]
public string WeAppIconUrl {get;set;}

}

}

}

}

}
