namespace PddOpenSdk.Models.Request.Stock;
public partial class UpdateStockDepotPriority
{

    /// <summary>
    /// 示例：[{"depot_id":1,"province_id":12,"city_id":34,"district_id":56,"priority":5}]
    /// </summary>
    [JsonPropertyName("priority_list")]
    public List<PriorityListModel> PriorityList { get; set; }
    public partial class PriorityListModel
    {

        /// <summary>
        /// 优先级 范围是1 - 999
        /// </summary>
        [JsonPropertyName("priority")]
        public int Priority { get; set; }

        /// <summary>
        /// 区id
        /// </summary>
        [JsonPropertyName("district_id")]
        public int DistrictId { get; set; }

        /// <summary>
        /// 市id
        /// </summary>
        [JsonPropertyName("city_id")]
        public int CityId { get; set; }

        /// <summary>
        /// 省id
        /// </summary>
        [JsonPropertyName("province_id")]
        public int ProvinceId { get; set; }

        /// <summary>
        /// 仓库id
        /// </summary>
        [JsonPropertyName("depot_id")]
        public long DepotId { get; set; }

    }

}

