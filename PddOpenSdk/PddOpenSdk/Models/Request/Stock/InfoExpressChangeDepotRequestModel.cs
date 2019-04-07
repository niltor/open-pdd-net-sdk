using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Stock
{
    public partial class InfoExpressChangeDepotRequestModel : PddRequestModel {
        /// <summary>
        /// 仓库id
        /// </summary>
        [JsonProperty ("depot_id")]
        public long DepotId { get; set; }
        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonProperty ("depot_code")]
        public string DepotCode { get; set; }
        /// <summary>
        /// 仓库名称
        /// </summary>
        [JsonProperty ("depot_name")]
        public string DepotName { get; set; }
        /// <summary>
        /// 别名
        /// </summary>
        [JsonProperty ("depot_alias")]
        public string DepotAlias { get; set; }
        /// <summary>
        /// 所在省id
        /// </summary>
        [JsonProperty ("depot_province_id")]
        public int DepotProvinceId { get; set; }
        /// <summary>
        /// 所在市id
        /// </summary>
        [JsonProperty ("depot_city_id")]
        public int DepotCityId { get; set; }
        /// <summary>
        /// 所在区id
        /// </summary>
        [JsonProperty ("depot_district_id")]
        public int DepotDistrictId { get; set; }
        /// <summary>
        /// 仓库详细地址 5-20字
        /// </summary>
        [JsonProperty ("depot_address")]
        public string DepotAddress { get; set; }
        /// <summary>
        /// 联系人姓名
        /// </summary>
        [JsonProperty ("contact_name")]
        public string ContactName { get; set; }
        /// <summary>
        /// 联系人电话
        /// </summary>
        [JsonProperty ("telephone")]
        public string Telephone { get; set; }
        /// <summary>
        /// 仓库区域（ 省->市->区id列表）例如：{"34":{"396":[3383]}}Map<Integer, Map<Integer, List<Integer>>>
        /// </summary>
        [JsonProperty ("depot_region")]
        public string DepotRegion { get; set; }

    }

}