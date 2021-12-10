namespace PddOpenSdk.Models.Response.Voucher;
public partial class VerificationVoucherOtaCardResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("voucher_ota_card_verification_response")]
    public VoucherOtaCardVerificationResponseResponse VoucherOtaCardVerificationResponse { get; set; }
    public partial class VoucherOtaCardVerificationResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("errorMsg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("result")]
        public ResultResponse Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 券码
            /// </summary>
            [JsonPropertyName("card_no")]
            public string CardNo { get; set; }

            /// <summary>
            /// 店铺编码
            /// </summary>
            [JsonPropertyName("mall_id")]
            public long? MallId { get; set; }

            /// <summary>
            /// 订单号
            /// </summary>
            [JsonPropertyName("order_sn")]
            public string OrderSn { get; set; }

            /// <summary>
            /// 核销状态（1-未核销，2-已核销， 3-已过期，4-已销毁，99-核销中）
            /// </summary>
            [JsonPropertyName("status")]
            public int? Status { get; set; }

            /// <summary>
            /// 门店编码
            /// </summary>
            [JsonPropertyName("store_id")]
            public long? StoreId { get; set; }

            /// <summary>
            /// 门店名称
            /// </summary>
            [JsonPropertyName("store_name")]
            public string StoreName { get; set; }

            /// <summary>
            /// 核销时间（yyyy-MM-dd HH:mm:ss格式）
            /// </summary>
            [JsonPropertyName("verification_time")]
            public string VerificationTime { get; set; }

        }

    }

}

