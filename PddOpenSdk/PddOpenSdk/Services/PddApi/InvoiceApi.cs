
using PddOpenSdk.Models.Request.Invoice;
using PddOpenSdk.Models.Response.Invoice;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApi
{
    public class InvoiceApi : PddCommonApi
    {
        public InvoiceApi() { }
        public InvoiceApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }
        /// <summary>
        /// 自动开票发票查询
        /// </summary>
        public async Task<QueryEinvoiceInfoResponseModel> QueryEinvoiceInfoAsync(QueryEinvoiceInfoRequestModel queryEinvoiceInfo)
        {
            var result = await PostAsync<QueryEinvoiceInfoRequestModel, QueryEinvoiceInfoResponseModel>("pdd.einvoice.info.query", queryEinvoiceInfo);
            return result;
        }
        /// <summary>
        /// 开票申请单查询
        /// </summary>
        public async Task<QueryInvoiceApplicationResponseModel> QueryInvoiceApplicationAsync(QueryInvoiceApplicationRequestModel queryInvoiceApplication)
        {
            var result = await PostAsync<QueryInvoiceApplicationRequestModel, QueryInvoiceApplicationResponseModel>("pdd.invoice.application.query", queryInvoiceApplication);
            return result;
        }
        /// <summary>
        /// 订单发票冲红
        /// </summary>
        public async Task<InvalidInvoiceDetailResponseModel> InvalidInvoiceDetailAsync(InvalidInvoiceDetailRequestModel invalidInvoiceDetail)
        {
            var result = await PostAsync<InvalidInvoiceDetailRequestModel, InvalidInvoiceDetailResponseModel>("pdd.invoice.detail.invalid", invalidInvoiceDetail);
            return result;
        }
        /// <summary>
        /// 开票结果回传
        /// </summary>
        public async Task<UploadInvoiceDetailResponseModel> UploadInvoiceDetailAsync(UploadInvoiceDetailRequestModel uploadInvoiceDetail)
        {
            var result = await PostAsync<UploadInvoiceDetailRequestModel, UploadInvoiceDetailResponseModel>("pdd.invoice.detail.upload", uploadInvoiceDetail);
            return result;
        }

    }
}
