using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Invoice
{
    public class InvoiceDetailQueryResponse
    {

        /// <summary>
        /// Examples: 2
        /// </summary>
        [JsonProperty("application_status")]
        public int ApplicationStatus { get; set; }

        /// <summary>
        /// Examples: "180316-304215933210993"
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }

        /// <summary>
        /// Examples: "T180717-010737418250987"
        /// </summary>
        [JsonProperty("serial_no")]
        public string SerialNo { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("mall_id")]
        public int MallId { get; set; }

        /// <summary>
        /// Examples: 2
        /// </summary>
        [JsonProperty("business_type")]
        public int BusinessType { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("payer_name")]
        public string PayerName { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("payer_register_no")]
        public string PayerRegisterNo { get; set; }

        /// <summary>
        /// Examples: 2
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("invoice_kind")]
        public int InvoiceKind { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("invoice_type")]
        public int InvoiceType { get; set; }

        /// <summary>
        /// Examples: 100
        /// </summary>
        [JsonProperty("invoice_amount")]
        public int InvoiceAmount { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("sum_price")]
        public int SumPrice { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("tax_rate")]
        public int TaxRate { get; set; }

        /// <summary>
        /// Examples: 16
        /// </summary>
        [JsonProperty("sum_tax")]
        public int SumTax { get; set; }

        /// <summary>
        /// Examples: "qweasdzxc"
        /// </summary>
        [JsonProperty("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// Examples: "1234567"
        /// </summary>
        [JsonProperty("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("original_invoice_code")]
        public object OriginalInvoiceCode { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("original_invoice_no")]
        public object OriginalInvoiceNo { get; set; }

        /// <summary>
        /// Examples: "大哥"
        /// </summary>
        [JsonProperty("payee_operator")]
        public string PayeeOperator { get; set; }

        /// <summary>
        /// Examples: 1531814544000
        /// </summary>
        [JsonProperty("invoice_time")]
        public long InvoiceTime { get; set; }

        /// <summary>
        /// Examples: "http://st1-tcoscache-dev-1.prod.yiran.com/private/order_invoice/T180717-010737418250987.png?sign=q-sign-algorithm=sha1&q-ak=akak&q-sign-time=1531816969;1532166969&q-key-time=1531816969;1532166969&q-header-list=&q-url-param-list=&q-signature=db301be91fb626b56fedf7ab84253e9eaf4a1f04"
        /// </summary>
        [JsonProperty("invoice_file_path")]
        public string InvoiceFilePath { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("memo")]
        public object Memo { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("denied_reason")]
        public object DeniedReason { get; set; }
    }

    public class QueryInvoiceDetailResponseModel
    {

        /// <summary>
        /// Examples: {"application_status":2,"order_sn":"180316-304215933210993","serial_no":"T180717-010737418250987","mall_id":1,"business_type":2,"payer_name":"","payer_register_no":"","status":2,"invoice_kind":0,"invoice_type":0,"invoice_amount":100,"sum_price":0,"tax_rate":0,"sum_tax":16,"invoice_code":"qweasdzxc","invoice_no":"1234567","original_invoice_code":null,"original_invoice_no":null,"payee_operator":"大哥","invoice_time":1531814544000,"invoice_file_path":"http://st1-tcoscache-dev-1.prod.yiran.com/private/order_invoice/T180717-010737418250987.png?sign=q-sign-algorithm=sha1&q-ak=akak&q-sign-time=1531816969;1532166969&q-key-time=1531816969;1532166969&q-header-list=&q-url-param-list=&q-signature=db301be91fb626b56fedf7ab84253e9eaf4a1f04","memo":null,"denied_reason":null}
        /// </summary>
        [JsonProperty("invoice_detail_query_response")]
        public InvoiceDetailQueryResponse InvoiceDetailQueryResponse { get; set; }
    }


}
