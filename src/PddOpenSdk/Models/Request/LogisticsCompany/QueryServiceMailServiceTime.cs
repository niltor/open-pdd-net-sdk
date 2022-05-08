namespace PddOpenSdk.Models.Request.LogisticsCompany;
public partial class QueryServiceMailServiceTime
{

    /// <summary>
    /// 请求参数
    /// </summary>
    [JsonPropertyName("request")]
    public RequestModel Request { get; set; }
    public partial class RequestModel
    {

        /// <summary>
        /// 省名称
        /// </summary>
        [JsonPropertyName("provName")]
        public string ProvName { get; set; }

        /// <summary>
        /// 市名称
        /// </summary>
        [JsonPropertyName("cityName")]
        public string CityName { get; set; }

        /// <summary>
        /// 区名称
        /// </summary>
        [JsonPropertyName("districtName")]
        public string DistrictName { get; set; }

        /// <summary>
        /// 街道名称
        /// </summary>
        [JsonPropertyName("streetName")]
        public string StreetName { get; set; }

        /// <summary>
        /// 寄件类型
        /// </summary>
        [JsonPropertyName("postType")]
        public string PostType { get; set; }

        /// <summary>
        /// 收件省名称
        /// </summary>
        [JsonPropertyName("receiveProvName")]
        public string ReceiveProvName { get; set; }

        /// <summary>
        /// 收件市名称
        /// </summary>
        [JsonPropertyName("receiveCityName")]
        public string ReceiveCityName { get; set; }

        /// <summary>
        /// 收件区名称
        /// </summary>
        [JsonPropertyName("receiveDistrictName")]
        public string ReceiveDistrictName { get; set; }

        /// <summary>
        /// 收件街道名称
        /// </summary>
        [JsonPropertyName("receiveStreetName")]
        public string ReceiveStreetName { get; set; }

        /// <summary>
        /// 收件详细地址
        /// </summary>
        [JsonPropertyName("receiveAddrDetail")]
        public string ReceiveAddrDetail { get; set; }

        /// <summary>
        /// 扩展信息； options如果不存在，说明不需要对发货地收货地校验
        /// </summary>
        [JsonPropertyName("attributes")]
        public string Attributes { get; set; }

    }

}

