using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class QueryAdApiReportEntityReportRequestModel : PddRequestModel
    {
        /// <summary>
        /// 结束日期的字符串，格式类似'2020-02-02'，当前支持查询90天内数据
        /// </summary>
        [JsonProperty("endDateString")]
        public string EndDateString { get; set; }
        /// <summary>
        /// entityId的维度(当前只支持0-广告主，1-计划，2-单元维度),例如根据单元查询资源位的分级数据，entityId传单元id，entityDimensionType传单元维度，queryDimensionType传资源位维度
        /// </summary>
        [JsonProperty("entityDimensionType")]
        public int? EntityDimensionType { get; set; }
        /// <summary>
        /// 各维度查询的主体id，查询计划维度传计划id，查询单元维度传单元id
        /// </summary>
        [JsonProperty("entityId")]
        public long? EntityId { get; set; }
        /// <summary>
        /// 额外的查询条件，entityDimensionType维度为单元时，须加上父级计划id（planId）的信息
        /// </summary>
        [JsonProperty("externalParamMap")]
        public Dictionary<string, object> ExternalParamMap { get; set; }
        /// <summary>
        /// 排序规则，0-曝光，1-点击，2-点击率，3-cpc,4-花费，5-订单量,6-gmv，7-roi,8-日期，9-cpm,10-店铺收藏，11-商品收藏
        /// </summary>
        [JsonProperty("orderBy")]
        public int? OrderBy { get; set; }
        /// <summary>
        /// 排序顺序，0-降序，1-升序
        /// </summary>
        [JsonProperty("orderType")]
        public int? OrderType { get; set; }
        /// <summary>
        /// 查询维度，0-广告主，1-计划，2-单元，3-定向，4-创意，5-资源位，6-关键词
        /// </summary>
        [JsonProperty("queryDimensionType")]
        public int QueryDimensionType { get; set; }
        /// <summary>
        /// 分页字段,不传不分页
        /// </summary>
        [JsonProperty("queryRange")]
        public QueryRangeRequestModel QueryRange { get; set; }
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
        public partial class QueryRangeRequestModel : PddRequestModel
        {
            /// <summary>
            /// 页数
            /// </summary>
            [JsonProperty("pageNumber")]
            public int PageNumber { get; set; }
            /// <summary>
            /// 每页的数量
            /// </summary>
            [JsonProperty("pageSize")]
            public int PageSize { get; set; }

        }

    }

}
