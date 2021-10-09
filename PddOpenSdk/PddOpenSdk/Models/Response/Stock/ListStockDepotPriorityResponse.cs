namespace PddOpenSdk.Models.Response.Stock;
public partial class ListStockDepotPriorityResponse : PddResponseModel
{

    /// <summary>
    /// 响应内容
    /// </summary>
    [JsonPropertyName("open_api_response")]
    public OpenApiResponseResponse OpenApiResponse { get; set; }
    public partial class OpenApiResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 总数
        /// </summary>
        [JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// 仓库列表
        /// </summary>
        [JsonPropertyName("depot_list")]
        public List<DepotListResponse> DepotList { get; set; }
        public partial class DepotListResponse : PddResponseModel
        {

            /// <summary>
            /// 仓库id
            /// </summary>
            [JsonPropertyName("depot_id")]
            public string DepotId { get; set; }

            /// <summary>
            /// 仓库地址（省编号）
            /// </summary>
            [JsonPropertyName("province_id")]
            public int? ProvinceId { get; set; }

            /// <summary>
            /// 仓库地址（市编号）
            /// </summary>
            [JsonPropertyName("city_id")]
            public int? CityId { get; set; }

            /// <summary>
            /// 仓库地址（区编号）
            /// </summary>
            [JsonPropertyName("district_id")]
            public int? DistrictId { get; set; }

            /// <summary>
            /// 仓库编码
            /// </summary>
            [JsonPropertyName("depot_code")]
            public string DepotCode { get; set; }

            /// <summary>
            /// 仓库名称
            /// </summary>
            [JsonPropertyName("depot_name")]
            public string DepotName { get; set; }

            /// <summary>
            /// 优先级
            /// </summary>
            [JsonPropertyName("priority")]
            public int? Priority { get; set; }

        }

    }

}

