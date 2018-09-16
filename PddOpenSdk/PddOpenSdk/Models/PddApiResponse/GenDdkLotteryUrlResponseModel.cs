using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GenDdkLotteryUrlResponseModel : PddResponseModel
    {
        /// <summary>
/// 链接总条数
/// </summary>
[JsonProperty("total")]
public object Total {get;set;}
/// <summary>
/// 链接串
/// </summary>
[JsonProperty("url_list")]
public object UrlList {get;set;}

    public partial class UrlListResponseModel : PddResponseModel
    {
        
}

}
}
