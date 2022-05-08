
using PddOpenSdk.Models.Request.Util;
using PddOpenSdk.Models.Response.Util;
namespace PddOpenSdk.Services.PddApi;
public class UtilApi : PddCommonApi
{
    public UtilApi() { }
    public UtilApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }

    /// <summary>
    /// 批量数据解密接口
    /// </summary>
    public async Task<BatchOpenDecryptResponse> BatchOpenDecryptAsync(BatchOpenDecrypt batchOpenDecrypt)
    {
        var result = await PostAsync<BatchOpenDecrypt, BatchOpenDecryptResponse>("pdd.open.decrypt.batch", batchOpenDecrypt);
        return result;
    }

    /// <summary>
    /// 批量数据解密脱敏接口
    /// </summary>
    public async Task<BatchOpenDecryptMaskResponse> BatchOpenDecryptMaskAsync(BatchOpenDecryptMask batchOpenDecryptMask)
    {
        var result = await PostAsync<BatchOpenDecryptMask, BatchOpenDecryptMaskResponse>("pdd.open.decrypt.mask.batch", batchOpenDecryptMask);
        return result;
    }

    /// <summary>
    /// 批量加密
    /// </summary>
    public async Task<BatchOpenKmsEncryptResponse> BatchOpenKmsEncryptAsync(BatchOpenKmsEncrypt batchOpenKmsEncrypt)
    {
        var result = await PostAsync<BatchOpenKmsEncrypt, BatchOpenKmsEncryptResponse>("pdd.open.kms.encrypt.batch", batchOpenKmsEncrypt);
        return result;
    }

    /// <summary>
    /// 获取搜索索引
    /// </summary>
    public async Task<BatchOpenKmsSearchResponse> BatchOpenKmsSearchAsync(BatchOpenKmsSearch batchOpenKmsSearch)
    {
        var result = await PostAsync<BatchOpenKmsSearch, BatchOpenKmsSearchResponse>("pdd.open.kms.search.batch", batchOpenKmsSearch);
        return result;
    }

    /// <summary>
    /// 虚拟号查询接口
    /// </summary>
    public async Task<CheckOpenVirtualNumberResponse> CheckOpenVirtualNumberAsync(CheckOpenVirtualNumber checkOpenVirtualNumber)
    {
        var result = await PostAsync<CheckOpenVirtualNumber, CheckOpenVirtualNumberResponse>("pdd.open.virtual.number.check", checkOpenVirtualNumber);
        return result;
    }

    /// <summary>
    /// 获取Access Token
    /// </summary>
    public async Task<CreatePopAuthTokenResponse> CreatePopAuthTokenAsync(CreatePopAuthToken createPopAuthToken)
    {
        var result = await PostAsync<CreatePopAuthToken, CreatePopAuthTokenResponse>("pdd.pop.auth.token.create", createPopAuthToken);
        return result;
    }

    /// <summary>
    /// 刷新Access Token
    /// </summary>
    public async Task<RefreshPopAuthTokenResponse> RefreshPopAuthTokenAsync(RefreshPopAuthToken refreshPopAuthToken)
    {
        var result = await PostAsync<RefreshPopAuthToken, RefreshPopAuthTokenResponse>("pdd.pop.auth.token.refresh", refreshPopAuthToken);
        return result;
    }

    /// <summary>
    /// 获取拼多多系统时间
    /// </summary>
    public async Task<GetTimeResponse> GetTimeAsync(GetTime getTime)
    {
        var result = await PostAsync<GetTime, GetTimeResponse>("pdd.time.get", getTime);
        return result;
    }

}
