using System.Threading.Tasks;
using PddOpenSdk.Models.Request.Waybill;
using PddOpenSdk.Models.Response.Waybill;
namespace PddOpenSdk.Services.PddApi
{
    public class WaybillApi : PddCommonApi
    {
        /// <summary>
        /// 生成打印机渲染命令（通过打印机命令打印）
        /// </summary>
        public async Task<RenderCloudprintCmdprintResponseModel> RenderCloudprintCmdprintAsync(RenderCloudprintCmdprintRequestModel renderCloudprintCmdprint)
        {
            var result = await PostAsync<RenderCloudprintCmdprintRequestModel, RenderCloudprintCmdprintResponseModel>("pdd.cloudprint.cmdprint.render", renderCloudprintCmdprint);
            return result;
        }
        /// <summary>
        /// 获取商家的自定义区模板信息
        /// </summary>
        public async Task<GetCloudprintCustomaresResponseModel> GetCloudprintCustomaresAsync(GetCloudprintCustomaresRequestModel getCloudprintCustomares)
        {
            var result = await PostAsync<GetCloudprintCustomaresRequestModel, GetCloudprintCustomaresResponseModel>("pdd.cloudprint.customares.get", getCloudprintCustomares);
            return result;
        }
        /// <summary>
        /// 获取所有标准电子面单模板
        /// </summary>
        public async Task<GetCloudprintStdtemplatesResponseModel> GetCloudprintStdtemplatesAsync(GetCloudprintStdtemplatesRequestModel getCloudprintStdtemplates)
        {
            var result = await PostAsync<GetCloudprintStdtemplatesRequestModel, GetCloudprintStdtemplatesResponseModel>("pdd.cloudprint.stdtemplates.get", getCloudprintStdtemplates);
            return result;
        }
        /// <summary>
        /// 商家取消获取的电子面单号
        /// </summary>
        public async Task<CancelWaybillResponseModel> CancelWaybillAsync(CancelWaybillRequestModel cancelWaybill)
        {
            var result = await PostAsync<CancelWaybillRequestModel, CancelWaybillResponseModel>("pdd.waybill.cancel", cancelWaybill);
            return result;
        }
        /// <summary>
        /// 电子面单云打印接口
        /// </summary>
        public async Task<GetWaybillResponseModel> GetWaybillAsync(GetWaybillRequestModel getWaybill)
        {
            var result = await PostAsync<GetWaybillRequestModel, GetWaybillResponseModel>("pdd.waybill.get", getWaybill);
            return result;
        }
        /// <summary>
        /// 通过面单号查询面单信息
        /// </summary>
        public async Task<WaybillcodeWaybillQueryByResponseModel> WaybillcodeWaybillQueryByAsync(WaybillcodeWaybillQueryByRequestModel waybillcodeWaybillQueryBy)
        {
            var result = await PostAsync<WaybillcodeWaybillQueryByRequestModel, WaybillcodeWaybillQueryByResponseModel>("pdd.waybill.query.by.waybillcode", waybillcodeWaybillQueryBy);
            return result;
        }
        /// <summary>
        /// 查询面单服务订购及面单使用情况
        /// </summary>
        public async Task<SearchWaybillResponseModel> SearchWaybillAsync(SearchWaybillRequestModel searchWaybill)
        {
            var result = await PostAsync<SearchWaybillRequestModel, SearchWaybillResponseModel>("pdd.waybill.search", searchWaybill);
            return result;
        }
        /// <summary>
        /// 电子面单云打印更新接口
        /// </summary>
        public async Task<UpdateWaybillResponseModel> UpdateWaybillAsync(UpdateWaybillRequestModel updateWaybill)
        {
            var result = await PostAsync<UpdateWaybillRequestModel, UpdateWaybillResponseModel>("pdd.waybill.update", updateWaybill);
            return result;
        }

    }
}
