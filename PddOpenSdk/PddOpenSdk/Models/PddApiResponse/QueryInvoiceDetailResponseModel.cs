using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class QueryInvoiceDetailResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("invoice_detail_query_response")]
        public object InvoiceDetailQueryResponse { get; set; }

        public partial class InvoiceDetailQueryResponseResponseModel : PddResponseModel
        {

        }

    }
}
