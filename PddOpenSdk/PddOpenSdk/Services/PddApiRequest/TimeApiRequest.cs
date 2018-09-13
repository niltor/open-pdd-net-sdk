using App.Models.PddApiRequest;
using App.Models.PddApiResponse;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace App.Services.PddApiRequest
{
    public class TimeApiRequest : PddRequest {
        /// <summary>
/// 获取拼多多系统时间
/// </summary>
public async Task<GetTimeResponseModel> GetTimeAsync(GetTimeRequestModel getTime)
{
    var result = await PostAsync<GetTimeRequestModel,GetTimeResponseModel>("pdd.time.get",getTime);
    return result;
}

    }
}
