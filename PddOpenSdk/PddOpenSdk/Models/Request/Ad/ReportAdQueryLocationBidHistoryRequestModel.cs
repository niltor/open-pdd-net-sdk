using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class ReportAdQueryLocationBidHistoryRequestModel : PddRequestModel {
        /// <summary>
        /// 推广类型  2-展示推广
        /// </summary>
        [JsonProperty ("scene_type")]
        public int SceneType { get; set; }
        /// <summary>
        /// 分天数据查询时必填 单元Id
        /// </summary>
        [JsonProperty ("unit_id")]
        public long? UnitId { get; set; }
        /// <summary>
        /// 计划ID
        /// </summary>
        [JsonProperty ("planId")]
        public long? Planid { get; set; }
        /// <summary>
        /// 分天数据查询时必填，资源位类型，0：基础流量包，1：类目商品页，2：商品详情页，3：营销活动页
        /// </summary>
        [JsonProperty ("location_type")]
        public int LocationType { get; set; }
        /// <summary>
        /// 汇总报表查询时必填，资源位类型列表，多个资源位以逗号隔开
        /// </summary>
        [JsonProperty ("location_types")]
        public string LocationTypes { get; set; }
        /// <summary>
        /// 聚合方式，1-日期，2-实体
        /// </summary>
        [JsonProperty ("group_by")]
        public int GroupBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty ("page_request")]
        public PageRequestRequestModel PageRequest { get; set; }
        /// <summary>
        /// 起始日期 "2018-11-01"
        /// </summary>
        [JsonProperty ("begin_date")]
        public string BeginDate { get; set; }
        /// <summary>
        /// 结束日期 "2018-11-01"
        /// </summary>
        [JsonProperty ("end_date")]
        public string EndDate { get; set; }
        /// <summary>
        /// 排序字段 默认DATE（8）; 0 - IMPR_NUM - 曝光量排序、; 1 - CLK_NUM - 点击量排序; 2 - CLK_RATE - 点击率; 3 - CPC - 点击单价排序; 4 - SPEND - 消耗排序; 5 - PAY_ORDER_NUM - 订单数排序; 6 - PAY_GVM - 交易额排序; 7 - ROI - 产出比排序; 8 - DATE - 日期; 9 - CPM - 千次曝光单价; 10 - FAV_MALL - 店铺收藏数
        /// </summary>
        [JsonProperty ("order_by")]
        public int OrderBy { get; set; }
        /// <summary>
        /// 排序方式  默认降序（0） ; 0 - DESC - 降序; 1 - ASC - 升序
        /// </summary>
        [JsonProperty ("sort_by")]
        public int SortBy { get; set; }
        public partial class PageRequestRequestModel : PddRequestModel {
            /// <summary>
            /// 页码 默认 1
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