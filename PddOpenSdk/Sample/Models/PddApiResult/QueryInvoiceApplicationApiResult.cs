using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class InvoiceApplicationList
{
    public string application_id { get; set; }
    public int application_status { get; set; }
    public int trigger_status { get; set; }
    public string order_sn { get; set; }
    public int mall_id { get; set; }
    public int business_type { get; set; }
    public string payer_name { get; set; }
    public string payer_register_no { get; set; }
    public int invoice_kind { get; set; }
    public int invoice_type { get; set; }
    public object invoice_amount { get; set; }
    public object sum_price { get; set; }
    public object tax_rate { get; set; }
    public object sum_tax { get; set; }
    public object reason { get; set; }
    public object memo { get; set; }
    public long gmt_create { get; set; }
    public long gmt_modified { get; set; }
}


public class InvoiceApplicationQueryResponse
{
    public List<InvoiceApplicationList> invoice_application_list { get; set; }
}


public class QueryInvoiceApplicationApiResult
{
    public InvoiceApplicationQueryResponse invoice_application_query_response { get; set; }
}

}
