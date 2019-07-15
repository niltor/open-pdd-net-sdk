using PddOpenSdk.Models.Request.Logisticsordertrace;
using PddOpenSdk.Models.Response.Logisticsordertrace;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApi
{
    public class LogisticsordertraceApi : PddCommonApi
    {
        /// <summary>
        /// 获取拼多多标准国家地址库
        /// </summary>
        public async Task<GetLogisticsAddressResponseModel> GetLogisticsAddressAsync(GetLogisticsAddressRequestModel getLogisticsAddress)
        {
            var result = await PostAsync<GetLogisticsAddressRequestModel, GetLogisticsAddressResponseModel>("pdd.logistics.address.get", getLogisticsAddress);
            return result;
        }
        /// <summary>
        /// 快递公司查看接口
        /// </summary>
        public async Task<GetLogisticsCompaniesResponseModel> GetLogisticsCompaniesAsync(GetLogisticsCompaniesRequestModel getLogisticsCompanies)
        {
            var result = await PostAsync<GetLogisticsCompaniesRequestModel, GetLogisticsCompaniesResponseModel>("pdd.logistics.companies.get", getLogisticsCompanies);
            return result;
        }
        /// <summary>
        /// 在线下单订单下发接口
        /// </summary>
        public async Task<CreateLogisticsOnlineResponseModel> CreateLogisticsOnlineAsync(CreateLogisticsOnlineRequestModel createLogisticsOnline)
        {
            var result = await PostAsync<CreateLogisticsOnlineRequestModel, CreateLogisticsOnlineResponseModel>("pdd.logistics.online.create", createLogisticsOnline);
            return result;
        }
        /// <summary>
        /// 订单发货通知接口
        /// </summary>
        public async Task<SendLogisticsOnlineResponseModel> SendLogisticsOnlineAsync(SendLogisticsOnlineRequestModel sendLogisticsOnline)
        {
            var result = await PostAsync<SendLogisticsOnlineRequestModel, SendLogisticsOnlineResponseModel>("pdd.logistics.online.send", sendLogisticsOnline);
            return result;
        }
        /// <summary>
        /// 根据订单号查询在线下单状态
        /// </summary>
        public async Task<QueryLogisticsOnlineStatusResponseModel> QueryLogisticsOnlineStatusAsync(QueryLogisticsOnlineStatusRequestModel queryLogisticsOnlineStatus)
        {
            var result = await PostAsync<QueryLogisticsOnlineStatusRequestModel, QueryLogisticsOnlineStatusResponseModel>("pdd.logistics.online.status.query", queryLogisticsOnlineStatus);
            return result;
        }
        /// <summary>
        /// 轨迹查询接口
        /// </summary>
        public async Task<GetLogisticsOrdertraceResponseModel> GetLogisticsOrdertraceAsync(GetLogisticsOrdertraceRequestModel getLogisticsOrdertrace)
        {
            var result = await PostAsync<GetLogisticsOrdertraceRequestModel, GetLogisticsOrdertraceResponseModel>("pdd.logistics.ordertrace.get", getLogisticsOrdertrace);
            return result;
        }

    }
}
