using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GenerateDdkRpPromUrlResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回链接
/// </summary>
[JsonProperty("url_list")]
public object UrlList {get;set;}

    public partial class UrlListResponseModel : PddResponseModel
    {
        
}

}
}
