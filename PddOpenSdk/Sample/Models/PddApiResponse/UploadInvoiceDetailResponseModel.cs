using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class UploadInvoiceDetailResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("invoice_application_update_response")]
public object InvoiceApplicationUpdateResponse {get;set;}
/// <summary>
/// 发票流水号
/// </summary>
[JsonProperty("serial_no")]
public object SerialNo {get;set;}

    public partial class InvoiceApplicationUpdateResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 发票流水号
/// </summary>
[JsonProperty("serial_no")]
public object SerialNo {get;set;}

}

}
}
