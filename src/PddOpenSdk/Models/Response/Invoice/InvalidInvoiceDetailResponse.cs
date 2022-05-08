namespace PddOpenSdk.Models.Response.Invoice;
public partial class InvalidInvoiceDetailResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("invoice_detail_invalid_response")]
    public InvoiceDetailInvalidResponseResponse InvoiceDetailInvalidResponse { get; set; }
    public partial class InvoiceDetailInvalidResponseResponse : PddResponseModel
    {

        /// <summary>
        /// errorCode
        /// </summary>
        [JsonPropertyName("error_code")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [JsonPropertyName("result")]
        public ResultResponse Result { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 红冲是否成功
            /// </summary>
            [JsonPropertyName("result")]
            public bool? Result { get; set; }

        }

    }

}

