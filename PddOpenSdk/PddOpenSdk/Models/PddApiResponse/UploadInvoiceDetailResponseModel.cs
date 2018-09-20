using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class UploadInvoiceDetailResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("invoice_application_update_response")]
        public InvoiceApplicationUpdateResponseResponseModel InvoiceApplicationUpdateResponse { get; set; }

        public partial class InvoiceApplicationUpdateResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 发票流水号
            /// </summary>
            [JsonProperty("serial_no")]
            public string SerialNo { get; set; }

        }

    }
}
