using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Logistics
{
    public partial class GetLogisticsOrdertraceRequestModel : PddRequestModel
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("company_code")]
        public string CompanyCode { get; set; }
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("mail_no")]
        public string MailNo { get; set; }

    }

}
