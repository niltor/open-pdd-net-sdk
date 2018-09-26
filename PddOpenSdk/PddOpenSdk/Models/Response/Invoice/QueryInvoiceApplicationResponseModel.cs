using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Invoice
{
    public class InvoiceApplicationList
    {

        /// <summary>
        /// Examples: "20012229017610001"
        /// </summary>
        [JsonProperty("application_id")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Examples: 2
        /// </summary>
        [JsonProperty("application_status")]
        public int ApplicationStatus { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("trigger_status")]
        public int TriggerStatus { get; set; }

        /// <summary>
        /// Examples: "170717-318748247040347"
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("mall_id")]
        public int MallId { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("business_type")]
        public int BusinessType { get; set; }

        /// <summary>
        /// Examples: "zhx"
        /// </summary>
        [JsonProperty("payer_name")]
        public string PayerName { get; set; }

        /// <summary>
        /// Examples: "12341"
        /// </summary>
        [JsonProperty("payer_register_no")]
        public string PayerRegisterNo { get; set; }

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
        /// Examples: null
        /// </summary>
        [JsonProperty("invoice_amount")]
        public object InvoiceAmount { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("sum_price")]
        public object SumPrice { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("tax_rate")]
        public object TaxRate { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("sum_tax")]
        public object SumTax { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("reason")]
        public object Reason { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("memo")]
        public object Memo { get; set; }

        /// <summary>
        /// Examples: 1531294712935
        /// </summary>
        [JsonProperty("gmt_create")]
        public long GmtCreate { get; set; }

        /// <summary>
        /// Examples: 1531373954962
        /// </summary>
        [JsonProperty("gmt_modified")]
        public long GmtModified { get; set; }
    }

    public class InvoiceApplicationQueryResponse
    {

        /// <summary>
        /// Examples: [{"application_id":"20012229017610001","application_status":2,"trigger_status":1,"order_sn":"170717-318748247040347","mall_id":1,"business_type":0,"payer_name":"zhx","payer_register_no":"12341","invoice_kind":0,"invoice_type":0,"invoice_amount":null,"sum_price":null,"tax_rate":null,"sum_tax":null,"reason":null,"memo":null,"gmt_create":1531294712935,"gmt_modified":1531373954962}]
        /// </summary>
        [JsonProperty("invoice_application_list")]
        public IList<InvoiceApplicationList> InvoiceApplicationList { get; set; }
    }

    public class QueryInvoiceApplicationResponseModel
    {

        /// <summary>
        /// Examples: {"invoice_application_list":[{"application_id":"20012229017610001","application_status":2,"trigger_status":1,"order_sn":"170717-318748247040347","mall_id":1,"business_type":0,"payer_name":"zhx","payer_register_no":"12341","invoice_kind":0,"invoice_type":0,"invoice_amount":null,"sum_price":null,"tax_rate":null,"sum_tax":null,"reason":null,"memo":null,"gmt_create":1531294712935,"gmt_modified":1531373954962}]}
        /// </summary>
        [JsonProperty("invoice_application_query_response")]
        public InvoiceApplicationQueryResponse InvoiceApplicationQueryResponse { get; set; }
    }


}
