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
            /// <summary>
            /// 收件省名称
            /// </summary>
            [JsonProperty("receiveProvName")]
            public string ReceiveProvName { get; set; }
            /// <summary>
            /// 收件市名称
            /// </summary>
            [JsonProperty("receiveCityName")]
            public string ReceiveCityName { get; set; }
            /// <summary>
            /// 收件区名称
            /// </summary>
            [JsonProperty("receiveDistrictName")]
            public string ReceiveDistrictName { get; set; }
            /// <summary>
            /// 收件街道名称
            /// </summary>
            [JsonProperty("receiveStreetName")]
            public string ReceiveStreetName { get; set; }
            /// <summary>
            /// 收件详细地址
            /// </summary>
            [JsonProperty("receiveAddrDetail")]
            public string ReceiveAddrDetail { get; set; }
            /// <summary>
            /// 扩展信息； options如果不存在，说明不需要对发货地收货地校验
            /// </summary>
            [JsonProperty("attributes")]
            public string Attributes { get; set; }

        }

    }

}
