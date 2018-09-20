using PddOpenSdk.Models.PddApiRequest;
using PddOpenSdk.Models.PddApiResponse;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Services.PddApiRequest
{
    public class DdkApiRequest : PddRequest {
        /// <summary>
/// 获取多多客拉新账单
/// </summary>
public async Task<GetDdkOauthAppNewBillListResponseModel> GetDdkOauthAppNewBillListAsync(GetDdkOauthAppNewBillListRequestModel getDdkOauthAppNewBillList)
{
    var result = await PostAsync<GetDdkOauthAppNewBillListRequestModel,GetDdkOauthAppNewBillListResponseModel>("pdd.ddk.oauth.app.new.bill.list.get",getDdkOauthAppNewBillList);
    return result;
}
/// <summary>
/// 生成商城推广链接接口
/// </summary>
public async Task<GenerateDdkOauthCmsPromUrlResponseModel> GenerateDdkOauthCmsPromUrlAsync(GenerateDdkOauthCmsPromUrlRequestModel generateDdkOauthCmsPromUrl)
{
    var result = await PostAsync<GenerateDdkOauthCmsPromUrlRequestModel,GenerateDdkOauthCmsPromUrlResponseModel>("pdd.ddk.oauth.cms.prom.url.generate",generateDdkOauthCmsPromUrl);
    return result;
}
/// <summary>
/// 多多进宝推广位创建接口
/// </summary>
public async Task<GenerateDdkOauthGoodsPidResponseModel> GenerateDdkOauthGoodsPidAsync(GenerateDdkOauthGoodsPidRequestModel generateDdkOauthGoodsPid)
{
    var result = await PostAsync<GenerateDdkOauthGoodsPidRequestModel,GenerateDdkOauthGoodsPidResponseModel>("pdd.ddk.oauth.goods.pid.generate",generateDdkOauthGoodsPid);
    return result;
}
/// <summary>
/// 多多客已生成推广位信息查询
/// </summary>
public async Task<QueryDdkOauthGoodsPidResponseModel> QueryDdkOauthGoodsPidAsync(QueryDdkOauthGoodsPidRequestModel queryDdkOauthGoodsPid)
{
    var result = await PostAsync<QueryDdkOauthGoodsPidRequestModel,QueryDdkOauthGoodsPidResponseModel>("pdd.ddk.oauth.goods.pid.query",queryDdkOauthGoodsPid);
    return result;
}
/// <summary>
/// 生成多多进宝推广链接
/// </summary>
public async Task<GenerateDdkOauthGoodsPromUrlResponseModel> GenerateDdkOauthGoodsPromUrlAsync(GenerateDdkOauthGoodsPromUrlRequestModel generateDdkOauthGoodsPromUrl)
{
    var result = await PostAsync<GenerateDdkOauthGoodsPromUrlRequestModel,GenerateDdkOauthGoodsPromUrlResponseModel>("pdd.ddk.oauth.goods.prom.url.generate",generateDdkOauthGoodsPromUrl);
    return result;
}
/// <summary>
/// 生成招商推广链接
/// </summary>
public async Task<GenDdkOauthGoodsZsUnitUrlResponseModel> GenDdkOauthGoodsZsUnitUrlAsync(GenDdkOauthGoodsZsUnitUrlRequestModel genDdkOauthGoodsZsUnitUrl)
{
    var result = await PostAsync<GenDdkOauthGoodsZsUnitUrlRequestModel,GenDdkOauthGoodsZsUnitUrlResponseModel>("pdd.ddk.oauth.goods.zs.unit.url.gen",genDdkOauthGoodsZsUnitUrl);
    return result;
}
/// <summary>
/// 多多客工具查询转盘拉新订单列表
/// </summary>
public async Task<GetDdkOauthLotteryNewListResponseModel> GetDdkOauthLotteryNewListAsync(GetDdkOauthLotteryNewListRequestModel getDdkOauthLotteryNewList)
{
    var result = await PostAsync<GetDdkOauthLotteryNewListRequestModel,GetDdkOauthLotteryNewListResponseModel>("pdd.ddk.oauth.lottery.new.list.get",getDdkOauthLotteryNewList);
    return result;
}
/// <summary>
/// 多多客工具生成转盘抽免单url
/// </summary>
public async Task<GenDdkOauthLotteryUrlResponseModel> GenDdkOauthLotteryUrlAsync(GenDdkOauthLotteryUrlRequestModel genDdkOauthLotteryUrl)
{
    var result = await PostAsync<GenDdkOauthLotteryUrlRequestModel,GenDdkOauthLotteryUrlResponseModel>("pdd.ddk.oauth.lottery.url.gen",genDdkOauthLotteryUrl);
    return result;
}
/// <summary>
/// 多多客工具生成店铺推广链接API
/// </summary>
public async Task<GenDdkOauthMallUrlResponseModel> GenDdkOauthMallUrlAsync(GenDdkOauthMallUrlRequestModel genDdkOauthMallUrl)
{
    var result = await PostAsync<GenDdkOauthMallUrlRequestModel,GenDdkOauthMallUrlResponseModel>("pdd.ddk.oauth.mall.url.gen",genDdkOauthMallUrl);
    return result;
}
/// <summary>
/// 获取订单详情
/// </summary>
public async Task<GetDdkOauthOrderDetailResponseModel> GetDdkOauthOrderDetailAsync(GetDdkOauthOrderDetailRequestModel getDdkOauthOrderDetail)
{
    var result = await PostAsync<GetDdkOauthOrderDetailRequestModel,GetDdkOauthOrderDetailResponseModel>("pdd.ddk.oauth.order.detail.get",getDdkOauthOrderDetail);
    return result;
}
/// <summary>
/// 按照更新时间段增量同步推广订单信息
/// </summary>
public async Task<GetDdkOauthOrderListIncrementResponseModel> GetDdkOauthOrderListIncrementAsync(GetDdkOauthOrderListIncrementRequestModel getDdkOauthOrderListIncrement)
{
    var result = await PostAsync<GetDdkOauthOrderListIncrementRequestModel,GetDdkOauthOrderListIncrementResponseModel>("pdd.ddk.oauth.order.list.increment.get",getDdkOauthOrderListIncrement);
    return result;
}
/// <summary>
/// 拼多多主站频道推广接口
/// </summary>
public async Task<GenDdkOauthResourceUrlResponseModel> GenDdkOauthResourceUrlAsync(GenDdkOauthResourceUrlRequestModel genDdkOauthResourceUrl)
{
    var result = await PostAsync<GenDdkOauthResourceUrlRequestModel,GenDdkOauthResourceUrlResponseModel>("pdd.ddk.oauth.resource.url.gen",genDdkOauthResourceUrl);
    return result;
}
/// <summary>
/// 生成红包推广链接接口
/// </summary>
public async Task<GenerateDdkOauthRpPromUrlResponseModel> GenerateDdkOauthRpPromUrlAsync(GenerateDdkOauthRpPromUrlRequestModel generateDdkOauthRpPromUrl)
{
    var result = await PostAsync<GenerateDdkOauthRpPromUrlRequestModel,GenerateDdkOauthRpPromUrlResponseModel>("pdd.ddk.oauth.rp.prom.url.generate",generateDdkOauthRpPromUrl);
    return result;
}
/// <summary>
/// 多多进宝主题推广链接生成接口
/// </summary>
public async Task<GenerateDdkOauthThemePromUrlResponseModel> GenerateDdkOauthThemePromUrlAsync(GenerateDdkOauthThemePromUrlRequestModel generateDdkOauthThemePromUrl)
{
    var result = await PostAsync<GenerateDdkOauthThemePromUrlRequestModel,GenerateDdkOauthThemePromUrlResponseModel>("pdd.ddk.oauth.theme.prom.url.generate",generateDdkOauthThemePromUrl);
    return result;
}
/// <summary>
/// 多多客工具生成单品推广小程序二维码
/// </summary>
public async Task<GenDdkOauthWeappQrcodeUrlResponseModel> GenDdkOauthWeappQrcodeUrlAsync(GenDdkOauthWeappQrcodeUrlRequestModel genDdkOauthWeappQrcodeUrl)
{
    var result = await PostAsync<GenDdkOauthWeappQrcodeUrlRequestModel,GenDdkOauthWeappQrcodeUrlResponseModel>("pdd.ddk.oauth.weapp.qrcode.url.gen",genDdkOauthWeappQrcodeUrl);
    return result;
}
/// <summary>
/// 查询招商推广计划商品接口
/// </summary>
public async Task<QueryDdkOauthZsUnitGoodsResponseModel> QueryDdkOauthZsUnitGoodsAsync(QueryDdkOauthZsUnitGoodsRequestModel queryDdkOauthZsUnitGoods)
{
    var result = await PostAsync<QueryDdkOauthZsUnitGoodsRequestModel,QueryDdkOauthZsUnitGoodsResponseModel>("pdd.ddk.oauth.zs.unit.goods.query",queryDdkOauthZsUnitGoods);
    return result;
}

    }
}
