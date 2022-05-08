
using PddOpenSdk.Models.Request.DdkTools;
using PddOpenSdk.Models.Response.DdkTools;
namespace PddOpenSdk.Services.PddApi;
public class DdkToolsApi : PddCommonApi
{
    public DdkToolsApi() { }
    public DdkToolsApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }

    /// <summary>
    /// 查询所有授权的多多客订单
    /// </summary>
    public async Task<GetDdkAllOrderListIncrementResponse> GetDdkAllOrderListIncrementAsync(GetDdkAllOrderListIncrement getDdkAllOrderListIncrement)
    {
        var result = await PostAsync<GetDdkAllOrderListIncrement, GetDdkAllOrderListIncrementResponse>("pdd.ddk.all.order.list.increment.get", getDdkAllOrderListIncrement);
        return result;
    }

    /// <summary>
    /// 创建多多礼金
    /// </summary>
    public async Task<CreateDdkOauthCashgiftResponse> CreateDdkOauthCashgiftAsync(CreateDdkOauthCashgift createDdkOauthCashgift)
    {
        var result = await PostAsync<CreateDdkOauthCashgift, CreateDdkOauthCashgiftResponse>("pdd.ddk.oauth.cashgift.create", createDdkOauthCashgift);
        return result;
    }

    /// <summary>
    /// 多多礼金状态更新
    /// </summary>
    public async Task<UpdateDdkOauthCashgiftStatusResponse> UpdateDdkOauthCashgiftStatusAsync(UpdateDdkOauthCashgiftStatus updateDdkOauthCashgiftStatus)
    {
        var result = await PostAsync<UpdateDdkOauthCashgiftStatus, UpdateDdkOauthCashgiftStatusResponse>("pdd.ddk.oauth.cashgift.status.update", updateDdkOauthCashgiftStatus);
        return result;
    }

    /// <summary>
    /// 生成商城推广链接接口
    /// </summary>
    public async Task<GenerateDdkOauthCmsPromUrlResponse> GenerateDdkOauthCmsPromUrlAsync(GenerateDdkOauthCmsPromUrl generateDdkOauthCmsPromUrl)
    {
        var result = await PostAsync<GenerateDdkOauthCmsPromUrl, GenerateDdkOauthCmsPromUrlResponse>("pdd.ddk.oauth.cms.prom.url.generate", generateDdkOauthCmsPromUrl);
        return result;
    }

    /// <summary>
    /// 多多进宝商品详情查询
    /// </summary>
    public async Task<DetailDdkOauthGoodsResponse> DetailDdkOauthGoodsAsync(DetailDdkOauthGoods detailDdkOauthGoods)
    {
        var result = await PostAsync<DetailDdkOauthGoods, DetailDdkOauthGoodsResponse>("pdd.ddk.oauth.goods.detail", detailDdkOauthGoods);
        return result;
    }

    /// <summary>
    /// 多多进宝推广位创建接口
    /// </summary>
    public async Task<GenerateDdkOauthGoodsPidResponse> GenerateDdkOauthGoodsPidAsync(GenerateDdkOauthGoodsPid generateDdkOauthGoodsPid)
    {
        var result = await PostAsync<GenerateDdkOauthGoodsPid, GenerateDdkOauthGoodsPidResponse>("pdd.ddk.oauth.goods.pid.generate", generateDdkOauthGoodsPid);
        return result;
    }

    /// <summary>
    /// 多多客已生成推广位信息查询
    /// </summary>
    public async Task<QueryDdkOauthGoodsPidResponse> QueryDdkOauthGoodsPidAsync(QueryDdkOauthGoodsPid queryDdkOauthGoodsPid)
    {
        var result = await PostAsync<QueryDdkOauthGoodsPid, QueryDdkOauthGoodsPidResponse>("pdd.ddk.oauth.goods.pid.query", queryDdkOauthGoodsPid);
        return result;
    }

    /// <summary>
    /// 生成多多进宝推广链接
    /// </summary>
    public async Task<GenerateDdkOauthGoodsPromUrlResponse> GenerateDdkOauthGoodsPromUrlAsync(GenerateDdkOauthGoodsPromUrl generateDdkOauthGoodsPromUrl)
    {
        var result = await PostAsync<GenerateDdkOauthGoodsPromUrl, GenerateDdkOauthGoodsPromUrlResponse>("pdd.ddk.oauth.goods.prom.url.generate", generateDdkOauthGoodsPromUrl);
        return result;
    }

    /// <summary>
    /// 运营频道商品查询API
    /// </summary>
    public async Task<GetDdkOauthGoodsRecommendResponse> GetDdkOauthGoodsRecommendAsync(GetDdkOauthGoodsRecommend getDdkOauthGoodsRecommend)
    {
        var result = await PostAsync<GetDdkOauthGoodsRecommend, GetDdkOauthGoodsRecommendResponse>("pdd.ddk.oauth.goods.recommend.get", getDdkOauthGoodsRecommend);
        return result;
    }

    /// <summary>
    /// 多多进宝商品查询
    /// </summary>
    public async Task<SearchDdkOauthGoodsResponse> SearchDdkOauthGoodsAsync(SearchDdkOauthGoods searchDdkOauthGoods)
    {
        var result = await PostAsync<SearchDdkOauthGoods, SearchDdkOauthGoodsResponse>("pdd.ddk.oauth.goods.search", searchDdkOauthGoods);
        return result;
    }

    /// <summary>
    /// 多多进宝转链接口
    /// </summary>
    public async Task<GenDdkOauthGoodsZsUnitUrlResponse> GenDdkOauthGoodsZsUnitUrlAsync(GenDdkOauthGoodsZsUnitUrl genDdkOauthGoodsZsUnitUrl)
    {
        var result = await PostAsync<GenDdkOauthGoodsZsUnitUrl, GenDdkOauthGoodsZsUnitUrlResponse>("pdd.ddk.oauth.goods.zs.unit.url.gen", genDdkOauthGoodsZsUnitUrl);
        return result;
    }

    /// <summary>
    /// 查询是否绑定备案
    /// </summary>
    public async Task<QueryDdkOauthMemberAuthorityResponse> QueryDdkOauthMemberAuthorityAsync(QueryDdkOauthMemberAuthority queryDdkOauthMemberAuthority)
    {
        var result = await PostAsync<QueryDdkOauthMemberAuthority, QueryDdkOauthMemberAuthorityResponse>("pdd.ddk.oauth.member.authority.query", queryDdkOauthMemberAuthority);
        return result;
    }

    /// <summary>
    /// 获取订单详情
    /// </summary>
    public async Task<GetDdkOauthOrderDetailResponse> GetDdkOauthOrderDetailAsync(GetDdkOauthOrderDetail getDdkOauthOrderDetail)
    {
        var result = await PostAsync<GetDdkOauthOrderDetail, GetDdkOauthOrderDetailResponse>("pdd.ddk.oauth.order.detail.get", getDdkOauthOrderDetail);
        return result;
    }

    /// <summary>
    /// 批量绑定推广位的媒体id
    /// </summary>
    public async Task<BindDdkOauthPidMediaidResponse> BindDdkOauthPidMediaidAsync(BindDdkOauthPidMediaid bindDdkOauthPidMediaid)
    {
        var result = await PostAsync<BindDdkOauthPidMediaid, BindDdkOauthPidMediaidResponse>("pdd.ddk.oauth.pid.mediaid.bind", bindDdkOauthPidMediaid);
        return result;
    }

    /// <summary>
    /// 拼多多主站频道推广接口
    /// </summary>
    public async Task<GenDdkOauthResourceUrlResponse> GenDdkOauthResourceUrlAsync(GenDdkOauthResourceUrl genDdkOauthResourceUrl)
    {
        var result = await PostAsync<GenDdkOauthResourceUrl, GenDdkOauthResourceUrlResponse>("pdd.ddk.oauth.resource.url.gen", genDdkOauthResourceUrl);
        return result;
    }

    /// <summary>
    /// 生成营销工具推广链接
    /// </summary>
    public async Task<GenerateDdkOauthRpPromUrlResponse> GenerateDdkOauthRpPromUrlAsync(GenerateDdkOauthRpPromUrl generateDdkOauthRpPromUrl)
    {
        var result = await PostAsync<GenerateDdkOauthRpPromUrl, GenerateDdkOauthRpPromUrlResponse>("pdd.ddk.oauth.rp.prom.url.generate", generateDdkOauthRpPromUrl);
        return result;
    }

    /// <summary>
    /// 多多客工具生成单品推广小程序二维码
    /// </summary>
    public async Task<GenDdkOauthWeappQrcodeUrlResponse> GenDdkOauthWeappQrcodeUrlAsync(GenDdkOauthWeappQrcodeUrl genDdkOauthWeappQrcodeUrl)
    {
        var result = await PostAsync<GenDdkOauthWeappQrcodeUrl, GenDdkOauthWeappQrcodeUrlResponse>("pdd.ddk.oauth.weapp.qrcode.url.gen", genDdkOauthWeappQrcodeUrl);
        return result;
    }

}
