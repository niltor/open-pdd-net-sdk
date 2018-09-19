using System.Threading.Tasks;
using PddOpenSdk.Models.PddApiRequest;
using PddOpenSdk.Models.PddApiResponse;
namespace PddOpenSdk.Services.PddApiRequest
{
    public class DdkApiRequest : PddRequest
    {
        /// <summary>
        /// 多多进宝商品详情查询
        /// </summary>
        public async Task<DetailDdkGoodsResponseModel> DetailDdkGoodsAsync(DetailDdkGoodsRequestModel detailDdkGoods)
        {
            var result = await PostAsync<DetailDdkGoodsRequestModel, DetailDdkGoodsResponseModel>("pdd.ddk.goods.detail", detailDdkGoods);
            return result;
        }
        /// <summary>
        /// 多多进宝商品查询
        /// </summary>
        public async Task<SearchDdkGoodsResponseModel> SearchDdkGoodsAsync(SearchDdkGoodsRequestModel searchDdkGoods)
        {
            var result = await PostAsync<SearchDdkGoodsRequestModel, SearchDdkGoodsResponseModel>("pdd.ddk.goods.search", searchDdkGoods);
            return result;
        }
        /// <summary>
        /// 查询已经生成的推广位信息
        /// </summary>
        public async Task<QueryDdkGoodsPidResponseModel> QueryDdkGoodsPidAsync(QueryDdkGoodsPidRequestModel queryDdkGoodsPid)
        {
            var result = await PostAsync<QueryDdkGoodsPidRequestModel, QueryDdkGoodsPidResponseModel>("pdd.ddk.goods.pid.query", queryDdkGoodsPid);
            return result;
        }
        /// <summary>
        /// 创建多多进宝推广位
        /// </summary>
        public async Task<GenerateDdkGoodsPidResponseModel> GenerateDdkGoodsPidAsync(GenerateDdkGoodsPidRequestModel generateDdkGoodsPid)
        {
            var result = await PostAsync<GenerateDdkGoodsPidRequestModel, GenerateDdkGoodsPidResponseModel>("pdd.ddk.goods.pid.generate", generateDdkGoodsPid);
            return result;
        }
        /// <summary>
        /// 多多进宝推广链接生成
        /// </summary>
        public async Task<GenerateDdkGoodsPromotionUrlResponseModel> GenerateDdkGoodsPromotionUrlAsync(GenerateDdkGoodsPromotionUrlRequestModel generateDdkGoodsPromotionUrl)
        {
            var result = await PostAsync<GenerateDdkGoodsPromotionUrlRequestModel, GenerateDdkGoodsPromotionUrlResponseModel>("pdd.ddk.goods.promotion.url.generate", generateDdkGoodsPromotionUrl);
            return result;
        }
        /// <summary>
        /// 最后更新时间段增量同步推广订单信息
        /// </summary>
        public async Task<GetDdkOrderListIncrementResponseModel> GetDdkOrderListIncrementAsync(GetDdkOrderListIncrementRequestModel getDdkOrderListIncrement)
        {
            var result = await PostAsync<GetDdkOrderListIncrementRequestModel, GetDdkOrderListIncrementResponseModel>("pdd.ddk.order.list.increment.get", getDdkOrderListIncrement);
            return result;
        }
        /// <summary>
        /// 生成红包推广链接
        /// </summary>
        public async Task<GenerateDdkRpPromUrlResponseModel> GenerateDdkRpPromUrlAsync(GenerateDdkRpPromUrlRequestModel generateDdkRpPromUrl)
        {
            var result = await PostAsync<GenerateDdkRpPromUrlRequestModel, GenerateDdkRpPromUrlResponseModel>("pdd.ddk.rp.prom.url.generate", generateDdkRpPromUrl);
            return result;
        }
        /// <summary>
        /// 生成频道推广链接
        /// </summary>
        public async Task<GenerateDdkCmsPromUrlResponseModel> GenerateDdkCmsPromUrlAsync(GenerateDdkCmsPromUrlRequestModel generateDdkCmsPromUrl)
        {
            var result = await PostAsync<GenerateDdkCmsPromUrlRequestModel, GenerateDdkCmsPromUrlResponseModel>("pdd.ddk.cms.prom.url.generate", generateDdkCmsPromUrl);
            return result;
        }
        /// <summary>
        /// 多多进宝主题列表查询
        /// </summary>
        public async Task<GetDdkThemeListResponseModel> GetDdkThemeListAsync(GetDdkThemeListRequestModel getDdkThemeList)
        {
            var result = await PostAsync<GetDdkThemeListRequestModel, GetDdkThemeListResponseModel>("pdd.ddk.theme.list.get", getDdkThemeList);
            return result;
        }
        /// <summary>
        /// 多多进宝主题商品查询
        /// </summary>
        public async Task<SearchDdkThemeGoodsResponseModel> SearchDdkThemeGoodsAsync(SearchDdkThemeGoodsRequestModel searchDdkThemeGoods)
        {
            var result = await PostAsync<SearchDdkThemeGoodsRequestModel, SearchDdkThemeGoodsResponseModel>("pdd.ddk.theme.goods.search", searchDdkThemeGoods);
            return result;
        }
        /// <summary>
        /// 多多进宝主题推广链接生成
        /// </summary>
        public async Task<GenerateDdkThemePromUrlResponseModel> GenerateDdkThemePromUrlAsync(GenerateDdkThemePromUrlRequestModel generateDdkThemePromUrl)
        {
            var result = await PostAsync<GenerateDdkThemePromUrlRequestModel, GenerateDdkThemePromUrlResponseModel>("pdd.ddk.theme.prom.url.generate", generateDdkThemePromUrl);
            return result;
        }
        /// <summary>
        /// 多多客拉新账单
        /// </summary>
        public async Task<GetDdkAppNewBillListResponseModel> GetDdkAppNewBillListAsync(GetDdkAppNewBillListRequestModel getDdkAppNewBillList)
        {
            var result = await PostAsync<GetDdkAppNewBillListRequestModel, GetDdkAppNewBillListResponseModel>("pdd.ddk.app.new.bill.list.get", getDdkAppNewBillList);
            return result;
        }
        /// <summary>
        /// 定向推广商品查询接口
        /// </summary>
        public async Task<QueryDdkDirectGoodsResponseModel> QueryDdkDirectGoodsAsync(QueryDdkDirectGoodsRequestModel queryDdkDirectGoods)
        {
            var result = await PostAsync<QueryDdkDirectGoodsRequestModel, QueryDdkDirectGoodsResponseModel>("pdd.ddk.direct.goods.query", queryDdkDirectGoods);
            return result;
        }
        /// <summary>
        /// 多多进宝转链接口
        /// </summary>
        public async Task<GenDdkGoodsZsUnitUrlResponseModel> GenDdkGoodsZsUnitUrlAsync(GenDdkGoodsZsUnitUrlRequestModel genDdkGoodsZsUnitUrl)
        {
            var result = await PostAsync<GenDdkGoodsZsUnitUrlRequestModel, GenDdkGoodsZsUnitUrlResponseModel>("pdd.ddk.goods.zs.unit.url.gen", genDdkGoodsZsUnitUrl);
            return result;
        }
        /// <summary>
        /// 查询招商推广计划商品
        /// </summary>
        public async Task<QueryDdkZsUnitGoodsResponseModel> QueryDdkZsUnitGoodsAsync(QueryDdkZsUnitGoodsRequestModel queryDdkZsUnitGoods)
        {
            var result = await PostAsync<QueryDdkZsUnitGoodsRequestModel, QueryDdkZsUnitGoodsResponseModel>("pdd.ddk.zs.unit.goods.query", queryDdkZsUnitGoods);
            return result;
        }
        /// <summary>
        /// 多多客生成单品推广小程序二维码url
        /// </summary>
        public async Task<GenDdkWeappQrcodeUrlResponseModel> GenDdkWeappQrcodeUrlAsync(GenDdkWeappQrcodeUrlRequestModel genDdkWeappQrcodeUrl)
        {
            var result = await PostAsync<GenDdkWeappQrcodeUrlRequestModel, GenDdkWeappQrcodeUrlResponseModel>("pdd.ddk.weapp.qrcode.url.gen", genDdkWeappQrcodeUrl);
            return result;
        }
        /// <summary>
        /// 获取商品基本信息接口
        /// </summary>
        public async Task<GetDdkGoodsBasicInfoResponseModel> GetDdkGoodsBasicInfoAsync(GetDdkGoodsBasicInfoRequestModel getDdkGoodsBasicInfo)
        {
            var result = await PostAsync<GetDdkGoodsBasicInfoRequestModel, GetDdkGoodsBasicInfoResponseModel>("pdd.ddk.goods.basic.info.get", getDdkGoodsBasicInfo);
            return result;
        }
        /// <summary>
        /// 运营频道商品查询API
        /// </summary>
        public async Task<GetDdkGoodsRecommendResponseModel> GetDdkGoodsRecommendAsync(GetDdkGoodsRecommendRequestModel getDdkGoodsRecommend)
        {
            var result = await PostAsync<GetDdkGoodsRecommendRequestModel, GetDdkGoodsRecommendResponseModel>("pdd.ddk.goods.recommend.get", getDdkGoodsRecommend);
            return result;
        }
        /// <summary>
        /// 查询订单详情
        /// </summary>
        public async Task<GetDdkOrderDetailResponseModel> GetDdkOrderDetailAsync(GetDdkOrderDetailRequestModel getDdkOrderDetail)
        {
            var result = await PostAsync<GetDdkOrderDetailRequestModel, GetDdkOrderDetailResponseModel>("pdd.ddk.order.detail.get", getDdkOrderDetail);
            return result;
        }
        /// <summary>
        /// 查询店铺商品
        /// </summary>
        public async Task<GetDdkMallGoodsListResponseModel> GetDdkMallGoodsListAsync(GetDdkMallGoodsListRequestModel getDdkMallGoodsList)
        {
            var result = await PostAsync<GetDdkMallGoodsListRequestModel, GetDdkMallGoodsListResponseModel>("pdd.ddk.mall.goods.list.get", getDdkMallGoodsList);
            return result;
        }
        /// <summary>
        /// 多多客生成店铺推广链接API
        /// </summary>
        public async Task<GenDdkMallUrlResponseModel> GenDdkMallUrlAsync(GenDdkMallUrlRequestModel genDdkMallUrl)
        {
            var result = await PostAsync<GenDdkMallUrlRequestModel, GenDdkMallUrlResponseModel>("pdd.ddk.mall.url.gen", genDdkMallUrl);
            return result;
        }
        /// <summary>
        /// 多多客生成转盘抽免单url
        /// </summary>
        public async Task<GenDdkLotteryUrlResponseModel> GenDdkLotteryUrlAsync(GenDdkLotteryUrlRequestModel genDdkLotteryUrl)
        {
            var result = await PostAsync<GenDdkLotteryUrlRequestModel, GenDdkLotteryUrlResponseModel>("pdd.ddk.lottery.url.gen", genDdkLotteryUrl);
            return result;
        }
        /// <summary>
        /// 多多客查询转盘拉新订单列表
        /// </summary>
        public async Task<GetDdkLotteryNewListResponseModel> GetDdkLotteryNewListAsync(GetDdkLotteryNewListRequestModel getDdkLotteryNewList)
        {
            var result = await PostAsync<GetDdkLotteryNewListRequestModel, GetDdkLotteryNewListResponseModel>("pdd.ddk.lottery.new.list.get", getDdkLotteryNewList);
            return result;
        }
        /// <summary>
        /// 生成拼多多主站频道推广
        /// </summary>
        public async Task<GenDdkResourceUrlResponseModel> GenDdkResourceUrlAsync(GenDdkResourceUrlRequestModel genDdkResourceUrl)
        {
            var result = await PostAsync<GenDdkResourceUrlRequestModel, GenDdkResourceUrlResponseModel>("pdd.ddk.resource.url.gen", genDdkResourceUrl);
            return result;
        }

    }
}
