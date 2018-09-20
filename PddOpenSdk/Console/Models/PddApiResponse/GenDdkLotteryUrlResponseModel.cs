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
public UrlListResponseModel UrlList {get;set;}

    public partial class UrlListResponseModel : PddResponseModel
    {
        /// <summary>
/// 单人团链接
/// </summary>
[JsonProperty("single_url_list")]
public SingleUrlListResponseModel SingleUrlList {get;set;}
/// <summary>
/// 转盘抽免单多人团链接
/// </summary>
[JsonProperty("multi_url_list")]
public MultiUrlListResponseModel MultiUrlList {get;set;}
/// <summary>
/// 转盘抽免单唤小程序多人团链接
/// </summary>
[JsonProperty("multi_we_app_page_path")]
public object MultiWeAppPagePath {get;set;}
/// <summary>
/// 自定义参数
/// </summary>
[JsonProperty("sign")]
public object Sign {get;set;}

    public partial class SingleUrlListResponseModel : PddResponseModel
    {
        
}

    public partial class MultiUrlListResponseModel : PddResponseModel
    {
        
}

}

}
}
