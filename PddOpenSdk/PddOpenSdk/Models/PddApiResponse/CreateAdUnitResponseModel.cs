using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class CreateAdUnitResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回response
/// </summary>
[JsonProperty("ad_unit_create_response")]
public object AdUnitCreateResponse {get;set;}

    public partial class AdUnitCreateResponseResponseModel : PddResponseModel
    {
        
}

}
}
