namespace PddOpenSdk.Models.Response.Refund;
public partial class RecommendLogisticsAvailableCompanyResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("result")]
        public List<ResultResponse> Result { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 收件人市id
            /// </summary>
            [JsonPropertyName("city_id")]
            public long? CityId { get; set; }

            /// <summary>
            /// 快递公司id
            /// </summary>
            [JsonPropertyName("company_id")]
            public List<long?> CompanyId { get; set; }

        }

    }

}

