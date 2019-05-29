using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Invoice
{
    public partial class UpdateInvoiceApplicationResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("invoice_application_update_response")]
        public InvoiceApplicationUpdateResponseResponseModel InvoiceApplicationUpdateResponse { get; set; }
        public partial class InvoiceApplicationUpdateResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// true
            /// </summary>
            [JsonProperty("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}
