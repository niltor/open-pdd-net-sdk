namespace PddOpenSdk.Models.Response.Mall;
public partial class RegisterQrpayPayeeResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("qrpay_payee_register_response")]
    public QrpayPayeeRegisterResponseResponse QrpayPayeeRegisterResponse { get; set; }
    public partial class QrpayPayeeRegisterResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 参数注册结果
        /// </summary>
        [JsonPropertyName("payee_result_list")]
        public List<PayeeResultListResponse> PayeeResultList { get; set; }
        public partial class PayeeResultListResponse : PddResponseModel
        {

            /// <summary>
            /// 参数名
            /// </summary>
            [JsonPropertyName("payee")]
            public string Payee { get; set; }

            /// <summary>
            /// 参数id
            /// </summary>
            [JsonPropertyName("payee_id")]
            public long? PayeeId { get; set; }

            /// <summary>
            /// 交易二维码图片UR
            /// </summary>
            [JsonPropertyName("qr_image_url")]
            public string QrImageUrl { get; set; }

            /// <summary>
            /// 交易二维码页面URL
            /// </summary>
            [JsonPropertyName("qr_pay_page_url")]
            public string QrPayPageUrl { get; set; }

        }

    }

}

