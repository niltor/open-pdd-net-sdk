using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Refund
{
    public partial class GetRefundInformationResponseModel : PddResponseModel
    {
        /// <summary>
        /// 售后原因
        /// </summary>
        [JsonProperty("after_sales_reason")]
        public string AfterSalesReason { get; set; }
        /// <summary>
        /// 售后状态 0：无售后 2：买家申请退款，待商家处理 3：退货退款，待商家处理 4：商家同意退款，退款中 5：平台同意退款，退款中 6：驳回退款，待买家处理 7：已同意退货退款,待用户发货 8：平台处理中 9：平台拒绝退款，退款关闭 10：退款成功 11：买家撤销 12：买家逾期未处理，退款失败 13：买家逾期，超过有效期 14：换货补寄待商家处理 15：换货补寄待用户处理 16：换货补寄成功 17：换货补寄失败 18：换货补寄待用户确认完成 21：待商家同意维修 22：待用户确认发货 24：维修关闭 25：维修成功 27：待用户确认收货 31：已同意拒收退款，待用户拒收 32：补寄待商家发货
        /// </summary>
        [JsonProperty("after_sales_status")]
        public int? AfterSalesStatus { get; set; }
        /// <summary>
        /// 售后类型 1-仅退款，2-退货退款，3-换货，4-补寄，5-维修
        /// </summary>
        [JsonProperty("after_sales_type")]
        public int? AfterSalesType { get; set; }
        /// <summary>
        /// 订单成团时间
        /// </summary>
        [JsonProperty("confirm_time")]
        public long? ConfirmTime { get; set; }
        /// <summary>
        /// 订单折扣金额
        /// </summary>
        [JsonProperty("discount_amount")]
        public int? DiscountAmount { get; set; }
        /// <summary>
        /// 退货物流单号
        /// </summary>
        [JsonProperty("express_no")]
        public string ExpressNo { get; set; }
        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonProperty("goods_number")]
        public int? GoodsNumber { get; set; }
        /// <summary>
        /// 商品单价
        /// </summary>
        [JsonProperty("goods_price")]
        public int? GoodsPrice { get; set; }
        /// <summary>
        /// 售后单id
        /// </summary>
        [JsonProperty("id")]
        public long? Id { get; set; }
        /// <summary>
        /// 交易金额
        /// </summary>
        [JsonProperty("order_amount")]
        public long? OrderAmount { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }
        /// <summary>
        /// 售后单创建时间（重新申请时间）
        /// </summary>
        [JsonProperty("recreated_at")]
        public long? RecreatedAt { get; set; }
        /// <summary>
        /// 退款金额
        /// </summary>
        [JsonProperty("refund_amount")]
        public int? RefundAmount { get; set; }
        /// <summary>
        /// 订单发货状态 0:未发货， 1:已发货（包含：已发货，已揽收）
        /// </summary>
        [JsonProperty("shipping_status")]
        public int? ShippingStatus { get; set; }
        /// <summary>
        /// 极速退款标志位 1：极速退款，0：非极速退款
        /// </summary>
        [JsonProperty("speed_refund_flag")]
        public int? SpeedRefundFlag { get; set; }
        /// <summary>
        /// 售后逾期时间（只提供待商家处理状态下的，其余的状态为null）
        /// </summary>
        [JsonProperty("expire_time")]
        public long? ExpireTime { get; set; }

    }

}
