namespace PddOpenSdk.Models.Response.Stock;
public partial class GetExpressDepotInfoResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("open_api_response")]
    public OpenApiResponseResponse OpenApiResponse { get; set; }
    public partial class OpenApiResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 详细地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 仓库别名
        /// </summary>
        [JsonPropertyName("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 仓库地址（市编号）
        /// </summary>
        [JsonPropertyName("city")]
        public int? City { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        [JsonPropertyName("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [JsonPropertyName("contact_tel")]
        public string ContactTel { get; set; }

        /// <summary>
        /// 仓库id
        /// </summary>
        [JsonPropertyName("depot_id")]
        public long? DepotId { get; set; }

        /// <summary>
        /// 仓库地址（区编号）
        /// </summary>
        [JsonPropertyName("district")]
        public int? District { get; set; }

        /// <summary>
        /// 仓库id（string）
        /// </summary>
        [JsonPropertyName("id_str")]
        public string IdStr { get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 其他仓库覆盖区域列表（外层key为省id；cover为该省份覆盖情况：1 半覆盖，2全覆盖；district为省中覆盖的地址：市id->区id列表）
        /// </summary>
        [JsonPropertyName("other_region")]
        public Dictionary<string, object> OtherRegion { get; set; }

        /// <summary>
        /// 仓库地址（省编号）
        /// </summary>
        [JsonPropertyName("province")]
        public int? Province { get; set; }

        /// <summary>
        /// 该仓库覆盖区域列表（其他仓库覆盖区域列表(外层key为省id；cover为该省份覆盖情况：1 半覆盖，2全覆盖；district为省中覆盖的地址：市id->区id列表)）
        /// </summary>
        [JsonPropertyName("region")]
        public Dictionary<string, object> Region { get; set; }

        /// <summary>
        /// 仓库类型，暂时只有1
        /// </summary>
        [JsonPropertyName("type")]
        public int? Type { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        [JsonPropertyName("zip")]
        public string Zip { get; set; }
        public partial class OtherRegionResponse : PddResponseModel
        {

            /// <summary>
            /// 省份id
            /// </summary>
            [JsonPropertyName("$key")]
            public string Key { get; set; }

            /// <summary>
            /// 省份信息
            /// </summary>
            [JsonPropertyName("$value")]
            public ValueResponse Value { get; set; }
            public partial class ValueResponse : PddResponseModel
            {

                /// <summary>
                /// 1 半覆盖，2 全覆盖
                /// </summary>
                [JsonPropertyName("cover")]
                public int? Cover { get; set; }

                /// <summary>
                /// 城市id -> 区id列表
                /// </summary>
                [JsonPropertyName("district")]
                public Dictionary<string, object> District { get; set; }
                public partial class DistrictResponse : PddResponseModel
                {

                    /// <summary>
                    /// 城市id
                    /// </summary>
                    [JsonPropertyName("$key")]
                    public string Key { get; set; }

                    /// <summary>
                    /// 区id列表
                    /// </summary>
                    [JsonPropertyName("$value")]
                    public List<int?> Value { get; set; }

                }

            }

        }
        public partial class RegionResponse : PddResponseModel
        {

            /// <summary>
            /// 省份id
            /// </summary>
            [JsonPropertyName("$key")]
            public string Key { get; set; }

            /// <summary>
            /// 省份信息
            /// </summary>
            [JsonPropertyName("$value")]
            public ValueResponse Value { get; set; }
            public partial class ValueResponse : PddResponseModel
            {

                /// <summary>
                /// 1 半覆盖，2 全覆盖
                /// </summary>
                [JsonPropertyName("cover")]
                public int? Cover { get; set; }

                /// <summary>
                /// 城市id -> 区id列表
                /// </summary>
                [JsonPropertyName("district")]
                public Dictionary<string, object> District { get; set; }
                public partial class DistrictResponse : PddResponseModel
                {

                    /// <summary>
                    /// 城市id
                    /// </summary>
                    [JsonPropertyName("$key")]
                    public string Key { get; set; }

                    /// <summary>
                    /// 区id列表
                    /// </summary>
                    [JsonPropertyName("$value")]
                    public List<string> Value { get; set; }

                }

            }

        }

    }

}

