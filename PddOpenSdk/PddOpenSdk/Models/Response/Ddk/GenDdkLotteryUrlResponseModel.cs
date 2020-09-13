using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ddk
{
public partial class GenDdkLotteryUrlResponseModel : PddResponseModel
{
/// <summary>
/// lottery_url_response
/// </summary>
[JsonProperty("lottery_url_response")]
public LotteryUrlResponseResponseModel LotteryUrlResponse {get;set;}
public partial class LotteryUrlResponseResponseModel : PddResponseModel
{
/// <summary>
/// 返回总数
/// </summary>
[JsonProperty("total")]
public int? Total {get;set;}
/// <summary>
/// 推广链接
/// </summary>
[JsonProperty("url_list")]
public List<UrlListResponseModel> UrlList {get;set;}
public partial class UrlListResponseModel : PddResponseModel
{
/// <summary>
/// 转盘抽免单多人团链接
/// </summary>
[JsonProperty("multi_url_list")]
public MultiUrlListResponseModel MultiUrlList {get;set;}
/// <summary>
/// qq小程序信息
/// </summary>
[JsonProperty("qq_app_info")]
public QqAppInfoResponseModel QqAppInfo {get;set;}
/// <summary>
/// 自定义参数
/// </summary>
[JsonProperty("sign")]
public string Sign {get;set;}
/// <summary>
/// 转盘抽免单单人团链接
/// </summary>
[JsonProperty("single_url_list")]
public SingleUrlListResponseModel SingleUrlList {get;set;}
/// <summary>
/// 小程序信息
/// </summary>
[JsonProperty("we_app_info")]
public WeAppInfoResponseModel WeAppInfo {get;set;}
public partial class MultiUrlListResponseModel : PddResponseModel
{
/// <summary>
/// 转盘抽免单唤醒拼多多APP短链接
/// </summary>
[JsonProperty("mobile_short_url")]
public string MobileShortUrl {get;set;}
/// <summary>
/// 转盘抽免单唤醒拼多多APP长链接
/// </summary>
[JsonProperty("mobile_url")]
public string MobileUrl {get;set;}
/// <summary>
/// schema的链接
/// </summary>
[JsonProperty("schema_url")]
public string SchemaUrl {get;set;}
/// <summary>
/// 转盘抽免单短链接
/// </summary>
[JsonProperty("short_url")]
public string ShortUrl {get;set;}
/// <summary>
/// 转盘抽免单长链接
/// </summary>
[JsonProperty("url")]
public string Url {get;set;}
/// <summary>
/// 转盘抽免单小程序链接
/// </summary>
[JsonProperty("we_app_page_path")]
public string WeAppPagePath {get;set;}
/// <summary>
/// 转盘抽免单唤醒微信短链接
/// </summary>
[JsonProperty("we_app_web_view_short_url")]
public string WeAppWebViewShortUrl {get;set;}
/// <summary>
/// 转盘抽免单唤醒微信长链接
/// </summary>
[JsonProperty("we_app_web_view_url")]
public string WeAppWebViewUrl {get;set;}

}
public partial class QqAppInfoResponseModel : PddResponseModel
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
/// 小程序icon
/// </summary>
[JsonProperty("qq_app_icon_url")]
public string QqAppIconUrl {get;set;}
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

}
public partial class SingleUrlListResponseModel : PddResponseModel
{
/// <summary>
/// 转盘抽免单唤醒APP短链接
/// </summary>
[JsonProperty("mobile_short_url")]
public string MobileShortUrl {get;set;}
/// <summary>
/// 转盘抽免单唤醒APP长链接
/// </summary>
[JsonProperty("mobile_url")]
public string MobileUrl {get;set;}
/// <summary>
/// schema的链接
/// </summary>
[JsonProperty("schema_url")]
public string SchemaUrl {get;set;}
/// <summary>
/// 转盘抽免单短链接
/// </summary>
[JsonProperty("short_url")]
public string ShortUrl {get;set;}
/// <summary>
/// 转盘抽免单长链接
/// </summary>
[JsonProperty("url")]
public string Url {get;set;}
/// <summary>
/// 转盘抽免单小程序短链接
/// </summary>
[JsonProperty("we_app_page_path")]
public string WeAppPagePath {get;set;}
/// <summary>
/// 转盘抽免单唤醒微信短链接
/// </summary>
[JsonProperty("we_app_web_view_short_url")]
public string WeAppWebViewShortUrl {get;set;}
/// <summary>
/// 转盘抽免单唤醒微信长链接
/// </summary>
[JsonProperty("we_app_web_view_url")]
public string WeAppWebViewUrl {get;set;}

}
public partial class WeAppInfoResponseModel : PddResponseModel
{
/// <summary>
/// 小程序ID
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
/// 小程序图片
/// </summary>
[JsonProperty("we_app_icon_url")]
public string WeAppIconUrl {get;set;}

}

}

}

}

}
