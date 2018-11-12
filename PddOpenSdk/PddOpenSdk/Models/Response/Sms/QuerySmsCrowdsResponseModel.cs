using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Sms
{
    public partial class QuerySmsCrowdsResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("sms_crows_query_response")]
        public SmsCrowsQueryResponseResponseModel SmsCrowsQueryResponse { get; set; }
        public partial class SmsCrowsQueryResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 数量
            /// </summary>
            [JsonProperty("total")]
            public int Total { get; set; }
            /// <summary>
            /// 结果
            /// </summary>
            [JsonProperty("result")]
            public List<ResultResponseModel> Result { get; set; }
            public partial class ResultResponseModel : PddResponseModel
            {
                /// <summary>
                /// 人群id
                /// </summary>
                [JsonProperty("id")]
                public long Id { get; set; }
                /// <summary>
                /// 类型
                /// </summary>
                [JsonProperty("type")]
                public int Type { get; set; }
                /// <summary>
                /// 场景
                /// </summary>
                [JsonProperty("scene")]
                public int Scene { get; set; }
                /// <summary>
                /// 店铺id
                /// </summary>
                [JsonProperty("mall_id")]
                public long MallId { get; set; }
                /// <summary>
                /// 名称
                /// </summary>
                [JsonProperty("name")]
                public string Name { get; set; }
                /// <summary>
                /// 人群数量
                /// </summary>
                [JsonProperty("people_num")]
                public long PeopleNum { get; set; }
                /// <summary>
                /// 人群
                /// </summary>
                [JsonProperty("crowd")]
                public CrowdResponseModel Crowd { get; set; }
                public partial class CrowdResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 对象类型
                    /// </summary>
                    [JsonProperty("location_type")]
                    public int LocationType { get; set; }
                    /// <summary>
                    /// 对象
                    /// </summary>
                    [JsonProperty("location")]
                    public string Location { get; set; }
                    /// <summary>
                    /// 性别
                    /// </summary>
                    [JsonProperty("gender")]
                    public int Gender { get; set; }
                    /// <summary>
                    /// 有购买天数
                    /// </summary>
                    [JsonProperty("purchase_days")]
                    public long PurchaseDays { get; set; }
                    /// <summary>
                    /// 无购买天数
                    /// </summary>
                    [JsonProperty("none_purchase_days")]
                    public long NonePurchaseDays { get; set; }
                    /// <summary>
                    /// 商品被收藏天数
                    /// </summary>
                    [JsonProperty("goods_favor_days")]
                    public long GoodsFavorDays { get; set; }
                    /// <summary>
                    /// 店铺被收藏天数
                    /// </summary>
                    [JsonProperty("mall_favor_days")]
                    public long MallFavorDays { get; set; }
                    /// <summary>
                    /// 最小订单金额
                    /// </summary>
                    [JsonProperty("min_order_count")]
                    public long MinOrderCount { get; set; }
                    /// <summary>
                    /// 最大订单金额
                    /// </summary>
                    [JsonProperty("max_order_count")]
                    public long MaxOrderCount { get; set; }
                    /// <summary>
                    /// 首次购买开始时间
                    /// </summary>
                    [JsonProperty("first_buy_start_time")]
                    public long FirstBuyStartTime { get; set; }
                    /// <summary>
                    /// 首次购买结束时间
                    /// </summary>
                    [JsonProperty("first_buy_end_time")]
                    public long FirstBuyEndTime { get; set; }
                    /// <summary>
                    /// 店铺有浏览天数
                    /// </summary>
                    [JsonProperty("mall_visit_days")]
                    public long MallVisitDays { get; set; }
                    /// <summary>
                    /// 店铺无浏览天数
                    /// </summary>
                    [JsonProperty("mall_none_visit_days")]
                    public long MallNoneVisitDays { get; set; }

                }

            }

        }

    }

}
