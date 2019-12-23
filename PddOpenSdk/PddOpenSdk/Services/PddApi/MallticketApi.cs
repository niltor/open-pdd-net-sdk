using System.Threading.Tasks;
using PddOpenSdk.Models.Request.Mallticket;
using PddOpenSdk.Models.Response.Mallticket;
namespace PddOpenSdk.Services.PddApi
{
    public class MallticketApi : PddCommonApi
    {
        /// <summary>
        /// 商家工单详情查询接口
        /// </summary>
        public async Task<DetailMallTicketResponseModel> DetailMallTicketAsync(DetailMallTicketRequestModel detailMallTicket)
        {
            var result = await PostAsync<DetailMallTicketRequestModel, DetailMallTicketResponseModel>("pdd.mall.ticket.detail", detailMallTicket);
            return result;
        }
        /// <summary>
        /// 商家工单列表查询接口
        /// </summary>
        public async Task<ListMallTicketResponseModel> ListMallTicketAsync(ListMallTicketRequestModel listMallTicket)
        {
            var result = await PostAsync<ListMallTicketRequestModel, ListMallTicketResponseModel>("pdd.mall.ticket.list", listMallTicket);
            return result;
        }
        /// <summary>
        /// 商家工单处理结果回调接口
        /// </summary>
        public async Task<NotifyMallTicketResponseModel> NotifyMallTicketAsync(NotifyMallTicketRequestModel notifyMallTicket)
        {
            var result = await PostAsync<NotifyMallTicketRequestModel, NotifyMallTicketResponseModel>("pdd.mall.ticket.notify", notifyMallTicket);
            return result;
        }

    }
}
