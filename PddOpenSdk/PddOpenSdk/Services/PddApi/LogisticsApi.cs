using System.Threading.Tasks;
using PddOpenSdk.Models.Request.Logistics;
using PddOpenSdk.Models.Response.Logistics;
namespace PddOpenSdk.Services.PddApi
{
    public class LogisticsApi : PddCommonApi
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
        /// 订单发货通知接口
        /// </summary>
        public async Task<SendLogisticsOnlineResponseModel> SendLogisticsOnlineAsync(SendLogisticsOnlineRequestModel sendLogisticsOnline)
        {
            var result = await PostAsync<SendLogisticsOnlineRequestModel, SendLogisticsOnlineResponseModel>("pdd.logistics.online.send", sendLogisticsOnline);
            return result;
        }

    }
}
