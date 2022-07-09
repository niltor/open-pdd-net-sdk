
using PddOpenSdk.Models.Request.Invoice;
using PddOpenSdk.Models.Response.Invoice;

namespace PddOpenSdk.Services.PddApi;
public class InvoiceApi : PddCommonApi
{
    public InvoiceApi() { }
    public InvoiceApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }

    /// <summary>
    /// 自动开票发票查询
    /// </summary>
    public async Task<QueryEinvoiceInfoResponse> QueryEinvoiceInfoAsync(QueryEinvoiceInfo queryEinvoiceInfo)
    {
        var result = await PostAsync<QueryEinvoiceInfo, QueryEinvoiceInfoResponse>("pdd.einvoice.info.query", queryEinvoiceInfo);
        return result;
    }

    /// <summary>
    /// 开票申请单查询
    /// </summary>
    public async Task<QueryInvoiceApplicationResponse> QueryInvoiceApplicationAsync(QueryInvoiceApplication queryInvoiceApplication)
    {
        var result = await PostAsync<QueryInvoiceApplication, QueryInvoiceApplicationResponse>("pdd.invoice.application.query", queryInvoiceApplication);
        return result;
    }

    /// <summary>
    /// 订单发票冲红
    /// </summary>
    public async Task<InvalidInvoiceDetailResponse> InvalidInvoiceDetailAsync(InvalidInvoiceDetail invalidInvoiceDetail)
    {
        var result = await PostAsync<InvalidInvoiceDetail, InvalidInvoiceDetailResponse>("pdd.invoice.detail.invalid", invalidInvoiceDetail);
        return result;
    }

    /// <summary>
    /// 开票结果回传
    /// </summary>
    public async Task<UploadInvoiceDetailResponse> UploadInvoiceDetailAsync(UploadInvoiceDetail uploadInvoiceDetail)
    {
        var result = await PostAsync<UploadInvoiceDetail, UploadInvoiceDetailResponse>("pdd.invoice.detail.upload", uploadInvoiceDetail);
        return result;
    }

}
