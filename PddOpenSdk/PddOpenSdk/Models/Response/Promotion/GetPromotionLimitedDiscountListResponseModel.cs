using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Promotion
{
    public partial class GetPromotionLimitedDiscountListResponseModel : PddResponseModel
    {
        /// <summary>
        /// 还在线（包括已开始和未开始）的活动数量
        /// </summary>
        [JsonProperty("online_sum")]
        public long? OnlineSum { get; set; }
        /// <summary>
        /// 活动信息
        /// </summary>
        [JsonProperty("open_goods_activity_list")]
        public List<OpenGoodsActivityListResponseModel> OpenGoodsActivityList { get; set; }
        /// <summary>
        /// 0:生成时间升序  1:生成时间降序
        /// </summary>
        [JsonProperty("order")]
        public int? Order { get; set; }
        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("page_no")]
        public long? PageNo { get; set; }
        /// <summary>
        /// 页大小
        /// </summary>
        [JsonProperty("page_size")]
        public long? PageSize { get; set; }
        /// <summary>
        /// 报名的活动总量
        /// </summary>
        [JsonProperty("record_sum")]
        public long? RecordSum { get; set; }
        public partial class OpenGoodsActivityListResponseModel : PddResponseModel
        {
            /// <summary>
            /// 活动id
            /// </summary>
            [JsonProperty("activity_id")]
            public long? ActivityId { get; set; }
            /// <summary>
            /// 活动名称
            /// </summary>
            [JsonProperty("activity_name")]
            public string ActivityName { get; set; }
            /// <summary>
            /// 活动类型
            /// </summary>
            [JsonProperty("activity_type")]
            public int? ActivityType { get; set; }
            /// <summary>
            /// 结束操作来源：  0: 活动时间到了，活动结束  1: 商家在MMS后台人为点击结束  2: 活动被系统结束
            /// </summary>
            [JsonProperty("end_operation_source")]
            public int? EndOperationSource { get; set; }
            /// <summary>
            /// 结束时间（单位：s）
            /// </summary>
            [JsonProperty("end_time")]
            public long? EndTime { get; set; }
            /// <summary>
            /// 商品id
            /// </summary>
            [JsonProperty("goods_id")]
            public long? GoodsId { get; set; }
            /// <summary>
            /// 商品名称
            /// </summary>
            [JsonProperty("goods_name")]
            public string GoodsName { get; set; }
            /// <summary>
            /// 商品剩余库存
            /// </summary>
            [JsonProperty("online_quantity")]
            public long? OnlineQuantity { get; set; }
            /// <summary>
            /// 价格信息
            /// </summary>
            [JsonProperty("price_info")]
            public List<PriceInfoResponseModel> PriceInfo { get; set; }
            /// <summary>
            /// 开始时间（单位：s）
            /// </summary>
            [JsonProperty("start_time")]
            public long? StartTime { get; set; }
            /// <summary>
            /// 活动状态
            /// </summary>
            [JsonProperty("status")]
            public int? Status { get; set; }
            public partial class PriceInfoResponseModel : PddResponseModel
            {
                /// <summary>
                /// 活动报名库存
                /// </summary>
                [JsonProperty("activity_quantity")]
                public long? ActivityQuantity { get; set; }
                /// <summary>
                /// 活动剩余库存
                /// </summary>
                [JsonProperty("activity_stock_quantity")]
                public long? ActivityStockQuantity { get; set; }
                /// <summary>
                /// 活动 ID
                /// </summary>
                [JsonProperty("detail_id")]
                public long? DetailId { get; set; }
                /// <summary>
                /// 折扣比例。实际折扣为：discount/1000，例如：300表示3折
                /// </summary>
                [JsonProperty("discount")]
                public long? Discount { get; set; }
                /// <summary>
                /// 折扣范围
                /// </summary>
                [JsonProperty("discount_range")]
                public string DiscountRange { get; set; }
                /// <summary>
                /// 最大的sku活动拼团价
                /// </summary>
                [JsonProperty("max_pre_sale_price")]
                public long? MaxPreSalePrice { get; set; }
                /// <summary>
                /// 最小的sku活动拼团价
                /// </summary>
                [JsonProperty("min_pre_sale_price")]
                public long? MinPreSalePrice { get; set; }
                /// <summary>
                /// sku维度的活动信息
                /// </summary>
                [JsonProperty("open_sku_prices")]
                public List<OpenSkuPricesResponseModel> OpenSkuPrices { get; set; }
                /// <summary>
                /// 活动价生效时用户限购数量 0:不限购
                /// </summary>
                [JsonProperty("user_activity_limit")]
                public long? UserActivityLimit { get; set; }
                public partial class OpenSkuPricesResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 活动拼团价（单位：分）
                    /// </summary>
                    [JsonProperty("activity_price")]
                    public long? ActivityPrice { get; set; }
                    /// <summary>
                    /// 折扣比例
                    /// </summary>
                    [JsonProperty("discount")]
                    public string Discount { get; set; }
                    /// <summary>
                    /// 原拼团价（单位：分）
                    /// </summary>
                    [JsonProperty("group_price")]
                    public long? GroupPrice { get; set; }
                    /// <summary>
                    /// skuid
                    /// </summary>
                    [JsonProperty("sku_id")]
                    public long? SkuId { get; set; }
                    /// <summary>
                    /// sku名称
                    /// </summary>
                    [JsonProperty("sku_name")]
                    public string SkuName { get; set; }

                }

            }

        }

    }

}
