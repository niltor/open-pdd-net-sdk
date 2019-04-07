using System.Threading.Tasks;
using PddOpenSdk.Models.Request.Mall;
using PddOpenSdk.Models.Response.Mall;
namespace PddOpenSdk.Services.PddApi
{
    public class MallApi : PddCommonApi {
        /// <summary>
        /// 查询店铺是否签署多多进宝协议接口
        /// </summary>
        public async Task<QueryMallCpsProtocolStatusResponseModel> QueryMallCpsProtocolStatusAsync (QueryMallCpsProtocolStatusRequestModel queryMallCpsProtocolStatus) {
            var result = await PostAsync<QueryMallCpsProtocolStatusRequestModel, QueryMallCpsProtocolStatusResponseModel> ("pdd.mall.cps.protocol.status.query", queryMallCpsProtocolStatus);
            return result;
        }
        /// <summary>
        /// 获取店铺审核状态
        /// </summary>
        public async Task<GetMallInfoAuditResponseModel> GetMallInfoAuditAsync (GetMallInfoAuditRequestModel getMallInfoAudit) {
            var result = await PostAsync<GetMallInfoAuditRequestModel, GetMallInfoAuditResponseModel> ("pdd.mall.info.audit.get", getMallInfoAudit);
            return result;
        }
        /// <summary>
        /// 创建新店铺
        /// </summary>
        public async Task<CreateMallInfoResponseModel> CreateMallInfoAsync (CreateMallInfoRequestModel createMallInfo) {
            var result = await PostAsync<CreateMallInfoRequestModel, CreateMallInfoResponseModel> ("pdd.mall.info.create", createMallInfo);
            return result;
        }
        /// <summary>
        /// 店铺信息接口
        /// </summary>
        public async Task<GetMallInfoResponseModel> GetMallInfoAsync (GetMallInfoRequestModel getMallInfo) {
            var result = await PostAsync<GetMallInfoRequestModel, GetMallInfoResponseModel> ("pdd.mall.info.get", getMallInfo);
            return result;
        }
        /// <summary>
        /// 提交校验店铺申请
        /// </summary>
        public async Task<AddMallInfoVerifyApplicationResponseModel> AddMallInfoVerifyApplicationAsync (AddMallInfoVerifyApplicationRequestModel addMallInfoVerifyApplication) {
            var result = await PostAsync<AddMallInfoVerifyApplicationRequestModel, AddMallInfoVerifyApplicationResponseModel> ("pdd.mall.info.verify.application.add", addMallInfoVerifyApplication);
            return result;
        }
        /// <summary>
        /// 获取店铺校验码
        /// </summary>
        public async Task<GetMallInfoVerifyCodeResponseModel> GetMallInfoVerifyCodeAsync (GetMallInfoVerifyCodeRequestModel getMallInfoVerifyCode) {
            var result = await PostAsync<GetMallInfoVerifyCodeRequestModel, GetMallInfoVerifyCodeResponseModel> ("pdd.mall.info.verify.code.get", getMallInfoVerifyCode);
            return result;
        }

    }
}