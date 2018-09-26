using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Logistics
{
    public partial class GetLogisticsCompaniesRequestModel : PddRequestModel
    {
        /// <summary>
        /// 该值为：pdd.logistics.companies.get
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

    }

}
