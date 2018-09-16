using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class UpdateInvoiceApplicationResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("invoice_application_update_response")]
public object InvoiceApplicationUpdateResponse {get;set;}
/// <summary>
/// true
/// </summary>
[JsonProperty("is_success")]
public object IsSuccess {get;set;}

    public partial class InvoiceApplicationUpdateResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// true
/// </summary>
[JsonProperty("is_success")]
public object IsSuccess {get;set;}

}

}
}
