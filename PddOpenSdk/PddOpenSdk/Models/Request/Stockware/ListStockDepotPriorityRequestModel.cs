using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Stockware
{
    public partial class ListStockDepotPriorityRequestModel : PddRequestModel
    {
        /// <summary>
        /// 省id
        /// </summary>
        [JsonProperty("province_id")]
        public int? ProvinceId { get; set; }
        /// <summary>
        /// 市id
        /// </summary>
        [JsonProperty("city_id")]
        public int? CityId { get; set; }
        /// <summary>
        /// 区id
        /// </summary>
        [JsonProperty("district_id")]
        public int? DistrictId { get; set; }
        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonProperty("depot_code")]
        public string DepotCode { get; set; }
        /// <summary>
        /// 每页数据显示数量
        /// </summary>
        [JsonProperty("page_size")]
        public int PageSize { get; set; }
        /// <summary>
        /// 当前页数 从1开始
        /// </summary>
        [JsonProperty("page_num")]
        public int PageNum { get; set; }

    }

}
