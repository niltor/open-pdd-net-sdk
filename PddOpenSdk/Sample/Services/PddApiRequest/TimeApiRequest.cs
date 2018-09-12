using PddOpenSdk.Models.PddApiResult;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Services.PddApiRequest
{
    public class TimeApiRequest : PddRequest {
        /// <summary>
/// 获取拼多多系统时间
/// </summary>
public async Task<GetTimeApiResult> GetTimeAsync()
{
    var dic = new Dictionary<string, object>();
        
    var result = await PostAsync<GetTimeApiResult>("pdd.time.get",dic);
    return result;
}
    }
}
