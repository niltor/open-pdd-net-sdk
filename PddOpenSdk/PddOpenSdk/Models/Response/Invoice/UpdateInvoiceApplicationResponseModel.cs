using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Invoice
{
    public class InvoiceApplicationUpdateResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    public class UpdateInvoiceApplicationResponseModel
    {

        /// <summary>
        /// Examples: {"is_success":true}
        /// </summary>
        [JsonProperty("invoice_application_update_response")]
        public InvoiceApplicationUpdateResponse InvoiceApplicationUpdateResponse { get; set; }
    }


}
