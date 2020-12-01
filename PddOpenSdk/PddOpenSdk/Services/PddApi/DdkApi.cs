
using System.Threading.Tasks;
using PddOpenSdk.Models.Request.Ddk;
using PddOpenSdk.Models.Response.Ddk;
namespace PddOpenSdk.Services.PddApi
{
    public class DdkApi : PddCommonApi
    {
        public DdkApi() { }
        public DdkApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }
        /// <summary>
        /// 生成商城-频道推广链接
        /// </summary>
        public async Task<GenerateDdkCmsPromUrlResponseModel> GenerateDdkCmsPromUrlAsync(GenerateDdkCmsPromUrlRequestModel generateDdkCmsPromUrl)
        {
            var result = await PostAsync<GenerateDdkCmsPromUrlRequestModel, GenerateDdkCmsPromUrlResponseModel>("pdd.ddk.cms.prom.url.generate", generateDdkCmsPromUrl);
            return result;
        }
        /// <summary>
        /// 多多进宝商品详情查询
        /// </summary>
        public async Task<DetailDdkGoodsResponseModel> DetailDdkGoodsAsync(DetailDdkGoodsRequestModel detailDdkGoods)
        {
            var result = await PostAsync<DetailDdkGoodsRequestModel, DetailDdkGoodsResponseModel>("pdd.ddk.goods.detail", detailDdkGoods);
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
        /// 查询已经生成的推广位信息
        /// </summary>
        public async Task<QueryDdkGoodsPidResponseModel> QueryDdkGoodsPidAsync(QueryDdkGoodsPidRequestModel queryDdkGoodsPid)
        {
            var result = await PostAsync<QueryDdkGoodsPidRequestModel, QueryDdkGoodsPidResponseModel>("pdd.ddk.goods.pid.query", queryDdkGoodsPid);
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
        /// 多多进宝商品推荐API
        /// </summary>
        public async Task<GetDdkGoodsRecommendResponseModel> GetDdkGoodsRecommendAsync(GetDdkGoodsRecommendRequestModel getDdkGoodsRecommend)
        {
            var result = await PostAsync<GetDdkGoodsRecommendRequestModel, GetDdkGoodsRecommendResponseModel>("pdd.ddk.goods.recommend.get", getDdkGoodsRecommend);
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
        /// 多多进宝转链接口
        /// </summary>
        public async Task<GenDdkGoodsZsUnitUrlResponseModel> GenDdkGoodsZsUnitUrlAsync(GenDdkGoodsZsUnitUrlRequestModel genDdkGoodsZsUnitUrl)
        {
            var result = await PostAsync<GenDdkGoodsZsUnitUrlRequestModel, GenDdkGoodsZsUnitUrlResponseModel>("pdd.ddk.goods.zs.unit.url.gen", genDdkGoodsZsUnitUrl);
            return result;
        }
        /// <summary>
        /// 查询是否绑定备案
        /// </summary>
        public async Task<QueryDdkMemberAuthorityResponseModel> QueryDdkMemberAuthorityAsync(QueryDdkMemberAuthorityRequestModel queryDdkMemberAuthority)
        {
            var result = await PostAsync<QueryDdkMemberAuthorityRequestModel, QueryDdkMemberAuthorityResponseModel>("pdd.ddk.member.authority.query", queryDdkMemberAuthority);
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
        /// 最后更新时间段增量同步推广订单信息
        /// </summary>
        public async Task<GetDdkOrderListIncrementResponseModel> GetDdkOrderListIncrementAsync(GetDdkOrderListIncrementRequestModel getDdkOrderListIncrement)
        {
            var result = await PostAsync<GetDdkOrderListIncrementRequestModel, GetDdkOrderListIncrementResponseModel>("pdd.ddk.order.list.increment.get", getDdkOrderListIncrement);
            return result;
        }
        /// <summary>
        /// 用时间段查询推广订单接口
        /// </summary>
        public async Task<GetDdkOrderListRangeResponseModel> GetDdkOrderListRangeAsync(GetDdkOrderListRangeRequestModel getDdkOrderListRange)
        {
            var result = await PostAsync<GetDdkOrderListRangeRequestModel, GetDdkOrderListRangeResponseModel>("pdd.ddk.order.list.range.get", getDdkOrderListRange);
            return result;
        }
        /// <summary>
        /// 批量绑定推广位的媒体id
        /// </summary>
        public async Task<BindDdkPidMediaidResponseModel> BindDdkPidMediaidAsync(BindDdkPidMediaidRequestModel bindDdkPidMediaid)
        {
            var result = await PostAsync<BindDdkPidMediaidRequestModel, BindDdkPidMediaidResponseModel>("pdd.ddk.pid.mediaid.bind", bindDdkPidMediaid);
            return result;
        }
        /// <summary>
        /// 生成多多进宝频道推广
        /// </summary>
        public async Task<GenDdkResourceUrlResponseModel> GenDdkResourceUrlAsync(GenDdkResourceUrlRequestModel genDdkResourceUrl)
        {
            var result = await PostAsync<GenDdkResourceUrlRequestModel, GenDdkResourceUrlResponseModel>("pdd.ddk.resource.url.gen", genDdkResourceUrl);
            return result;
        }
        /// <summary>
        /// 生成营销工具推广链接
        /// </summary>
        public async Task<GenerateDdkRpPromUrlResponseModel> GenerateDdkRpPromUrlAsync(GenerateDdkRpPromUrlRequestModel generateDdkRpPromUrl)
        {
            var result = await PostAsync<GenerateDdkRpPromUrlRequestModel, GenerateDdkRpPromUrlResponseModel>("pdd.ddk.rp.prom.url.generate", generateDdkRpPromUrl);
            return result;
        }
        /// <summary>
        /// 多多客获取爆款排行商品接口
        /// </summary>
        public async Task<QueryDdkTopGoodsListResponseModel> QueryDdkTopGoodsListAsync(QueryDdkTopGoodsListRequestModel queryDdkTopGoodsList)
        {
            var result = await PostAsync<QueryDdkTopGoodsListRequestModel, QueryDdkTopGoodsListResponseModel>("pdd.ddk.top.goods.list.query", queryDdkTopGoodsList);
            return result;
        }

    }
}
