namespace PddOpenSdk.Models.Response.Refund;
public partial class GetLogisticsAddressResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("logistics_address_get_response")]
    public LogisticsAddressGetResponseResponse LogisticsAddressGetResponse { get; set; }
    public partial class LogisticsAddressGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 地址对象列表
        /// </summary>
        [JsonPropertyName("logistics_address_list")]
        public List<LogisticsAddressListResponse> LogisticsAddressList { get; set; }
        public partial class LogisticsAddressListResponse : PddResponseModel
        {

            /// <summary>
            /// 地区ID
            /// </summary>
            [JsonPropertyName("id")]
            public long? Id { get; set; }

            /// <summary>
            /// 是否有效，0-无效，1-有效
            /// </summary>
            [JsonPropertyName("is_enabled")]
            public int? IsEnabled { get; set; }

            /// <summary>
            /// 地区邮编
            /// </summary>
            [JsonPropertyName("national_code")]
            public string NationalCode { get; set; }

            /// <summary>
            /// 父地区ID，顶点id为0
            /// </summary>
            [JsonPropertyName("parent_id")]
            public long? ParentId { get; set; }

            /// <summary>
            /// 地区名称
            /// </summary>
            [JsonPropertyName("region_name")]
            public string RegionName { get; set; }

            /// <summary>
            /// 地区层级，1-省份，2-市级，3-区级
            /// </summary>
            [JsonPropertyName("region_type")]
            public int? RegionType { get; set; }

        }

    }

}

