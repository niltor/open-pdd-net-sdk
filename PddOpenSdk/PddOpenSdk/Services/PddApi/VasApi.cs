using System.Threading.Tasks;
using PddOpenSdk.Models.Request.Vas;
using PddOpenSdk.Models.Response.Vas;
namespace PddOpenSdk.Services.PddApi
{
    public class VasApi : PddCommonApi
    {
        /// <summary>
        /// 线上服务市场订单查询接口
        /// </summary>
        public async Task<SearchVasOrderResponseModel> SearchVasOrderAsync(SearchVasOrderRequestModel searchVasOrder)
        {
            var result = await PostAsync<SearchVasOrderRequestModel, SearchVasOrderResponseModel>("pdd.vas.order.search", searchVasOrder);
            return result;
        }

    }
}
