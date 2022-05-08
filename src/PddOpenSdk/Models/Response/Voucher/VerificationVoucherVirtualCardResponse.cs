namespace PddOpenSdk.Models.Response.Voucher;
public partial class VerificationVoucherVirtualCardResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("voucher_voucher_info_verify_response")]
    public VoucherVoucherInfoVerifyResponseResponse VoucherVoucherInfoVerifyResponse { get; set; }
    public partial class VoucherVoucherInfoVerifyResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 拼多多订单号
        /// </summary>
        [JsonPropertyName("order_sn")]
        public string OrderSn { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonPropertyName("goods_id")]
        public long? GoodsId { get; set; }

        /// <summary>
        /// 商品属性id
        /// </summary>
        [JsonPropertyName("sku_id")]
        public long? SkuId { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [JsonPropertyName("mall_id")]
        public long? MallId { get; set; }

        /// <summary>
        /// 券信息数组
        /// </summary>
        [JsonPropertyName("voucher_list")]
        public List<VoucherListResponse> VoucherList { get; set; }
        public partial class VoucherListResponse : PddResponseModel
        {

            /// <summary>
            /// 卡号
            /// </summary>
            [JsonPropertyName("card_no")]
            public string CardNo { get; set; }

            /// <summary>
            /// 卡密
            /// </summary>
            [JsonPropertyName("card_code")]
            public string CardCode { get; set; }

            /// <summary>
            /// 标准密码
            /// </summary>
            [JsonPropertyName("mark_password")]
            public string MarkPassword { get; set; }

            /// <summary>
            /// 状态
            /// </summary>
            [JsonPropertyName("status")]
            public int? Status { get; set; }

            /// <summary>
            /// 返回状态
            /// </summary>
            [JsonPropertyName("refund_status")]
            public int? RefundStatus { get; set; }

            /// <summary>
            /// 验证处
            /// </summary>
            [JsonPropertyName("verification_at")]
            public long? VerificationAt { get; set; }

        }

    }

}

