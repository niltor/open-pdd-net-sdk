using PddOpenSdk.Models.Request.Ddkoauth;
using PddOpenSdk.Models.Response.Ddkoauth;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApi
{
    public class DdkOauthApi : PddCommonApi
    {
        /// <summary>
        /// 查询所有授权的多多客订单
        /// </summary>
        public async Task<GetDdkAllOrderListIncrementResponseModel> GetDdkAllOrderListIncrementAsync(GetDdkAllOrderListIncrementRequestModel getDdkAllOrderListIncrement)
        {
            var result = await PostAsync<GetDdkAllOrderListIncrementRequestModel, GetDdkAllOrderListIncrementResponseModel>("pdd.ddk.all.order.list.increment.get", getDdkAllOrderListIncrement);
            return result;
        }
        /// <summary>
        /// 生成商城推广链接接口
        /// </summary>
        public async Task<GenerateDdkOauthCmsPromUrlResponseModel> GenerateDdkOauthCmsPromUrlAsync(GenerateDdkOauthCmsPromUrlRequestModel generateDdkOauthCmsPromUrl)
        {
            var result = await PostAsync<GenerateDdkOauthCmsPromUrlRequestModel, GenerateDdkOauthCmsPromUrlResponseModel>("pdd.ddk.oauth.cms.prom.url.generate", generateDdkOauthCmsPromUrl);
            return result;
        }
        /// <summary>
        /// 多多进宝推广位创建接口
        /// </summary>
        public async Task<GenerateDdkOauthGoodsPidResponseModel> GenerateDdkOauthGoodsPidAsync(GenerateDdkOauthGoodsPidRequestModel generateDdkOauthGoodsPid)
        {
            var result = await PostAsync<GenerateDdkOauthGoodsPidRequestModel, GenerateDdkOauthGoodsPidResponseModel>("pdd.ddk.oauth.goods.pid.generate", generateDdkOauthGoodsPid);
            return result;
        }
        /// <summary>
        /// 多多客已生成推广位信息查询
        /// </summary>
        public async Task<QueryDdkOauthGoodsPidResponseModel> QueryDdkOauthGoodsPidAsync(QueryDdkOauthGoodsPidRequestModel queryDdkOauthGoodsPid)
        {
            var result = await PostAsync<QueryDdkOauthGoodsPidRequestModel, QueryDdkOauthGoodsPidResponseModel>("pdd.ddk.oauth.goods.pid.query", queryDdkOauthGoodsPid);
            return result;
        }
        /// <summary>
        /// 生成多多进宝推广链接
        /// </summary>
        public async Task<GenerateDdkOauthGoodsPromUrlResponseModel> GenerateDdkOauthGoodsPromUrlAsync(GenerateDdkOauthGoodsPromUrlRequestModel generateDdkOauthGoodsPromUrl)
        {
            var result = await PostAsync<GenerateDdkOauthGoodsPromUrlRequestModel, GenerateDdkOauthGoodsPromUrlResponseModel>("pdd.ddk.oauth.goods.prom.url.generate", generateDdkOauthGoodsPromUrl);
            return result;
        }
        /// <summary>
        /// 运营频道商品查询API
        /// </summary>
        public async Task<GetDdkOauthGoodsRecommendResponseModel> GetDdkOauthGoodsRecommendAsync(GetDdkOauthGoodsRecommendRequestModel getDdkOauthGoodsRecommend)
        {
            var result = await PostAsync<GetDdkOauthGoodsRecommendRequestModel, GetDdkOauthGoodsRecommendResponseModel>("pdd.ddk.oauth.goods.recommend.get", getDdkOauthGoodsRecommend);
            return result;
        }
        /// <summary>
        /// 生成招商推广链接
        /// </summary>
        public async Task<GenDdkOauthGoodsZsUnitUrlResponseModel> GenDdkOauthGoodsZsUnitUrlAsync(GenDdkOauthGoodsZsUnitUrlRequestModel genDdkOauthGoodsZsUnitUrl)
        {
            var result = await PostAsync<GenDdkOauthGoodsZsUnitUrlRequestModel, GenDdkOauthGoodsZsUnitUrlResponseModel>("pdd.ddk.oauth.goods.zs.unit.url.gen", genDdkOauthGoodsZsUnitUrl);
            return result;
        }
        /// <summary>
        /// 多多客工具查询转盘拉新订单列表
        /// </summary>
        public async Task<GetDdkOauthLotteryNewListResponseModel> GetDdkOauthLotteryNewListAsync(GetDdkOauthLotteryNewListRequestModel getDdkOauthLotteryNewList)
        {
            var result = await PostAsync<GetDdkOauthLotteryNewListRequestModel, GetDdkOauthLotteryNewListResponseModel>("pdd.ddk.oauth.lottery.new.list.get", getDdkOauthLotteryNewList);
            return result;
        }
        /// <summary>
        /// 多多客工具生成转盘抽免单url
        /// </summary>
        public async Task<GenDdkOauthLotteryUrlResponseModel> GenDdkOauthLotteryUrlAsync(GenDdkOauthLotteryUrlRequestModel genDdkOauthLotteryUrl)
        {
            var result = await PostAsync<GenDdkOauthLotteryUrlRequestModel, GenDdkOauthLotteryUrlResponseModel>("pdd.ddk.oauth.lottery.url.gen", genDdkOauthLotteryUrl);
            return result;
        }
        /// <summary>
        /// 多多客工具生成店铺推广链接API
        /// </summary>
        public async Task<GenDdkOauthMallUrlResponseModel> GenDdkOauthMallUrlAsync(GenDdkOauthMallUrlRequestModel genDdkOauthMallUrl)
        {
            var result = await PostAsync<GenDdkOauthMallUrlRequestModel, GenDdkOauthMallUrlResponseModel>("pdd.ddk.oauth.mall.url.gen", genDdkOauthMallUrl);
            return result;
        }
        /// <summary>
        /// 获取订单详情
        /// </summary>
        public async Task<GetDdkOauthOrderDetailResponseModel> GetDdkOauthOrderDetailAsync(GetDdkOauthOrderDetailRequestModel getDdkOauthOrderDetail)
        {
            var result = await PostAsync<GetDdkOauthOrderDetailRequestModel, GetDdkOauthOrderDetailResponseModel>("pdd.ddk.oauth.order.detail.get", getDdkOauthOrderDetail);
            return result;
        }
        /// <summary>
        /// 多多客工具生成多多口令接口
        /// </summary>
        public async Task<GenerateDdkOauthPhraseResponseModel> GenerateDdkOauthPhraseAsync(GenerateDdkOauthPhraseRequestModel generateDdkOauthPhrase)
        {
            var result = await PostAsync<GenerateDdkOauthPhraseRequestModel, GenerateDdkOauthPhraseResponseModel>("pdd.ddk.oauth.phrase.generate", generateDdkOauthPhrase);
            return result;
        }
        /// <summary>
        /// 拼多多主站频道推广接口
        /// </summary>
        public async Task<GenDdkOauthResourceUrlResponseModel> GenDdkOauthResourceUrlAsync(GenDdkOauthResourceUrlRequestModel genDdkOauthResourceUrl)
        {
            var result = await PostAsync<GenDdkOauthResourceUrlRequestModel, GenDdkOauthResourceUrlResponseModel>("pdd.ddk.oauth.resource.url.gen", genDdkOauthResourceUrl);
            return result;
        }
        /// <summary>
        /// 生成红包推广链接接口
        /// </summary>
        public async Task<GenerateDdkOauthRpPromUrlResponseModel> GenerateDdkOauthRpPromUrlAsync(GenerateDdkOauthRpPromUrlRequestModel generateDdkOauthRpPromUrl)
        {
            var result = await PostAsync<GenerateDdkOauthRpPromUrlRequestModel, GenerateDdkOauthRpPromUrlResponseModel>("pdd.ddk.oauth.rp.prom.url.generate", generateDdkOauthRpPromUrl);
            return result;
        }
        /// <summary>
        /// 多多进宝主题推广链接生成接口
        /// </summary>
        public async Task<GenerateDdkOauthThemePromUrlResponseModel> GenerateDdkOauthThemePromUrlAsync(GenerateDdkOauthThemePromUrlRequestModel generateDdkOauthThemePromUrl)
        {
            var result = await PostAsync<GenerateDdkOauthThemePromUrlRequestModel, GenerateDdkOauthThemePromUrlResponseModel>("pdd.ddk.oauth.theme.prom.url.generate", generateDdkOauthThemePromUrl);
            return result;
        }
        /// <summary>
        /// 多多客工具获取爆款排行商品接口
        /// </summary>
        public async Task<QueryDdkOauthTopGoodsListResponseModel> QueryDdkOauthTopGoodsListAsync(QueryDdkOauthTopGoodsListRequestModel queryDdkOauthTopGoodsList)
        {
            var result = await PostAsync<QueryDdkOauthTopGoodsListRequestModel, QueryDdkOauthTopGoodsListResponseModel>("pdd.ddk.oauth.top.goods.list.query", queryDdkOauthTopGoodsList);
            return result;
        }
        /// <summary>
        /// 查询招商推广计划商品接口
        /// </summary>
        public async Task<QueryDdkOauthZsUnitGoodsResponseModel> QueryDdkOauthZsUnitGoodsAsync(QueryDdkOauthZsUnitGoodsRequestModel queryDdkOauthZsUnitGoods)
        {
            var result = await PostAsync<QueryDdkOauthZsUnitGoodsRequestModel, QueryDdkOauthZsUnitGoodsResponseModel>("pdd.ddk.oauth.zs.unit.goods.query", queryDdkOauthZsUnitGoods);
            return result;
        }

    }
}
