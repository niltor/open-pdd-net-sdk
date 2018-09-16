using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GenDdkOauthLotteryUrlResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回总数
/// </summary>
[JsonProperty("total")]
public int Total {get;set;}
/// <summary>
/// 推广链接
/// </summary>
[JsonProperty("url_list")]
public object UrlList {get;set;}

    public partial class UrlListResponseModel : PddResponseModel
    {
        
}

}
}
