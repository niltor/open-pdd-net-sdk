using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Invoice
{
    public partial class InvoiceApplicationUpdateResponse
    {

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("serial_no")]
        public object SerialNo { get; set; }
    }

    public class UploadInvoiceDetailResponseModel
    {

        /// <summary>
        /// Examples: {"serial_no":null}
        /// </summary>
        [JsonProperty("invoice_application_update_response")]
        public InvoiceApplicationUpdateResponse InvoiceApplicationUpdateResponse { get; set; }
    }


}
