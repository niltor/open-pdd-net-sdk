namespace PddOpenSdk.Models.Response.Logistics;
public partial class GetLogisticsCompaniesResponse : PddResponseModel
{

    /// <summary>
    /// 返回的快递公司列表对象
    /// </summary>
    [JsonPropertyName("logistics_companies_get_response")]
    public LogisticsCompaniesGetResponseResponse LogisticsCompaniesGetResponse { get; set; }
    public partial class LogisticsCompaniesGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 快递公司列表对象
        /// </summary>
        [JsonPropertyName("logistics_companies")]
        public List<LogisticsCompaniesResponse> LogisticsCompanies { get; set; }
        public partial class LogisticsCompaniesResponse : PddResponseModel
        {

            /// <summary>
            /// 是否有效，0-当前不支持的快递公司，1-支持的快递公司，注意：发货时必须入参支持的快递公司id，否则会报错
            /// </summary>
            [JsonPropertyName("available")]
            public int? Available { get; set; }

            /// <summary>
            /// 快递公司编码
            /// </summary>
            [JsonPropertyName("id")]
            public long? Id { get; set; }

            /// <summary>
            /// 快递公司名称
            /// </summary>
            [JsonPropertyName("logistics_company")]
            public string LogisticsCompany { get; set; }

            /// <summary>
            /// 物流公司代码
            /// </summary>
            [JsonPropertyName("code")]
            public string Code { get; set; }

        }

    }

}

