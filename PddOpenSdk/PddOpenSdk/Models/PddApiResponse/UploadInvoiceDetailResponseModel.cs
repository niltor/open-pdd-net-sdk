using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class UploadInvoiceDetailResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("invoice_application_update_response")]
public object InvoiceApplicationUpdateResponse {get;set;}

    public partial class InvoiceApplicationUpdateResponseResponseModel : PddResponseModel
    {
        
}

}
}
