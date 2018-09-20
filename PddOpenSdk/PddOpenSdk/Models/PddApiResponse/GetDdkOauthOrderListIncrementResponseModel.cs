using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetDdkOauthOrderListIncrementResponseModel : PddResponseModel
    {
        /// <summary>
        /// 多多进宝推广位对象列表
        /// </summary>
        [JsonProperty("order_list")]
        public OrderListResponseModel OrderList { get; set; }
        /// <summary>
        /// 请求到的结果数
        /// </summary>
        [JsonProperty("total_count")]
        public object TotalCount { get; set; }

        public partial class OrderListResponseModel : PddResponseModel
        {
            /// <summary>
            /// 自定义参数，标志订单来源于哪个自定义参数
            /// </summary>
            [JsonProperty("custom_parameters")]
            public string CustomParameters { get; set; }
            /// <summary>
            /// 订单确认签收时间
            /// </summary>
            [JsonProperty("order_receive_time")]
            public int OrderReceiveTime { get; set; }
            /// <summary>
            /// 订单来源：0—单品（领券页）推广    1—红包活动推广    2—领券页底部推荐
            /// </summary>
            [JsonProperty("type")]
            public int Type { get; set; }
            /// <summary>
            /// 审核时间
            /// </summary>
            [JsonProperty("order_verify_time")]
            public int OrderVerifyTime { get; set; }
            /// <summary>
            /// 支付时间
            /// </summary>
            [JsonProperty("order_pay_time")]
            public int OrderPayTime { get; set; }
            /// <summary>
            /// 成团时间
            /// </summary>
            [JsonProperty("order_group_success_time")]
            public int OrderGroupSuccessTime { get; set; }
            /// <summary>
            /// 最后更新时间
            /// </summary>
            [JsonProperty("order_modify_at")]
            public int OrderModifyAt { get; set; }
            /// <summary>
            /// 订单状态描述
            /// </summary>
            [JsonProperty("order_status_desc")]
            public string OrderStatusDesc { get; set; }
            /// <summary>
            /// 推广位ID
            /// </summary>
            [JsonProperty("p_id")]
            public string PId { get; set; }
            /// <summary>
            /// 订单状态：  -1 未支付; 0-已支付；1-已成团；2-确认收货；3-审核成功；4-审核失败（不可提现）；5-已经结算；8-非多多进宝商品（无佣金订单）;10-已处罚
            /// </summary>
            [JsonProperty("order_status")]
            public int OrderStatus { get; set; }
            /// <summary>
            /// 佣金金额，单位为分
            /// </summary>
            [JsonProperty("promotion_amount")]
            public int PromotionAmount { get; set; }
            /// <summary>
            /// 佣金比例，千分比
            /// </summary>
            [JsonProperty("promotion_rate")]
            public int PromotionRate { get; set; }
            /// <summary>
            /// 订单生成时间，UNIX时间戳
            /// </summary>
            [JsonProperty("order_create_time")]
            public string OrderCreateTime { get; set; }
            /// <summary>
            /// 实际支付金额，单位为分
            /// </summary>
            [JsonProperty("order_amount")]
            public int OrderAmount { get; set; }
            /// <summary>
            /// 订单中sku的单件价格，单位为分
            /// </summary>
            [JsonProperty("goods_price")]
            public int GoodsPrice { get; set; }
            /// <summary>
            /// 购买商品的数量
            /// </summary>
            [JsonProperty("goods_quantity")]
            public int GoodsQuantity { get; set; }
            /// <summary>
            /// 商品缩略图
            /// </summary>
            [JsonProperty("goods_thumbnail_url")]
            public string GoodsThumbnailUrl { get; set; }
            /// <summary>
            /// 商品标题
            /// </summary>
            [JsonProperty("goods_name")]
            public string GoodsName { get; set; }
            /// <summary>
            /// 商品ID
            /// </summary>
            [JsonProperty("goods_id")]
            public string GoodsId { get; set; }
            /// <summary>
            /// 推广订单编号
            /// </summary>
            [JsonProperty("order_sn")]
            public string OrderSn { get; set; }

        }

    }
}
