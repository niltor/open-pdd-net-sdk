using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Express
{
    public partial class GetExpressDepotInfoResponseModel : PddResponseModel
    {
        /// <summary>
        /// 仓库id（string）
        /// </summary>
        [JsonProperty("id_str")]
        public string IdStr { get; set; }
        /// <summary>
        /// 仓库id
        /// </summary>
        [JsonProperty("depot_id")]
        public long? DepotId { get; set; }
        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }
        /// <summary>
        /// 仓库名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// 仓库别名
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; set; }
        /// <summary>
        /// 仓库类型，暂时只有1
        /// </summary>
        [JsonProperty("type")]
        public int? Type { get; set; }
        /// <summary>
        /// 仓库地址（省编号）
        /// </summary>
        [JsonProperty("province")]
        public int? Province { get; set; }
        /// <summary>
        /// 仓库地址（市编号）
        /// </summary>
        [JsonProperty("city")]
        public int? City { get; set; }
        /// <summary>
        /// 仓库地址（区编号）
        /// </summary>
        [JsonProperty("district")]
        public int? District { get; set; }
        /// <summary>
        /// 详细地址
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }
        /// <summary>
        /// 联系人姓名
        /// </summary>
        [JsonProperty("contact_name")]
        public string ContactName { get; set; }
        /// <summary>
        /// 联系人电话
        /// </summary>
        [JsonProperty("contact_tel")]
        public string ContactTel { get; set; }
        /// <summary>
        /// 该仓库覆盖区域列表（其他仓库覆盖区域列表(外层key为省id；cover为该省份覆盖情况：1 半覆盖，2全覆盖；district为省中覆盖的地址：市id->区id列表)）
        /// </summary>
        [JsonProperty("region")]
        public Dictionary<string, object> Region { get; set; }
        /// <summary>
        /// 其他仓库覆盖区域列表（外层key为省id；cover为该省份覆盖情况：1 半覆盖，2全覆盖；district为省中覆盖的地址：市id->区id列表）
        /// </summary>
        [JsonProperty("other_region")]
        public Dictionary<string, object> OtherRegion { get; set; }

    }

}
