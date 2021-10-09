namespace PddOpenSdk.Models.Request.Stock;
public partial class DepotExpressAdd
{

    /// <summary>
    /// 联系人姓名
    /// </summary>
    [JsonPropertyName("contact_name")]
    public string ContactName { get; set; }

    /// <summary>
    /// 仓库详细地址5-20字
    /// </summary>
    [JsonPropertyName("depot_address")]
    public string DepotAddress { get; set; }

    /// <summary>
    /// 别名
    /// </summary>
    [JsonPropertyName("depot_alias")]
    public string DepotAlias { get; set; }

    /// <summary>
    /// 所在市id
    /// </summary>
    [JsonPropertyName("depot_city_id")]
    public int DepotCityId { get; set; }

    /// <summary>
    /// 仓库编码
    /// </summary>
    [JsonPropertyName("depot_code")]
    public string DepotCode { get; set; }

    /// <summary>
    /// 所在区id
    /// </summary>
    [JsonPropertyName("depot_district_id")]
    public int DepotDistrictId { get; set; }

    /// <summary>
    /// 仓库名称
    /// </summary>
    [JsonPropertyName("depot_name")]
    public string DepotName { get; set; }

    /// <summary>
    /// 所在省id
    /// </summary>
    [JsonPropertyName("depot_province_id")]
    public int DepotProvinceId { get; set; }

    /// <summary>
    /// 仓库区域（ 省->市->区id列表）例如：{"34":{"396":[3383]}}Map<Integer, Map<Integer, List<Integer>>>; {; 1:{;   2:[3,4];   }; }
    /// </summary>
    [JsonPropertyName("depot_region")]
    public Dictionary<string, object> DepotRegion { get; set; }

    /// <summary>
    /// 联系人电话
    /// </summary>
    [JsonPropertyName("telephone")]
    public string Telephone { get; set; }

    /// <summary>
    /// 邮编
    /// </summary>
    [JsonPropertyName("zip_code")]
    public string ZipCode { get; set; }
    public partial class DepotRegionModel
    {

        /// <summary>
        /// 省份id
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 市 -> 区id列表
        /// </summary>
        [JsonPropertyName("value")]
        public Dictionary<string, object> Value { get; set; }
        public partial class ValueModel
        {

            /// <summary>
            /// 城市id
            /// </summary>
            [JsonPropertyName("key")]
            public string Key { get; set; }

            /// <summary>
            /// 区id列表
            /// </summary>
            [JsonPropertyName("value")]
            public List<string> Value { get; set; }

        }

    }

}

