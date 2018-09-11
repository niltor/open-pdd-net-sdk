namespace PddOpenSdk.Services.PddApiRequest
{
    public class mall extends Request {
        /// <summary>
/// 获取店铺审核状态
/// </summary>
public async Task<GetMallInfoAuditApiResult> GetMallInfoAuditAsync()
{
    var dic = new Dictionary<string, string>();
        
    var result = Post<GetMallInfoAuditApiResult>(pdd.mall.info.audit.get,);
    return JsonConvert.DeserializeObject<GetMallInfoAuditApiResult>(result);
}/// <summary>
/// 创建新店铺
/// </summary>
/// <param name="UserId">第三方软件账号id</param>
/// <param name="WwName">店主名称</param>
public async Task<CreateMallInfoApiResult> CreateMallInfoAsync(string UserId,string WwName)
{
    var dic = new Dictionary<string, string>();
    dic.Add("user_id",User Id);
dic.Add("ww_name",Ww Name);
    
    var result = Post<CreateMallInfoApiResult>(pdd.mall.info.create,);
    return JsonConvert.DeserializeObject<CreateMallInfoApiResult>(result);
}/// <summary>
/// 店铺信息接口
/// </summary>
public async Task<GetMallInfoApiResult> GetMallInfoAsync()
{
    var dic = new Dictionary<string, string>();
        
    var result = Post<GetMallInfoApiResult>(pdd.mall.info.get,);
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
    dic.Add("goods_id",Goods Id);
dic.Add("user_id",User Id);
dic.Add("ww_name",Ww Name);
    
    var result = Post<AddMallInfoVerifyApplicationApiResult>(pdd.mall.info.verify.application.add,);
    return JsonConvert.DeserializeObject<AddMallInfoVerifyApplicationApiResult>(result);
}/// <summary>
/// 获取店铺校验码
/// </summary>
/// <param name="UserId">第三方软件账号id</param>
/// <param name="WwName">店主名称</param>
public async Task<GetMallInfoVerifyCodeApiResult> GetMallInfoVerifyCodeAsync(string UserId,string WwName)
{
    var dic = new Dictionary<string, string>();
    dic.Add("user_id",User Id);
dic.Add("ww_name",Ww Name);
    
    var result = Post<GetMallInfoVerifyCodeApiResult>(pdd.mall.info.verify.code.get,);
    return JsonConvert.DeserializeObject<GetMallInfoVerifyCodeApiResult>(result);
}
    }
}
