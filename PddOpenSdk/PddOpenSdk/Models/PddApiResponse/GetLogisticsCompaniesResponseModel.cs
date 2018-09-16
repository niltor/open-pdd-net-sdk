using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetLogisticsCompaniesResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回的快递公司列表对象
/// </summary>
[JsonProperty("logistics_companies_get_response")]
public object LogisticsCompaniesGetResponse {get;set;}

    public partial class LogisticsCompaniesGetResponseResponseModel : PddResponseModel
    {
        
}

}
}
