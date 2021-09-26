
using PddOpenSdk.Models.Request.MallShop;
using PddOpenSdk.Models.Response.MallShop;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApi
{
    public class MallShopApi : PddCommonApi
    {
        public MallShopApi() { }
        public MallShopApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }
        /// <summary>
        /// 查询店铺是否签署多多进宝协议接口
        /// </summary>
        public async Task<QueryMallCpsProtocolStatusResponseModel> QueryMallCpsProtocolStatusAsync(QueryMallCpsProtocolStatusRequestModel queryMallCpsProtocolStatus)
        {
            var result = await PostAsync<QueryMallCpsProtocolStatusRequestModel, QueryMallCpsProtocolStatusResponseModel>("pdd.mall.cps.protocol.status.query", queryMallCpsProtocolStatus);
            return result;
        }
        /// <summary>
        /// 店铺信息接口
        /// </summary>
        public async Task<GetMallInfoResponseModel> GetMallInfoAsync(GetMallInfoRequestModel getMallInfo)
        {
            var result = await PostAsync<GetMallInfoRequestModel, GetMallInfoResponseModel>("pdd.mall.info.get", getMallInfo);
            return result;
        }
        /// <summary>
        /// 溯源服务商上传溯源码信息
        /// </summary>
        public async Task<InfoTraceSourceUploadCodeResponseModel> InfoTraceSourceUploadCodeAsync(InfoTraceSourceUploadCodeRequestModel infoTraceSourceUploadCode)
        {
            var result = await PostAsync<InfoTraceSourceUploadCodeRequestModel, InfoTraceSourceUploadCodeResponseModel>("pdd.trace.source.upload.code.info", infoTraceSourceUploadCode);
            return result;
        }
        /// <summary>
        /// 溯源服务商上传正品溯源粘贴计划
        /// </summary>
        public async Task<InfoTraceSourceUploadPlanResponseModel> InfoTraceSourceUploadPlanAsync(InfoTraceSourceUploadPlanRequestModel infoTraceSourceUploadPlan)
        {
            var result = await PostAsync<InfoTraceSourceUploadPlanRequestModel, InfoTraceSourceUploadPlanResponseModel>("pdd.trace.source.upload.plan.info", infoTraceSourceUploadPlan);
            return result;
        }
        /// <summary>
        /// 根据防伪码ID获取溯源商品信息
        /// </summary>
        public async Task<InfoTraceSourceQueryGoodsResponseModel> InfoTraceSourceQueryGoodsAsync(InfoTraceSourceQueryGoodsRequestModel infoTraceSourceQueryGoods)
        {
            var result = await PostAsync<InfoTraceSourceQueryGoodsRequestModel, InfoTraceSourceQueryGoodsResponseModel>("pdd.trace.source.query.goods.info", infoTraceSourceQueryGoods);
            return result;
        }

    }
}
