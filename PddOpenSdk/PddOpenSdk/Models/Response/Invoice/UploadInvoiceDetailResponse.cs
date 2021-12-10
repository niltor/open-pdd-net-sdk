namespace PddOpenSdk.Models.Response.Invoice;
public partial class UploadInvoiceDetailResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("invoice_detail_upload_response")]
    public InvoiceDetailUploadResponseResponse InvoiceDetailUploadResponse { get; set; }
    public partial class InvoiceDetailUploadResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 发票流水号
        /// </summary>
        [JsonPropertyName("serial_no")]
        public string SerialNo { get; set; }

    }

}

