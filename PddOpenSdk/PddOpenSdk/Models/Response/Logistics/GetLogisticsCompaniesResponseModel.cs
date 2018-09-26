using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Logistics
{
    public class LogisticsCompany
    {

        /// <summary>
        /// Examples: "1"
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Examples: "申通快递"
        /// </summary>
        [JsonProperty("logistics_company")]
        public string LogisticsCompany { get; set; }
    }

    public class LogisticsCompaniesGetResponse
    {

        /// <summary>
        /// Examples: [{"id":"1","logistics_company":"申通快递"}]
        /// </summary>
        [JsonProperty("logistics_companies")]
        public IList<LogisticsCompany> LogisticsCompanies { get; set; }
    }

    public class GetLogisticsCompaniesResponseModel
    {

        /// <summary>
        /// Examples: {"logistics_companies":[{"id":"1","logistics_company":"申通快递"}]}
        /// </summary>
        [JsonProperty("logistics_companies_get_response")]
        public LogisticsCompaniesGetResponse LogisticsCompaniesGetResponse { get; set; }
    }


}
