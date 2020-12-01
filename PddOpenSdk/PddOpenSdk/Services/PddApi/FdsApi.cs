
using System.Threading.Tasks;
using PddOpenSdk.Models.Request.Fds;
using PddOpenSdk.Models.Response.Fds;
namespace PddOpenSdk.Services.PddApi
{
    public class FdsApi : PddCommonApi
    {
        public FdsApi() { }
        public FdsApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }
        /// <summary>
        /// 订单详情
        /// </summary>
        public async Task<GetFdsOrderResponseModel> GetFdsOrderAsync(GetFdsOrderRequestModel getFdsOrder)
        {
            var result = await PostAsync<GetFdsOrderRequestModel, GetFdsOrderResponseModel>("pdd.fds.order.get", getFdsOrder);
            return result;
        }
        /// <summary>
        /// 根据更新时间查询订单列表
        /// </summary>
        public async Task<GetFdsOrderListResponseModel> GetFdsOrderListAsync(GetFdsOrderListRequestModel getFdsOrderList)
        {
            var result = await PostAsync<GetFdsOrderListRequestModel, GetFdsOrderListResponseModel>("pdd.fds.order.list.get", getFdsOrderList);
            return result;
        }
        /// <summary>
        /// 查询店铺身份
        /// </summary>
        public async Task<GetFdsRoleResponseModel> GetFdsRoleAsync(GetFdsRoleRequestModel getFdsRole)
        {
            var result = await PostAsync<GetFdsRoleRequestModel, GetFdsRoleResponseModel>("pdd.fds.role.get", getFdsRole);
            return result;
        }
        /// <summary>
        /// 电子面单取消回传
        /// </summary>
        public async Task<CancelFdsWaybillResponseModel> CancelFdsWaybillAsync(CancelFdsWaybillRequestModel cancelFdsWaybill)
        {
            var result = await PostAsync<CancelFdsWaybillRequestModel, CancelFdsWaybillResponseModel>("pdd.fds.waybill.cancel", cancelFdsWaybill);
            return result;
        }
        /// <summary>
        /// 电子面单取号
        /// </summary>
        public async Task<GetFdsWaybillResponseModel> GetFdsWaybillAsync(GetFdsWaybillRequestModel getFdsWaybill)
        {
            var result = await PostAsync<GetFdsWaybillRequestModel, GetFdsWaybillResponseModel>("pdd.fds.waybill.get", getFdsWaybill);
            return result;
        }
        /// <summary>
        /// 电子面单回传
        /// </summary>
        public async Task<ReturnFdsWaybillResponseModel> ReturnFdsWaybillAsync(ReturnFdsWaybillRequestModel returnFdsWaybill)
        {
            var result = await PostAsync<ReturnFdsWaybillRequestModel, ReturnFdsWaybillResponseModel>("pdd.fds.waybill.return", returnFdsWaybill);
            return result;
        }

    }
}
