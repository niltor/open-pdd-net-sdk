using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class GetLogisticsCompaniesRequestModel : PddRequestModel
    {
        /// <summary>
/// 该值为：pdd.logistics.companies.get
/// </summary>
[JsonProperty("type")]
public string Type {get;set;}
}
}

