using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class GetAdCreativeHistoryReportRequestModel : PddRequestModel {
        /// <summary>
        /// 创意ID, 分天数据必填，汇总表数据无需填
        /// </summary>
        [JsonProperty ("creative_id")]
        public long? CreativeId { get; set; }
        /// <summary>
        /// 单元ID, 分天数据无需填，汇总表数据选填
        /// </summary>
        [JsonProperty ("unit_id")]
        public long? UnitId { get; set; }
        /// <summary>
        /// 计划ID, 分天数据无需填，汇总表数据选填
        /// </summary>
        [JsonProperty ("plan_id")]
        public long? PlanId { get; set; }
        /// <summary>
        /// 数据聚合方式（1 - 日期，2 - 实体 Id）
        /// </summary>
        [JsonProperty ("group_by")]
        public int GroupBy { get; set; }
        /// <summary>
        /// 分页参数
        /// </summary>
        [JsonProperty ("page_request")]
        public PageRequestRequestModel PageRequest { get; set; }
        /// <summary>
        /// 开始日期，示例："2018-11-04"
        /// </summary>
        [JsonProperty ("begin_date")]
        public string BeginDate { get; set; }
        /// <summary>
        /// 结束日期，示例："2018-11-04"
        /// </summary>
        [JsonProperty ("end_date")]
        public string EndDate { get; set; }
        /// <summary>
        /// 排序字段  默认DATE（8）; 0 - IMPR_NUM - 曝光量排序、; 1 - CLK_NUM - 点击量排序; 2 - CLK_RATE - 点击率; 3 - CPC - 点击单价排序; 4 - SPEND - 消耗排序; 5 - PAY_ORDER_NUM - 订单数排序; 6 - PAY_GVM - 交易额排序; 7 - ROI - 产出比排序; 8 - DATE - 日期; 9 - CPM - 千次曝光单价; 10 - FAV_MALL - 店铺收藏数
        /// </summary>
        [JsonProperty ("order_by")]
        public int OrderBy { get; set; }
        /// <summary>
        /// 排序方式 默认降序（0）; 0 - DESC - 降序; 1 - ASC - 升序
        /// </summary>
        [JsonProperty ("sort_by")]
        public int SortBy { get; set; }
        /// <summary>
        /// 推广类型，0-搜索推广，2-展示推广
        /// </summary>
        [JsonProperty ("scene_type")]
        public int SceneType { get; set; }
        public partial class PageRequestRequestModel : PddRequestModel {
            /// <summary>
            /// 页码，默认 1
            /// </summary>
            [JsonProperty ("page_number")]
            public int PageNumber { get; set; }
            /// <summary>
            /// 单页记录数 默认 10
            /// </summary>
            [JsonProperty ("page_size")]
            public int PageSize { get; set; }

        }

    }

}