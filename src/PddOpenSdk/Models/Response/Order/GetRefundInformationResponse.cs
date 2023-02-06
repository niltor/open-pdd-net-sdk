namespace PddOpenSdk.Models.Response.Order;
public partial class GetRefundInformationResponse : PddResponseModel
{

    /// <summary>
    /// 售后原因
    /// </summary>
    [JsonPropertyName("after_sales_reason")]
    public string AfterSalesReason { get; set; }

    /// <summary>
    /// 售后状态 0：无售后 2：买家申请退款，待商家处理 3：退货退款，待商家处理 4：商家同意退款，退款中 5：平台同意退款，退款中 6：驳回退款，待买家处理 7：已同意退货退款,待用户发货 8：平台处理中 9：平台拒绝退款，退款关闭 10：退款成功 11：买家撤销 12：买家逾期未处理，退款失败 13：买家逾期，超过有效期 14：换货补寄待商家处理 15：换货补寄待用户处理 16：换货补寄成功 17：换货补寄失败 18：换货补寄待用户确认完成 21：待商家同意维修 22：待用户确认发货 24：维修关闭 25：维修成功 27：待用户确认收货 31：已同意拒收退款，待用户拒收 32：补寄待商家发货
    /// </summary>
    [JsonPropertyName("after_sales_status")]
    public int? AfterSalesStatus { get; set; }

    /// <summary>
    /// 售后类型 1-仅退款，2-退货退款，3-换货，4-补寄，5-维修
    /// </summary>
    [JsonPropertyName("after_sales_type")]
    public int? AfterSalesType { get; set; }

    /// <summary>
    /// 订单成团时间
    /// </summary>
    [JsonPropertyName("confirm_time")]
    public long? ConfirmTime { get; set; }

    /// <summary>
    /// 订单折扣金额
    /// </summary>
    [JsonPropertyName("discount_amount")]
    public int? DiscountAmount { get; set; }

    /// <summary>
    /// 1纠纷退款 0非纠纷退款
    /// </summary>
    [JsonPropertyName("dispute_refund_status")]
    public int? DisputeRefundStatus { get; set; }

    /// <summary>
    /// 换货详情,售后类型是换货才有值
    /// </summary>
    [JsonPropertyName("exchange_shipping_detail")]
    public ExchangeShippingDetailResponse ExchangeShippingDetail { get; set; }

    /// <summary>
    /// 售后逾期时间（只提供待商家处理状态下的，其余的状态为null）
    /// </summary>
    [JsonPropertyName("expire_time")]
    public long? ExpireTime { get; set; }

    /// <summary>
    /// 退货物流单号
    /// </summary>
    [JsonPropertyName("express_no")]
    public string ExpressNo { get; set; }

    /// <summary>
    /// 商品数量
    /// </summary>
    [JsonPropertyName("goods_number")]
    public int? GoodsNumber { get; set; }

    /// <summary>
    /// 商品单价
    /// </summary>
    [JsonPropertyName("goods_price")]
    public int? GoodsPrice { get; set; }

    /// <summary>
    /// 售后单id
    /// </summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    /// <summary>
    /// 用户申请售后上传的图片列表
    /// </summary>
    [JsonPropertyName("images")]
    public List<string> Images { get; set; }

    /// <summary>
    /// 是否介入 1介入 0未介入
    /// </summary>
    [JsonPropertyName("join_or_not")]
    public string JoinOrNot { get; set; }

    /// <summary>
    /// 交易金额
    /// </summary>
    [JsonPropertyName("order_amount")]
    public long? OrderAmount { get; set; }

    /// <summary>
    /// 订单号
    /// </summary>
    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

    /// <summary>
    /// 售后单创建时间（重新申请时间）
    /// </summary>
    [JsonPropertyName("recreated_at")]
    public long? RecreatedAt { get; set; }

    /// <summary>
    /// 退款金额
    /// </summary>
    [JsonPropertyName("refund_amount")]
    public int? RefundAmount { get; set; }

    /// <summary>
    /// 用户申请输入的描述信息
    /// </summary>
    [JsonPropertyName("remark")]
    public string Remark { get; set; }

    /// <summary>
    /// 退货物流名称
    /// </summary>
    [JsonPropertyName("shipping_name")]
    public string ShippingName { get; set; }

    /// <summary>
    /// 订单发货状态 0:未发货， 1:已发货（包含：已发货，已揽收）
    /// </summary>
    [JsonPropertyName("shipping_status")]
    public int? ShippingStatus { get; set; }

    /// <summary>
    /// 商品规格ID
    /// </summary>
    [JsonPropertyName("sku_id")]
    public string SkuId { get; set; }

    /// <summary>
    /// 极速退款标志位 1：极速退款，0：非极速退款
    /// </summary>
    [JsonPropertyName("speed_refund_flag")]
    public int? SpeedRefundFlag { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    [JsonPropertyName("updated_time")]
    public string UpdatedTime { get; set; }

    /// <summary>
    /// 0-未勾选 1-消费者选择的收货状态为未收到货 2-消费者选择的收货状态为已收到货
    /// </summary>
    [JsonPropertyName("user_shipping_status")]
    public string UserShippingStatus { get; set; }
    public partial class ExchangeShippingDetailResponse : PddResponseModel
    {

        /// <summary>
        /// 消费者回寄的物流id
        /// </summary>
        [JsonPropertyName("customer_send_back_ship_id")]
        public int? CustomerSendBackShipId { get; set; }

        /// <summary>
        /// 消费者回寄的物流单号
        /// </summary>
        [JsonPropertyName("customer_send_back_trunk_number")]
        public string CustomerSendBackTrunkNumber { get; set; }

        /// <summary>
        /// 换货发货的物品名称
        /// </summary>
        [JsonPropertyName("exchange_goods_name")]
        public string ExchangeGoodsName { get; set; }

        /// <summary>
        /// 换货发货的物品数量
        /// </summary>
        [JsonPropertyName("exchange_goods_number")]
        public int? ExchangeGoodsNumber { get; set; }

        /// <summary>
        /// 换货的物品价格(单位分)
        /// </summary>
        [JsonPropertyName("exchange_goods_price")]
        public long? ExchangeGoodsPrice { get; set; }

        /// <summary>
        /// 商家换货发货的城市（消费者地址）
        /// </summary>
        [JsonPropertyName("exchange_receiver_city")]
        public string ExchangeReceiverCity { get; set; }

        /// <summary>
        /// 商家换货发货的城市编码（消费者地址）
        /// </summary>
        [JsonPropertyName("exchange_receiver_city_id")]
        public long? ExchangeReceiverCityId { get; set; }

        /// <summary>
        /// 商家换货发货的省份（消费者地址）
        /// </summary>
        [JsonPropertyName("exchange_receiver_province")]
        public string ExchangeReceiverProvince { get; set; }

        /// <summary>
        /// 商家换货发货的省份编码（消费者地址）
        /// </summary>
        [JsonPropertyName("exchange_receiver_province_id")]
        public long? ExchangeReceiverProvinceId { get; set; }

        /// <summary>
        /// 商家换货发货的区县（消费者地址）
        /// </summary>
        [JsonPropertyName("exchange_receiver_town")]
        public string ExchangeReceiverTown { get; set; }

        /// <summary>
        /// 商家换货发货的区县编码（消费者地址）
        /// </summary>
        [JsonPropertyName("exchange_receiver_town_id")]
        public long? ExchangeReceiverTownId { get; set; }

        /// <summary>
        /// 商家换货发货的详细地址
        /// </summary>
        [JsonPropertyName("merchant_exchange_detail_address")]
        public string MerchantExchangeDetailAddress { get; set; }

        /// <summary>
        /// 商家换货发货的收货人手机号
        /// </summary>
        [JsonPropertyName("merchant_exchange_detail_phone")]
        public string MerchantExchangeDetailPhone { get; set; }

        /// <summary>
        /// 商家换货发货的收货人名字
        /// </summary>
        [JsonPropertyName("merchant_exchange_detail_receiver")]
        public string MerchantExchangeDetailReceiver { get; set; }

        /// <summary>
        /// 商家换货发货的物流id
        /// </summary>
        [JsonPropertyName("merchant_exchange_ship_id")]
        public int? MerchantExchangeShipId { get; set; }

        /// <summary>
        /// 商家换货发货的物流单号
        /// </summary>
        [JsonPropertyName("merchant_exchange_trunk_number")]
        public string MerchantExchangeTrunkNumber { get; set; }

        /// <summary>
        /// 换货商品规格ID
        /// </summary>
        [JsonPropertyName("sku_id_exchange")]
        public string SkuIdExchange { get; set; }

        /// <summary>
        /// 商家换货发货的详细地址（打码）
        /// </summary>
        [JsonPropertyName("merchant_exchange_detail_address_mask")]
        public string MerchantExchangeDetailAddressMask { get; set; }

        /// <summary>
        /// 商家换货发货的收货人手机号（打码）
        /// </summary>
        [JsonPropertyName("merchant_exchange_detail_phone_mask")]
        public string MerchantExchangeDetailPhoneMask { get; set; }

        /// <summary>
        /// 商家换货发货的收货人名字（打码）
        /// </summary>
        [JsonPropertyName("merchant_exchange_detail_receiver_mask")]
        public string MerchantExchangeDetailReceiverMask { get; set; }

    }

}

