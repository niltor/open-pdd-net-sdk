
using PddOpenSdk.Models.Request.WayBill;
using PddOpenSdk.Models.Response.WayBill;

namespace PddOpenSdk.Services.PddApi;
public class WayBillApi : PddCommonApi
{
    public WayBillApi() { }
    public WayBillApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }

    /// <summary>
    /// 生成打印机渲染命令（通过打印机命令打印）
    /// </summary>
    public async Task<RenderCloudprintCmdprintResponse> RenderCloudprintCmdprintAsync(RenderCloudprintCmdprint renderCloudprintCmdprint)
    {
        var result = await PostAsync<RenderCloudprintCmdprint, RenderCloudprintCmdprintResponse>("pdd.cloudprint.cmdprint.render", renderCloudprintCmdprint);
        return result;
    }

    /// <summary>
    /// 获取商家的自定义区模板信息
    /// </summary>
    public async Task<GetCloudprintCustomaresResponse> GetCloudprintCustomaresAsync(GetCloudprintCustomares getCloudprintCustomares)
    {
        var result = await PostAsync<GetCloudprintCustomares, GetCloudprintCustomaresResponse>("pdd.cloudprint.customares.get", getCloudprintCustomares);
        return result;
    }

    /// <summary>
    /// 获取所有已支持便携式打印机
    /// </summary>
    public async Task<GetCloudprintPortableprinterResponse> GetCloudprintPortableprinterAsync(GetCloudprintPortableprinter getCloudprintPortableprinter)
    {
        var result = await PostAsync<GetCloudprintPortableprinter, GetCloudprintPortableprinterResponse>("pdd.cloudprint.portableprinter.get", getCloudprintPortableprinter);
        return result;
    }

    /// <summary>
    /// 获取所有标准电子面单模板
    /// </summary>
    public async Task<GetCloudprintStdtemplatesResponse> GetCloudprintStdtemplatesAsync(GetCloudprintStdtemplates getCloudprintStdtemplates)
    {
        var result = await PostAsync<GetCloudprintStdtemplates, GetCloudprintStdtemplatesResponse>("pdd.cloudprint.stdtemplates.get", getCloudprintStdtemplates);
        return result;
    }

    /// <summary>
    /// 商家取消获取的电子面单号
    /// </summary>
    public async Task<CancelWaybillResponse> CancelWaybillAsync(CancelWaybill cancelWaybill)
    {
        var result = await PostAsync<CancelWaybill, CancelWaybillResponse>("pdd.waybill.cancel", cancelWaybill);
        return result;
    }

    /// <summary>
    /// 电子面单云打印接口
    /// </summary>
    public async Task<GetWaybillResponse> GetWaybillAsync(GetWaybill getWaybill)
    {
        var result = await PostAsync<GetWaybill, GetWaybillResponse>("pdd.waybill.get", getWaybill);
        return result;
    }

    /// <summary>
    /// 通过面单号查询面单信息
    /// </summary>
    public async Task<WaybillcodeWaybillQueryByResponse> WaybillcodeWaybillQueryByAsync(WaybillcodeWaybillQueryBy waybillcodeWaybillQueryBy)
    {
        var result = await PostAsync<WaybillcodeWaybillQueryBy, WaybillcodeWaybillQueryByResponse>("pdd.waybill.query.by.waybillcode", waybillcodeWaybillQueryBy);
        return result;
    }

    /// <summary>
    /// 查询面单服务订购及面单使用情况
    /// </summary>
    public async Task<SearchWaybillResponse> SearchWaybillAsync(SearchWaybill searchWaybill)
    {
        var result = await PostAsync<SearchWaybill, SearchWaybillResponse>("pdd.waybill.search", searchWaybill);
        return result;
    }

    /// <summary>
    /// 电子面单云打印更新接口
    /// </summary>
    public async Task<UpdateWaybillResponse> UpdateWaybillAsync(UpdateWaybill updateWaybill)
    {
        var result = await PostAsync<UpdateWaybill, UpdateWaybillResponse>("pdd.waybill.update", updateWaybill);
        return result;
    }

}
