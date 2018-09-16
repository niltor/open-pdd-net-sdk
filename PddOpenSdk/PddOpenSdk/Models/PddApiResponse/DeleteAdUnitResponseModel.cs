using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class DeleteAdUnitResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回response
/// </summary>
[JsonProperty("ad_unit_delete_response")]
public object AdUnitDeleteResponse {get;set;}

    public partial class AdUnitDeleteResponseResponseModel : PddResponseModel
    {
        
}

}
}
