
using PddOpenSdk.Models.Request.MallShop;
using PddOpenSdk.Models.Response.MallShop;

namespace PddOpenSdk.Services.PddApi;
public class MallShopApi : PddCommonApi
{
    public MallShopApi() { }
    public MallShopApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }

    /// <summary>
    /// 查询店铺是否签署多多进宝协议接口
    /// </summary>
    public async Task<QueryMallCpsProtocolStatusResponse> QueryMallCpsProtocolStatusAsync(QueryMallCpsProtocolStatus queryMallCpsProtocolStatus)
    {
        var result = await PostAsync<QueryMallCpsProtocolStatus, QueryMallCpsProtocolStatusResponse>("pdd.mall.cps.protocol.status.query", queryMallCpsProtocolStatus);
        return result;
    }

    /// <summary>
    /// 店铺信息接口
    /// </summary>
    public async Task<GetMallInfoResponse> GetMallInfoAsync(GetMallInfo getMallInfo)
    {
        var result = await PostAsync<GetMallInfo, GetMallInfoResponse>("pdd.mall.info.get", getMallInfo);
        return result;
    }

    /// <summary>
    /// 判断是否对商家展示某个通知
    /// </summary>
    public async Task<CheckMallNotificationTypeShowResponse> CheckMallNotificationTypeShowAsync(CheckMallNotificationTypeShow checkMallNotificationTypeShow)
    {
        var result = await PostAsync<CheckMallNotificationTypeShow, CheckMallNotificationTypeShowResponse>("pdd.mall.notification.type.show.check", checkMallNotificationTypeShow);
        return result;
    }

    /// <summary>
    /// 溯源服务商上传溯源码信息
    /// </summary>
    public async Task<InfoTraceSourceUploadCodeResponse> InfoTraceSourceUploadCodeAsync(InfoTraceSourceUploadCode infoTraceSourceUploadCode)
    {
        var result = await PostAsync<InfoTraceSourceUploadCode, InfoTraceSourceUploadCodeResponse>("pdd.trace.source.upload.code.info", infoTraceSourceUploadCode);
        return result;
    }

    /// <summary>
    /// 溯源服务商上传正品溯源粘贴计划
    /// </summary>
    public async Task<InfoTraceSourceUploadPlanResponse> InfoTraceSourceUploadPlanAsync(InfoTraceSourceUploadPlan infoTraceSourceUploadPlan)
    {
        var result = await PostAsync<InfoTraceSourceUploadPlan, InfoTraceSourceUploadPlanResponse>("pdd.trace.source.upload.plan.info", infoTraceSourceUploadPlan);
        return result;
    }

    /// <summary>
    /// 根据防伪码ID获取溯源商品信息
    /// </summary>
    public async Task<InfoTraceSourceQueryGoodsResponse> InfoTraceSourceQueryGoodsAsync(InfoTraceSourceQueryGoods infoTraceSourceQueryGoods)
    {
        var result = await PostAsync<InfoTraceSourceQueryGoods, InfoTraceSourceQueryGoodsResponse>("pdd.trace.source.query.goods.info", infoTraceSourceQueryGoods);
        return result;
    }

}
