using PddOpenSdk.Models.Request.Order;
using PddOpenSdk.Models.Response.Order;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApi
{
    public class OrderApi : PddCommonApi
    {
        /// <summary>
        /// erp打单信息同步
        /// </summary>
        public async Task<SyncErpOrderResponseModel> SyncErpOrderAsync(SyncErpOrderRequestModel syncErpOrder)
        {
            var result = await PostAsync<SyncErpOrderRequestModel, SyncErpOrderResponseModel>("pdd.erp.order.sync", syncErpOrder);
            return result;
        }
        /// <summary>
        /// 订单详情
        /// </summary>
        public async Task<GetOrderInformationResponseModel> GetOrderInformationAsync(GetOrderInformationRequestModel getOrderInformation)
        {
            var result = await PostAsync<GetOrderInformationRequestModel, GetOrderInformationResponseModel>("pdd.order.information.get", getOrderInformation);
            return result;
        }
        /// <summary>
        /// 订单列表查询接口（根据成交时间）
        /// </summary>
        public async Task<GetOrderListResponseModel> GetOrderListAsync(GetOrderListRequestModel getOrderList)
        {
            var result = await PostAsync<GetOrderListRequestModel, GetOrderListResponseModel>("pdd.order.list.get", getOrderList);
            return result;
        }
        /// <summary>
        /// 订单全量列表
        /// </summary>
        public async Task<GetOrderNumberListResponseModel> GetOrderNumberListAsync(GetOrderNumberListRequestModel getOrderNumberList)
        {
            var result = await PostAsync<GetOrderNumberListRequestModel, GetOrderNumberListResponseModel>("pdd.order.number.list.get", getOrderNumberList);
            return result;
        }
        /// <summary>
        /// 订单增量接口
        /// </summary>
        public async Task<GetOrderNumberListIncrementResponseModel> GetOrderNumberListIncrementAsync(GetOrderNumberListIncrementRequestModel getOrderNumberListIncrement)
        {
            var result = await PostAsync<GetOrderNumberListIncrementRequestModel, GetOrderNumberListIncrementResponseModel>("pdd.order.number.list.increment.get", getOrderNumberListIncrement);
            return result;
        }
        /// <summary>
        /// 订单状态
        /// </summary>
        public async Task<GetOrderStatusResponseModel> GetOrderStatusAsync(GetOrderStatusRequestModel getOrderStatus)
        {
            var result = await PostAsync<GetOrderStatusRequestModel, GetOrderStatusResponseModel>("pdd.order.status.get", getOrderStatus);
            return result;
        }

    }
}
