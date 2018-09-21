using System.Threading.Tasks;
using PddOpenSdk.Models.PddApiRequest;
using PddOpenSdk.Models.PddApiResponse;
namespace PddOpenSdk.Services.PddApiRequest
{
    public class TimeApiRequest : PddApi
    {
        /// <summary>
        /// 获取拼多多系统时间
        /// </summary>
        public async Task<GetTimeResponseModel> GetTimeAsync(GetTimeRequestModel getTime)
        {
            var result = await PostAsync<GetTimeRequestModel, GetTimeResponseModel>("pdd.time.get", getTime);
            return result;
        }

    }
}
