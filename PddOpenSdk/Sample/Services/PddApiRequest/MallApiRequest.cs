using PddOpenSdk.Models.PddApiResult;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Services.PddApiRequest
{
    public class MallApiRequest : PddRequest {
        /// <summary>
/// 店铺信息接口
/// </summary>
public async Task<GetMallInfoApiResult> GetMallInfoAsync()
{
    var dic = new Dictionary<string, object>();
        
    var result = await PostAsync<GetMallInfoApiResult>("pdd.mall.info.get",dic);
    return result;
}
    }
}
