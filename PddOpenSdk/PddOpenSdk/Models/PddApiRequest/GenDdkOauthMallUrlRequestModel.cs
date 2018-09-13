using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class GenDdkOauthMallUrlRequestModel : PddRequestModel
    {
        /// <summary>
/// 店铺id
/// </summary>
[JsonProperty("mall_id")]
public int MallId {get;set;}
/// <summary>
/// 推广位
/// </summary>
[JsonProperty("pid")]
public object Pid {get;set;}
/// <summary>
/// 是否生成唤起微信客户端链接，true-是，false-否，默认false
/// </summary>
[JsonProperty("generate_weapp_webview")]
public bool? GenerateWeappWebview {get;set;}
/// <summary>
/// 是否生成短链接，true-是，false-否
/// </summary>
[JsonProperty("generate_short_url")]
public bool? GenerateShortUrl {get;set;}
/// <summary>
/// true--生成多人团推广链接 false--生成单人团推广链接（默认false）1、单人团推广链接：用户访问单人团推广链接，可直接购买商品无需拼团。2、多人团推广链接：用户访问双人团推广链接开团，若用户分享给他人参团，则开团者和参团者的佣金均结算给推手
/// </summary>
[JsonProperty("multi_group")]
public bool? MultiGroup {get;set;}

}
}
