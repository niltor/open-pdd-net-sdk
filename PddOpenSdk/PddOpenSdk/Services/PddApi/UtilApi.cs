
using System.Threading.Tasks;
using PddOpenSdk.Models.Request.Util;
using PddOpenSdk.Models.Response.Util;
namespace PddOpenSdk.Services.PddApi
{
    public class UtilApi : PddCommonApi
    {
        public UtilApi() { }
        public UtilApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }
        /// <summary>
        /// 批量数据解密接口
        /// </summary>
        public async Task<BatchOpenDecryptResponseModel> BatchOpenDecryptAsync(BatchOpenDecryptRequestModel batchOpenDecrypt)
        {
            var result = await PostAsync<BatchOpenDecryptRequestModel, BatchOpenDecryptResponseModel>("pdd.open.decrypt.batch", batchOpenDecrypt);
            return result;
        }
        /// <summary>
        /// 批量数据解密脱敏接口
        /// </summary>
        public async Task<BatchOpenDecryptMaskResponseModel> BatchOpenDecryptMaskAsync(BatchOpenDecryptMaskRequestModel batchOpenDecryptMask)
        {
            var result = await PostAsync<BatchOpenDecryptMaskRequestModel, BatchOpenDecryptMaskResponseModel>("pdd.open.decrypt.mask.batch", batchOpenDecryptMask);
            return result;
        }
        /// <summary>
        /// 批量加密
        /// </summary>
        public async Task<BatchOpenKmsEncryptResponseModel> BatchOpenKmsEncryptAsync(BatchOpenKmsEncryptRequestModel batchOpenKmsEncrypt)
        {
            var result = await PostAsync<BatchOpenKmsEncryptRequestModel, BatchOpenKmsEncryptResponseModel>("pdd.open.kms.encrypt.batch", batchOpenKmsEncrypt);
            return result;
        }
        /// <summary>
        /// 获取搜索索引
        /// </summary>
        public async Task<BatchOpenKmsSearchResponseModel> BatchOpenKmsSearchAsync(BatchOpenKmsSearchRequestModel batchOpenKmsSearch)
        {
            var result = await PostAsync<BatchOpenKmsSearchRequestModel, BatchOpenKmsSearchResponseModel>("pdd.open.kms.search.batch", batchOpenKmsSearch);
            return result;
        }
        /// <summary>
        /// 非拼面单报备接口
        /// </summary>
        public async Task<ReportOpenWaybillTypeResponseModel> ReportOpenWaybillTypeAsync(ReportOpenWaybillTypeRequestModel reportOpenWaybillType)
        {
            var result = await PostAsync<ReportOpenWaybillTypeRequestModel, ReportOpenWaybillTypeResponseModel>("pdd.open.waybill.type.report", reportOpenWaybillType);
            return result;
        }
        /// <summary>
        /// 获取Access Token
        /// </summary>
        public async Task<CreatePopAuthTokenResponseModel> CreatePopAuthTokenAsync(CreatePopAuthTokenRequestModel createPopAuthToken)
        {
            var result = await PostAsync<CreatePopAuthTokenRequestModel, CreatePopAuthTokenResponseModel>("pdd.pop.auth.token.create", createPopAuthToken);
            return result;
        }
        /// <summary>
        /// 刷新Access Token
        /// </summary>
        public async Task<RefreshPopAuthTokenResponseModel> RefreshPopAuthTokenAsync(RefreshPopAuthTokenRequestModel refreshPopAuthToken)
        {
            var result = await PostAsync<RefreshPopAuthTokenRequestModel, RefreshPopAuthTokenResponseModel>("pdd.pop.auth.token.refresh", refreshPopAuthToken);
            return result;
        }
        /// <summary>
        /// 获取拼多多系统时间
        /// </summary>
        public async Task<GetTimeResponseModel> GetTimeAsync(GetTimeRequestModel getTime)
        {
            var result = await PostAsync<GetTimeRequestModel, GetTimeResponseModel>("pdd.time.get", getTime);
            return result;
        }

    }
}
