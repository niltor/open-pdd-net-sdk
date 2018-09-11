namespace PddOpenSdk.Models.PddApiResult
{
    
public class InvoiceApplicationUpdateResponse
{
    public object serial_no { get; set; }
}


public class UploadInvoiceDetailApiResult
{
    public InvoiceApplicationUpdateResponse invoice_application_update_response { get; set; }
}

}
