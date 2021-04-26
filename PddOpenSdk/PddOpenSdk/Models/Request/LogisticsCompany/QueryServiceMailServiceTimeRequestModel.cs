using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.LogisticsCompany
{
    public partial class QueryServiceMailServiceTimeRequestModel : PddRequestModel
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        [JsonProperty("request")]
        public RequestRequestModel Request { get; set; }
        public partial class RequestRequestModel : PddRequestModel
        {
            /// <summary>
            /// 省名称
            /// </summary>
            [JsonProperty("provName")]
            public string ProvName { get; set; }
            /// <summary>
            /// 市名称
            /// </summary>
            [JsonProperty("cityName")]
            public string CityName { get; set; }
            /// <summary>
            /// 区名称
            /// </summary>
            [JsonProperty("districtName")]
            public string DistrictName { get; set; }
            /// <summary>
            /// 街道名称
            /// </summary>
            [JsonProperty("streetName")]
            public string StreetName { get; set; }
            /// <summary>
            /// 寄件类型
            /// </summary>
            [JsonProperty("postType")]
            public string PostType { get; set; }

        }

    }

}
