namespace PddOpenSdk.Models.Response.Promotion;
public partial class GetPromotionLimitedDiscountListResponse : PddResponseModel
{

    /// <summary>
    /// 还在线（包括已开始和未开始）的活动数量
    /// </summary>
    [JsonPropertyName("online_sum")]
    public long? OnlineSum { get; set; }

    /// <summary>
    /// 活动信息
    /// </summary>
    [JsonPropertyName("open_goods_activity_list")]
    public List<OpenGoodsActivityListResponse> OpenGoodsActivityList { get; set; }

    /// <summary>
    /// 0:生成时间升序  1:生成时间降序
    /// </summary>
    [JsonPropertyName("order")]
    public int? Order { get; set; }

    /// <summary>
    /// 页码
    /// </summary>
    [JsonPropertyName("page_no")]
    public long? PageNo { get; set; }

    /// <summary>
    /// 页大小
    /// </summary>
    [JsonPropertyName("page_size")]
    public long? PageSize { get; set; }

    /// <summary>
    /// 报名的活动总量
    /// </summary>
    [JsonPropertyName("record_sum")]
    public long? RecordSum { get; set; }
    public partial class OpenGoodsActivityListResponse : PddResponseModel
    {

        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public long? ActivityId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [JsonPropertyName("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动类型
        /// </summary>
        [JsonPropertyName("activity_type")]
        public int? ActivityType { get; set; }

        /// <summary>
        /// 结束操作来源：  0: 活动时间到了，活动结束  1: 商家在MMS后台人为点击结束  2: 活动被系统结束
        /// </summary>
        [JsonPropertyName("end_operation_source")]
        public int? EndOperationSource { get; set; }

        /// <summary>
        /// 结束时间（单位：s）
        /// </summary>
        [JsonPropertyName("end_time")]
        public long? EndTime { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonPropertyName("goods_id")]
        public long? GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品剩余库存
        /// </summary>
        [JsonPropertyName("online_quantity")]
        public long? OnlineQuantity { get; set; }

        /// <summary>
        /// 价格信息
        /// </summary>
        [JsonPropertyName("price_info")]
        public List<PriceInfoResponse> PriceInfo { get; set; }

        /// <summary>
        /// 开始时间（单位：s）
        /// </summary>
        [JsonPropertyName("start_time")]
        public long? StartTime { get; set; }

        /// <summary>
        /// 活动状态
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }
        public partial class PriceInfoResponse : PddResponseModel
        {

            /// <summary>
            /// 活动报名库存
            /// </summary>
            [JsonPropertyName("activity_quantity")]
            public long? ActivityQuantity { get; set; }

            /// <summary>
            /// 活动剩余库存
            /// </summary>
            [JsonPropertyName("activity_stock_quantity")]
            public long? ActivityStockQuantity { get; set; }

            /// <summary>
            /// 活动 ID
            /// </summary>
            [JsonPropertyName("detail_id")]
            public long? DetailId { get; set; }

            /// <summary>
            /// 折扣比例。实际折扣为：discount/1000，例如：300表示3折
            /// </summary>
            [JsonPropertyName("discount")]
            public long? Discount { get; set; }

            /// <summary>
            /// 折扣范围
            /// </summary>
            [JsonPropertyName("discount_range")]
            public string DiscountRange { get; set; }

            /// <summary>
            /// 最大的sku活动拼团价
            /// </summary>
            [JsonPropertyName("max_pre_sale_price")]
            public long? MaxPreSalePrice { get; set; }

            /// <summary>
            /// 最小的sku活动拼团价
            /// </summary>
            [JsonPropertyName("min_pre_sale_price")]
            public long? MinPreSalePrice { get; set; }

            /// <summary>
            /// sku维度的活动信息
            /// </summary>
            [JsonPropertyName("open_sku_prices")]
            public List<OpenSkuPricesResponse> OpenSkuPrices { get; set; }

            /// <summary>
            /// 活动价生效时用户限购数量 0:不限购
            /// </summary>
            [JsonPropertyName("user_activity_limit")]
            public long? UserActivityLimit { get; set; }
            public partial class OpenSkuPricesResponse : PddResponseModel
            {

                /// <summary>
                /// 活动拼团价（单位：分）
                /// </summary>
                [JsonPropertyName("activity_price")]
                public long? ActivityPrice { get; set; }

                /// <summary>
                /// 折扣比例
                /// </summary>
                [JsonPropertyName("discount")]
                public string Discount { get; set; }

                /// <summary>
                /// 原拼团价（单位：分）
                /// </summary>
                [JsonPropertyName("group_price")]
                public long? GroupPrice { get; set; }

                /// <summary>
                /// skuid
                /// </summary>
                [JsonPropertyName("sku_id")]
                public long? SkuId { get; set; }

                /// <summary>
                /// sku名称
                /// </summary>
                [JsonPropertyName("sku_name")]
                public string SkuName { get; set; }

            }

        }

    }

}

