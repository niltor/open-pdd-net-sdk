using PddOpenSdk.Models.PddApiResult;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApiRequest
{
    public class TimeApiRequest : PddRequest {
        /// <summary>
/// 获取拼多多系统时间
/// </summary>
public async Task<GetTimeApiResult> GetTimeAsync()
{
    var dic = new Dictionary<string, string>();
        
    var result = Post<GetTimeApiResult>(pdd.time.get,);
    return JsonConvert.DeserializeObject<GetTimeApiResult>(result);
}
    }
}
