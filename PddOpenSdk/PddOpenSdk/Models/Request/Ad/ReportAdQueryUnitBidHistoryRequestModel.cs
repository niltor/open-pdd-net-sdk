using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class ReportAdQueryUnitBidHistoryRequestModel : PddRequestModel
    {
        /// <summary>
        /// 推广类型  2-展示推广
        /// </summary>
        [JsonProperty("scene_type")]
        public int SceneType { get; set; }
        /// <summary>
        /// 单元id ，分天查询时必填
        /// </summary>
        [JsonProperty("unit_id")]
        public long? UnitId { get; set; }
        /// <summary>
        /// 计划id
        /// </summary>
        [JsonProperty("plan_id")]
        public long? PlanId { get; set; }
        /// <summary>
        /// 数据聚合方式（1 - 日期，2 - 实体 Id）
        /// </summary>
        [JsonProperty("group_by")]
        public int GroupBy { get; set; }
        /// <summary>
        /// 分定向类型。分天查询时必填。1表示通投，2表示访客重定向，3表示相似商品定向，4表示叶子类目定向，5表示相似店铺定向，6表示兴趣点定向，7表示人群包定向，8表示地域定向人群，9表示商品高潜人群，10表示高品质商品偏好人群，11表示大促偏好人群，12表示爱分享人群
        /// </summary>
        [JsonProperty("target_type")]
        public int TargetType { get; set; }
        /// <summary>
        /// 分天查询时必填 兴趣点ID，targetType不为6/7时，传 0
        /// </summary>
        [JsonProperty("sub_level_target_id")]
        public long? SubLevelTargetId { get; set; }
        /// <summary>
        /// 定向类型列表。汇总报销必填。多个定向以英文逗号隔开，值所代表的含义参见target_type字段
        /// </summary>
        [JsonProperty("target_types")]
        public string TargetTypes { get; set; }
        /// <summary>
        /// page_request
        /// </summary>
        [JsonProperty("page_request")]
        public PageRequestRequestModel PageRequest { get; set; }
        /// <summary>
        /// 起始日期 2018-09-28
        /// </summary>
        [JsonProperty("begin_date")]
        public string BeginDate { get; set; }
        /// <summary>
        /// 结束日期 2018-09-28
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }
        /// <summary>
        /// 排序字段 默认DATE（8）; 0 - IMPR_NUM - 曝光量排序、; 1 - CLK_NUM - 点击量排序; 2 - CLK_RATE - 点击率; 3 - CPC - 点击单价排序; 4 - SPEND - 消耗排序; 5 - PAY_ORDER_NUM - 订单数排序; 6 - PAY_GVM - 交易额排序; 7 - ROI - 产出比排序; 8 - DATE - 日期; 9 - CPM - 千次曝光单价; 10 - FAV_MALL - 店铺收藏数
        /// </summary>
        [JsonProperty("order_by")]
        public int? OrderBy { get; set; }
        /// <summary>
        /// 排序方式 默认降序（0）; 0 - DESC - 降序; 1 - ASC - 升序
        /// </summary>
        [JsonProperty("sort_by")]
        public int? SortBy { get; set; }
        public partial class PageRequestRequestModel : PddRequestModel
        {
            /// <summary>
            /// 页码 默认 1
            /// </summary>
            [JsonProperty("page_number")]
            public int? PageNumber { get; set; }
            /// <summary>
            /// 单页记录数 默认 10
            /// </summary>
            [JsonProperty("page_size")]
            public int? PageSize { get; set; }

        }

    }

}
