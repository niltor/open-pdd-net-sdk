namespace PddOpenSdk.Models.Request.Promotion;
public partial class CreatePromotionLimitedActivity
{

    /// <summary>
    /// 创建请求
    /// </summary>
    [JsonPropertyName("request")]
    public List<RequestModel> Request { get; set; }
    public partial class RequestModel
    {

        /// <summary>
        /// 活动名称
        /// </summary>
        [JsonPropertyName("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动类型
        /// </summary>
        [JsonPropertyName("activity_type")]
        public int ActivityType { get; set; }

        /// <summary>
        /// 折扣比例，实际折扣为：discount/1000。例：300，表示3折
        /// </summary>
        [JsonPropertyName("discount")]
        public long? Discount { get; set; }

        /// <summary>
        /// 限时折扣必填。结束时间（单位：s）
        /// </summary>
        [JsonPropertyName("end_time")]
        public long? EndTime { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonPropertyName("goods_id")]
        public long GoodsId { get; set; }

        /// <summary>
        /// 活动库存的数量（限量活动时，必填）
        /// </summary>
        [JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// 参与活动的sku数据列表
        /// </summary>
        [JsonPropertyName("sku_price_list")]
        public List<SkuPriceListModel> SkuPriceList { get; set; }

        /// <summary>
        /// 限时折扣必填。开始时间（单位：s）
        /// </summary>
        [JsonPropertyName("start_time")]
        public long? StartTime { get; set; }

        /// <summary>
        /// 用户限购数量(0:不限购)
        /// </summary>
        [JsonPropertyName("user_activity_limit")]
        public long? UserActivityLimit { get; set; }
        public partial class SkuPriceListModel
        {

            /// <summary>
            /// sku活动价格
            /// </summary>
            [JsonPropertyName("activity_price")]
            public long ActivityPrice { get; set; }

            /// <summary>
            /// skuid
            /// </summary>
            [JsonPropertyName("sku_id")]
            public long SkuId { get; set; }

        }

    }

}

