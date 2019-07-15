using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Logisticsordertrace
{
    public partial class GetLogisticsOrdertraceRequestModel : PddRequestModel
    {
        /// <summary>
        /// 物流公式编码
        /// </summary>
        [JsonProperty("company_code")]
        public string CompanyCode { get; set; }
        /// <summary>
        /// 运单号
        /// </summary>
        [JsonProperty("mail_no")]
        public string MailNo { get; set; }
        /// <summary>
        /// 是否缓存
        /// </summary>
        [JsonProperty("cache")]
        public bool Cache { get; set; }

    }

}
