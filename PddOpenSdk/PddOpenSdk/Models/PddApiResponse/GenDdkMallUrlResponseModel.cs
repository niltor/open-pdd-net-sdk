using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GenDdkMallUrlResponseModel : PddResponseModel
    {
        /// <summary>
/// 推广链接
/// </summary>
[JsonProperty("list")]
public object List {get;set;}

    public partial class ListResponseModel : PddResponseModel
    {
        
}

}
}
