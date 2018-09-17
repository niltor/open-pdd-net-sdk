using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class GetLogisticsCompaniesRequestModel : PddRequestModel
    {
        /// <summary>
        /// 该值为：pdd.logistics.companies.get
        /// </summary>
        [JsonProperty("type")]
        public object Type { get; set; }

    }
}
