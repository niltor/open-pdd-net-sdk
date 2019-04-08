using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Invoice
{
    public partial class UploadInvoiceDetailResponseModel : PddResponseModel {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty ("invoice_detail_upload_response")]
        public InvoiceDetailUploadResponseResponseModel InvoiceDetailUploadResponse { get; set; }
        public partial class InvoiceDetailUploadResponseResponseModel : PddResponseModel {
            /// <summary>
            /// 发票流水号
            /// </summary>
            [JsonProperty ("serial_no")]
            public string SerialNo { get; set; }

        }

    }

}