
using PddOpenSdk.Models.Request.Oversea;
using PddOpenSdk.Models.Response.Oversea;
namespace PddOpenSdk.Services.PddApi;
public class OverseaApi : PddCommonApi
{
    public OverseaApi() { }
    public OverseaApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }

    /// <summary>
    /// 保税仓信息查询接口
    /// </summary>
    public async Task<GetMallInfoBondedWarehouseResponse> GetMallInfoBondedWarehouseAsync(GetMallInfoBondedWarehouse getMallInfoBondedWarehouse)
    {
        var result = await PostAsync<GetMallInfoBondedWarehouse, GetMallInfoBondedWarehouseResponse>("pdd.mall.info.bonded.warehouse.get", getMallInfoBondedWarehouse);
        return result;
    }

    /// <summary>
    /// 获取多多国际清关材料
    /// </summary>
    public async Task<GetOverseaClearanceResponse> GetOverseaClearanceAsync(GetOverseaClearance getOverseaClearance)
    {
        var result = await PostAsync<GetOverseaClearance, GetOverseaClearanceResponse>("pdd.oversea.clearance.get", getOverseaClearance);
        return result;
    }

    /// <summary>
    /// 同步海淘订单申报失败情况
    /// </summary>
    public async Task<NotifyOverseaDeclarationFailResponse> NotifyOverseaDeclarationFailAsync(NotifyOverseaDeclarationFail notifyOverseaDeclarationFail)
    {
        var result = await PostAsync<NotifyOverseaDeclarationFail, NotifyOverseaDeclarationFailResponse>("pdd.oversea.declaration.fail.notify", notifyOverseaDeclarationFail);
        return result;
    }

}
