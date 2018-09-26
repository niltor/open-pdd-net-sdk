using System.Threading.Tasks;
using PddOpenSdk.Models.Request.Time;
using PddOpenSdk.Models.Response.Time;
namespace PddOpenSdk.Services.PddApi
{
    public class TimeApi : PddCommonApi
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
