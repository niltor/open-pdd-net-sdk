using PddOpenSdk.Models.PddApiResult;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApiRequest
{
    public class MallApiRequest : PddRequest {
        /// <summary>
/// 获取店铺审核状态
/// </summary>
public async Task<GetMallInfoAuditApiResult> GetMallInfoAuditAsync()
{
    var dic = new Dictionary<string, string>();
        
    var result = Post<GetMallInfoAuditApiResult>("pdd.mall.info.audit.get",dic);
    return JsonConvert.DeserializeObject<GetMallInfoAuditApiResult>(result);
}/// <summary>
/// 创建新店铺
/// </summary>
/// <param name="UserId">第三方软件账号id</param>
/// <param name="WwName">店主名称</param>
public async Task<CreateMallInfoApiResult> CreateMallInfoAsync(string UserId,string WwName)
{
    var dic = new Dictionary<string, string>();
    dic.Add("user_id",UserId);
dic.Add("ww_name",WwName);
    
    var result = Post<CreateMallInfoApiResult>("pdd.mall.info.create",dic);
    return JsonConvert.DeserializeObject<CreateMallInfoApiResult>(result);
}/// <summary>
/// 店铺信息接口
/// </summary>
public async Task<GetMallInfoApiResult> GetMallInfoAsync()
{
    var dic = new Dictionary<string, string>();
        
    var result = Post<GetMallInfoApiResult>("pdd.mall.info.get",dic);
    return JsonConvert.DeserializeObject<GetMallInfoApiResult>(result);
}/// <summary>
/// 提交校验店铺申请
/// </summary>
/// <param name="GoodsId">商品id</param>
/// <param name="UserId">第三方软件账号id</param>
/// <param name="WwName">店主名称</param>
public async Task<AddMallInfoVerifyApplicationApiResult> AddMallInfoVerifyApplicationAsync(string GoodsId,string UserId,string WwName)
{
    var dic = new Dictionary<string, string>();
    dic.Add("goods_id",GoodsId);
dic.Add("user_id",UserId);
dic.Add("ww_name",WwName);
    
    var result = Post<AddMallInfoVerifyApplicationApiResult>("pdd.mall.info.verify.application.add",dic);
    return JsonConvert.DeserializeObject<AddMallInfoVerifyApplicationApiResult>(result);
}/// <summary>
/// 获取店铺校验码
/// </summary>
/// <param name="UserId">第三方软件账号id</param>
/// <param name="WwName">店主名称</param>
public async Task<GetMallInfoVerifyCodeApiResult> GetMallInfoVerifyCodeAsync(string UserId,string WwName)
{
    var dic = new Dictionary<string, string>();
    dic.Add("user_id",UserId);
dic.Add("ww_name",WwName);
    
    var result = Post<GetMallInfoVerifyCodeApiResult>("pdd.mall.info.verify.code.get",dic);
    return JsonConvert.DeserializeObject<GetMallInfoVerifyCodeApiResult>(result);
}
    }
}
