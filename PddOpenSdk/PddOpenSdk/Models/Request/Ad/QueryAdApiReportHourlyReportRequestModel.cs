using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class QueryAdApiReportHourlyReportRequestModel : PddRequestModel
    {
        /// <summary>
        /// 查询日期的字符串，格式类似'2020-02-02',当前支持查询30天内数据
        /// </summary>
        [JsonProperty("dateString")]
        public string DateString { get; set; }
        /// <summary>
        /// 各维度查询的主体id，查询计划维度传计划id，查询单元维度传单元id
        /// </summary>
        [JsonProperty("entityId")]
        public long? EntityId { get; set; }
        /// <summary>
        /// 查询维度，0-广告主，1-计划，2-单元,当前只支持到单元维度
        /// </summary>
        [JsonProperty("queryDimensionType")]
        public int QueryDimensionType { get; set; }
        /// <summary>
        /// 场景类型,0-搜索，2-场景展示
        /// </summary>
        [JsonProperty("scenesType")]
        public int ScenesType { get; set; }

    }

}
