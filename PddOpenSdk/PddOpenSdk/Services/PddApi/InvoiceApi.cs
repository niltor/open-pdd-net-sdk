using System.Threading.Tasks;
using PddOpenSdk.Models.Request.Invoice;
using PddOpenSdk.Models.Response.Invoice;
namespace PddOpenSdk.Services.PddApi
{
    public class InvoiceApi : PddCommonApi
    {
        /// <summary>
        /// 开票申请单查询
        /// </summary>
        public async Task<QueryInvoiceApplicationResponseModel> QueryInvoiceApplicationAsync(QueryInvoiceApplicationRequestModel queryInvoiceApplication)
        {
            var result = await PostAsync<QueryInvoiceApplicationRequestModel, QueryInvoiceApplicationResponseModel>("pdd.invoice.application.query", queryInvoiceApplication);
            return result;
        }
        /// <summary>
        /// 开票申请单审核
        /// </summary>
        public async Task<UpdateInvoiceApplicationResponseModel> UpdateInvoiceApplicationAsync(UpdateInvoiceApplicationRequestModel updateInvoiceApplication)
        {
            var result = await PostAsync<UpdateInvoiceApplicationRequestModel, UpdateInvoiceApplicationResponseModel>("pdd.invoice.application.update", updateInvoiceApplication);
            return result;
        }
        /// <summary>
        /// 查询已回传发票
        /// </summary>
        public async Task<QueryInvoiceDetailResponseModel> QueryInvoiceDetailAsync(QueryInvoiceDetailRequestModel queryInvoiceDetail)
        {
            var result = await PostAsync<QueryInvoiceDetailRequestModel, QueryInvoiceDetailResponseModel>("pdd.invoice.detail.query", queryInvoiceDetail);
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
