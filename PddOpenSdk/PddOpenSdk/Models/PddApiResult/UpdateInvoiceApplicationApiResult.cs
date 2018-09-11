namespace App.Models.PddApiResult
{
    
public class InvoiceApplicationUpdateResponse
{
    public bool is_success { get; set; }
}


public class UpdateInvoiceApplicationApiResult
{
    public InvoiceApplicationUpdateResponse invoice_application_update_response { get; set; }
}

}
