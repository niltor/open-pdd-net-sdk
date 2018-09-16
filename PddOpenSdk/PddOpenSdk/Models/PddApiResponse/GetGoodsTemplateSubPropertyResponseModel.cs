using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetGoodsTemplateSubPropertyResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("template_sub_property_get_response")]
public TemplateSubPropertyGetResponseResponseModel TemplateSubPropertyGetResponse {get;set;}

    public partial class TemplateSubPropertyGetResponseResponseModel : PddResponseModel
    {
        
}

}
}
