using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Logistics
{
    public partial class GetLogisticsCompaniesResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回的快递公司列表对象
        /// </summary>
        [JsonProperty("logistics_companies_get_response")]
        public LogisticsCompaniesGetResponseResponseModel LogisticsCompaniesGetResponse { get; set; }
        public partial class LogisticsCompaniesGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 快递公司列表对象
            /// </summary>
            [JsonProperty("logistics_companies")]
            public List<LogisticsCompaniesResponseModel> LogisticsCompanies { get; set; }
            public partial class LogisticsCompaniesResponseModel : PddResponseModel
            {
                /// <summary>
                /// 是否有效，0-当前不支持的快递公司，1-支持的快递公司，注意：发货时必须入参支持的快递公司id，否则会报错
                /// </summary>
                [JsonProperty("available")]
                public int? Available { get; set; }
                /// <summary>
                /// 快递公司编码
                /// </summary>
                [JsonProperty("id")]
                public long? Id { get; set; }
                /// <summary>
                /// 快递公司名称
                /// </summary>
                [JsonProperty("logistics_company")]
                public string LogisticsCompany { get; set; }
                /// <summary>
                /// 物流公司代码
                /// </summary>
                [JsonProperty("code")]
                public string Code { get; set; }

            }

        }

    }

}
