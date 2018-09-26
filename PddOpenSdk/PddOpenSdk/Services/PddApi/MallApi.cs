using System.Threading.Tasks;
using PddOpenSdk.Models.Request.Mall;
using PddOpenSdk.Models.Response.Mall;
namespace PddOpenSdk.Services.PddApi
{
    public class MallApi : PddCommonApi
    {
        /// <summary>
        /// 店铺信息接口
        /// </summary>
        public async Task<GetMallInfoResponseModel> GetMallInfoAsync(GetMallInfoRequestModel getMallInfo)
        {
            var result = await PostAsync<GetMallInfoRequestModel, GetMallInfoResponseModel>("pdd.mall.info.get", getMallInfo);
            return result;
        }

    }
}
