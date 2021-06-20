
using PddOpenSdk.Models.Request.Oversea;
using PddOpenSdk.Models.Response.Oversea;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace PddOpenSdk.Services.PddApi
{
    public class OverseaApi : PddCommonApi {
        public OverseaApi(){}
        public OverseaApi(string clientId, string clientSecret, string accessToken): base(clientId, clientSecret, accessToken){}
        /// <summary>
/// 保税仓信息查询接口
/// </summary>
public async Task<GetMallInfoBondedWarehouseResponseModel> GetMallInfoBondedWarehouseAsync(GetMallInfoBondedWarehouseRequestModel getMallInfoBondedWarehouse)
{
    var result = await PostAsync<GetMallInfoBondedWarehouseRequestModel,GetMallInfoBondedWarehouseResponseModel>("pdd.mall.info.bonded.warehouse.get",getMallInfoBondedWarehouse);
    return result;
}
/// <summary>
/// 获取多多国际清关材料
/// </summary>
public async Task<GetOverseaClearanceResponseModel> GetOverseaClearanceAsync(GetOverseaClearanceRequestModel getOverseaClearance)
{
    var result = await PostAsync<GetOverseaClearanceRequestModel,GetOverseaClearanceResponseModel>("pdd.oversea.clearance.get",getOverseaClearance);
    return result;
}
/// <summary>
/// 同步海淘订单申报失败情况
/// </summary>
public async Task<NotifyOverseaDeclarationFailResponseModel> NotifyOverseaDeclarationFailAsync(NotifyOverseaDeclarationFailRequestModel notifyOverseaDeclarationFail)
{
    var result = await PostAsync<NotifyOverseaDeclarationFailRequestModel,NotifyOverseaDeclarationFailResponseModel>("pdd.oversea.declaration.fail.notify",notifyOverseaDeclarationFail);
    return result;
}

    }
}
