using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class QueryAdApiReportDailyReportRequestModel : PddRequestModel
    {
        /// <summary>
        /// 结束日期的字符串，格式类似'2020-02-02'，当前支持查询90天内数据
        /// </summary>
        [JsonProperty("endDateString")]
        public string EndDateString { get; set; }
        /// <summary>
        /// 各维度查询的主体id，查询计划维度传计划id，查询单元维度传单元id，查询关键词维度传关键词id，查询创意传创意id，查询广告主维度，资源位和定向维度不用传此参数
        /// </summary>
        [JsonProperty("entityId")]
        public long? EntityId { get; set; }
        /// <summary>
        /// 额外的查询条件，查询关键词，创意维度的的时候要在此传单元id(adId)的信息，查询资源位的时候要传单元id(adId）和资源位类型(bidReferenceId),查询定向维度要传单元id(adId),定向类型(bidReferenceId)，如果是查二级定向，需要传二级定向id(subBidReferenceId)
        /// </summary>
        [JsonProperty("externalParamMap")]
        public Dictionary<string, object> ExternalParamMap { get; set; }
        /// <summary>
        /// 查询维度，0-广告主，1-计划，2-单元，3-定向，4-创意，5-资源位，6-关键词
        /// </summary>
        [JsonProperty("queryDimensionType")]
        public int QueryDimensionType { get; set; }
        /// <summary>
        /// 场景类型,0-搜索，2-场景展示
        /// </summary>
        [JsonProperty("scenesType")]
        public int ScenesType { get; set; }
        /// <summary>
        /// 开始日期的字符串，格式类似'2020-02-02'，如果查询今日，startDateString和endDateString传今日的字符串，如果查询历史，startDateString和endDateString分别传开始和结束字符串，不能跨今日和历史查询
        /// </summary>
        [JsonProperty("startDateString")]
        public string StartDateString { get; set; }
        public partial class ExternalParamMapRequestModel : PddRequestModel
        {
            /// <summary>
            /// key
            /// </summary>
            [JsonProperty("$key")]
            public string Key { get; set; }
            /// <summary>
            /// value
            /// </summary>
            [JsonProperty("$value")]
            public string Value { get; set; }

        }

    }

}
