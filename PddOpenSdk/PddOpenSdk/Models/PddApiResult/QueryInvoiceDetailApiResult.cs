namespace App.Models.PddApiResult
{
    
public class InvoiceDetailQueryResponse
{
    public int application_status { get; set; }
    public string order_sn { get; set; }
    public string serial_no { get; set; }
    public int mall_id { get; set; }
    public int business_type { get; set; }
    public string payer_name { get; set; }
    public string payer_register_no { get; set; }
    public int status { get; set; }
    public int invoice_kind { get; set; }
    public int invoice_type { get; set; }
    public int invoice_amount { get; set; }
    public int sum_price { get; set; }
    public int tax_rate { get; set; }
    public int sum_tax { get; set; }
    public string invoice_code { get; set; }
    public string invoice_no { get; set; }
    public object original_invoice_code { get; set; }
    public object original_invoice_no { get; set; }
    public string payee_operator { get; set; }
    public long invoice_time { get; set; }
    public string invoice_file_path { get; set; }
    public object memo { get; set; }
    public object denied_reason { get; set; }
}


public class QueryInvoiceDetailApiResult
{
    public InvoiceDetailQueryResponse invoice_detail_query_response { get; set; }
}

}
