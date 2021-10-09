namespace PddOpenSdk.Models.Response.Fds;
public partial class GetFdsOrderResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("pdd_fds_order_get_response")]
    public PddFdsOrderGetResponseResponse PddFdsOrderGetResponse { get; set; }
    public partial class PddFdsOrderGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 分配时间,毫秒
        /// </summary>
        [JsonPropertyName("allow_time")]
        public long? AllowTime { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        [JsonPropertyName("district")]
        public string District { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonPropertyName("goods_number")]
        public int? GoodsNumber { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        [JsonPropertyName("goods_spec")]
        public string GoodsSpec { get; set; }

        /// <summary>
        /// 代打店铺id
        /// </summary>
        [JsonPropertyName("mall_mask_id")]
        public string MallMaskId { get; set; }

        /// <summary>
        /// 代打店铺自定义名称
        /// </summary>
        [JsonPropertyName("mall_mask_name")]
        public string MallMaskName { get; set; }

        /// <summary>
        /// 代打订单号
        /// </summary>
        [JsonPropertyName("order_mask_sn")]
        public string OrderMaskSn { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }

        /// <summary>
        /// 卖家备注
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 分配状态 0：取消分配 1：已分配
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 结算价格，单位：分
        /// </summary>
        [JsonPropertyName("product_price")]
        public int? ProductPrice { get; set; }

        /// <summary>
        /// 货号
        /// </summary>
        [JsonPropertyName("product_sn")]
        public string ProductSn { get; set; }

        /// <summary>
        /// 收件人姓名+电话+地址相同,receiver_id字段相同，该功能上线前字段为""
        /// </summary>
        [JsonPropertyName("receiver_id")]
        public string ReceiverId { get; set; }

        /// <summary>
        /// 商家设置的sku编码
        /// </summary>
        [JsonPropertyName("out_sku_sn")]
        public string OutSkuSn { get; set; }

        /// <summary>
        /// 加价发顺丰0：不是 1：是
        /// </summary>
        [JsonPropertyName("sf_only")]
        public int? SfOnly { get; set; }

        /// <summary>
        /// 运单回传状态 0：未回传 1：已回传
        /// </summary>
        [JsonPropertyName("return_status")]
        public int? ReturnStatus { get; set; }

    }

}

