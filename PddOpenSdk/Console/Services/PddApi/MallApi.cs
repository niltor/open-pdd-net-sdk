using PddOpenSdk.Models.Request;
using PddOpenSdk.Models.Response;
using PddOpenSdk.Models.Request.Mall;
using PddOpenSdk.Models.Response.Mall;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Services.PddApi
{
    public class MallApi : PddCommonApi {
        /// <summary>
/// 查询店铺是否签署多多进宝协议接口
/// </summary>
public async Task<QueryMallCpsProtocolStatusResponseModel> QueryMallCpsProtocolStatusAsync(QueryMallCpsProtocolStatusRequestModel queryMallCpsProtocolStatus)
{
    var result = await PostAsync<QueryMallCpsProtocolStatusRequestModel,QueryMallCpsProtocolStatusResponseModel>("pdd.mall.cps.protocol.status.query",queryMallCpsProtocolStatus);
    return result;
}
/// <summary>
/// 保税仓信息查询接口
/// </summary>
public async Task<GetMallInfoBondedWarehouseResponseModel> GetMallInfoBondedWarehouseAsync(GetMallInfoBondedWarehouseRequestModel getMallInfoBondedWarehouse)
{
    var result = await PostAsync<GetMallInfoBondedWarehouseRequestModel,GetMallInfoBondedWarehouseResponseModel>("pdd.mall.info.bonded.warehouse.get",getMallInfoBondedWarehouse);
    return result;
}
/// <summary>
/// 店铺信息接口
/// </summary>
public async Task<GetMallInfoResponseModel> GetMallInfoAsync(GetMallInfoRequestModel getMallInfo)
{
    var result = await PostAsync<GetMallInfoRequestModel,GetMallInfoResponseModel>("pdd.mall.info.get",getMallInfo);
    return result;
}

    }
}
