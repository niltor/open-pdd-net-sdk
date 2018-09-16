using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class QueryInvoiceApplicationResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("invoice_application_query_response")]
public object InvoiceApplicationQueryResponse {get;set;}

    public partial class InvoiceApplicationQueryResponseResponseModel : PddResponseModel
    {
        
}

}
}
