using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Invoice
{
    public partial class InvalidInvoiceDetailResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("invoice_detail_invalid_response")]
        public InvoiceDetailInvalidResponseResponseModel InvoiceDetailInvalidResponse { get; set; }
        public partial class InvoiceDetailInvalidResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// errorCode
            /// </summary>
            [JsonProperty("error_code")]
            public int? ErrorCode { get; set; }
            /// <summary>
            /// errorMsg
            /// </summary>
            [JsonProperty("error_msg")]
            public string ErrorMsg { get; set; }
            /// <summary>
            /// result
            /// </summary>
            [JsonProperty("result")]
            public ResultResponseModel Result { get; set; }
            /// <summary>
            /// success
            /// </summary>
            [JsonProperty("success")]
            public bool? Success { get; set; }
            public partial class ResultResponseModel : PddResponseModel
            {
                /// <summary>
                /// 红冲是否成功
                /// </summary>
                [JsonProperty("result")]
                public bool? Result { get; set; }

            }

        }

    }

}
