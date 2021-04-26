
using PddOpenSdk.Models.Request.Ad;
using PddOpenSdk.Models.Response.Ad;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApi
{
    public class AdApi : PddCommonApi
    {
        public AdApi() { }
        public AdApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }
        /// <summary>
        /// 广告主开户
        /// </summary>
        public async Task<AccountAdApiAdvertiserOpenResponseModel> AccountAdApiAdvertiserOpenAsync(AccountAdApiAdvertiserOpenRequestModel accountAdApiAdvertiserOpen)
        {
            var result = await PostAsync<AccountAdApiAdvertiserOpenRequestModel, AccountAdApiAdvertiserOpenResponseModel>("pdd.ad.api.advertiser.open.account", accountAdApiAdvertiserOpen);
            return result;
        }
        /// <summary>
        /// 查询广告主账户余额
        /// </summary>
        public async Task<BalanceAdApiAdvertiserQueryAccountResponseModel> BalanceAdApiAdvertiserQueryAccountAsync(BalanceAdApiAdvertiserQueryAccountRequestModel balanceAdApiAdvertiserQueryAccount)
        {
            var result = await PostAsync<BalanceAdApiAdvertiserQueryAccountRequestModel, BalanceAdApiAdvertiserQueryAccountResponseModel>("pdd.ad.api.advertiser.query.account.balance", balanceAdApiAdvertiserQueryAccount);
            return result;
        }
        /// <summary>
        /// 查询广告开户信息
        /// </summary>
        public async Task<InfoAdApiAdvertiserQueryAccountResponseModel> InfoAdApiAdvertiserQueryAccountAsync(InfoAdApiAdvertiserQueryAccountRequestModel infoAdApiAdvertiserQueryAccount)
        {
            var result = await PostAsync<InfoAdApiAdvertiserQueryAccountRequestModel, InfoAdApiAdvertiserQueryAccountResponseModel>("pdd.ad.api.advertiser.query.account.info", infoAdApiAdvertiserQueryAccount);
            return result;
        }
        /// <summary>
        /// 查询广告主详情信息
        /// </summary>
        public async Task<DetailAdApiAdvertiserQueryResponseModel> DetailAdApiAdvertiserQueryAsync(DetailAdApiAdvertiserQueryRequestModel detailAdApiAdvertiserQuery)
        {
            var result = await PostAsync<DetailAdApiAdvertiserQueryRequestModel, DetailAdApiAdvertiserQueryResponseModel>("pdd.ad.api.advertiser.query.detail", detailAdApiAdvertiserQuery);
            return result;
        }
        /// <summary>
        /// 查询商品轮播图
        /// </summary>
        public async Task<ImagesAdApiGoodsQueryGalleryResponseModel> ImagesAdApiGoodsQueryGalleryAsync(ImagesAdApiGoodsQueryGalleryRequestModel imagesAdApiGoodsQueryGallery)
        {
            var result = await PostAsync<ImagesAdApiGoodsQueryGalleryRequestModel, ImagesAdApiGoodsQueryGalleryResponseModel>("pdd.ad.api.goods.query.gallery.images", imagesAdApiGoodsQueryGallery);
            return result;
        }
        /// <summary>
        /// 查询商品长图
        /// </summary>
        public async Task<ImagesAdApiGoodsQueryLongResponseModel> ImagesAdApiGoodsQueryLongAsync(ImagesAdApiGoodsQueryLongRequestModel imagesAdApiGoodsQueryLong)
        {
            var result = await PostAsync<ImagesAdApiGoodsQueryLongRequestModel, ImagesAdApiGoodsQueryLongResponseModel>("pdd.ad.api.goods.query.long.images", imagesAdApiGoodsQueryLong);
            return result;
        }
        /// <summary>
        /// 查询可用商品列表（分页）
        /// </summary>
        public async Task<PageAdApiGoodsQueryResponseModel> PageAdApiGoodsQueryAsync(PageAdApiGoodsQueryRequestModel pageAdApiGoodsQuery)
        {
            var result = await PostAsync<PageAdApiGoodsQueryRequestModel, PageAdApiGoodsQueryResponseModel>("pdd.ad.api.goods.query.page", pageAdApiGoodsQuery);
            return result;
        }
        /// <summary>
        /// 批量创建关键词
        /// </summary>
        public async Task<CreateAdApiKeywordResponseModel> CreateAdApiKeywordAsync(CreateAdApiKeywordRequestModel createAdApiKeyword)
        {
            var result = await PostAsync<CreateAdApiKeywordRequestModel, CreateAdApiKeywordResponseModel>("pdd.ad.api.keyword.create", createAdApiKeyword);
            return result;
        }
        /// <summary>
        /// 批量删除关键词
        /// </summary>
        public async Task<DeleteAdApiKeywordResponseModel> DeleteAdApiKeywordAsync(DeleteAdApiKeywordRequestModel deleteAdApiKeyword)
        {
            var result = await PostAsync<DeleteAdApiKeywordRequestModel, DeleteAdApiKeywordResponseModel>("pdd.ad.api.keyword.delete", deleteAdApiKeyword);
            return result;
        }
        /// <summary>
        /// 查询关键词列表
        /// </summary>
        public async Task<ListAdApiKeywordQueryResponseModel> ListAdApiKeywordQueryAsync(ListAdApiKeywordQueryRequestModel listAdApiKeywordQuery)
        {
            var result = await PostAsync<ListAdApiKeywordQueryRequestModel, ListAdApiKeywordQueryResponseModel>("pdd.ad.api.keyword.query.list", listAdApiKeywordQuery);
            return result;
        }
        /// <summary>
        /// 获取推荐关键词
        /// </summary>
        public async Task<GetAdApiKeywordRecommendResponseModel> GetAdApiKeywordRecommendAsync(GetAdApiKeywordRecommendRequestModel getAdApiKeywordRecommend)
        {
            var result = await PostAsync<GetAdApiKeywordRecommendRequestModel, GetAdApiKeywordRecommendResponseModel>("pdd.ad.api.keyword.recommend.get", getAdApiKeywordRecommend);
            return result;
        }
        /// <summary>
        /// 关键词相关性查询
        /// </summary>
        public async Task<GetAdApiKeywordRelevanceResponseModel> GetAdApiKeywordRelevanceAsync(GetAdApiKeywordRelevanceRequestModel getAdApiKeywordRelevance)
        {
            var result = await PostAsync<GetAdApiKeywordRelevanceRequestModel, GetAdApiKeywordRelevanceResponseModel>("pdd.ad.api.keyword.relevance.get", getAdApiKeywordRelevance);
            return result;
        }
        /// <summary>
        /// 批量修改关键词
        /// </summary>
        public async Task<UpdateAdApiKeywordResponseModel> UpdateAdApiKeywordAsync(UpdateAdApiKeywordRequestModel updateAdApiKeyword)
        {
            var result = await PostAsync<UpdateAdApiKeywordRequestModel, UpdateAdApiKeywordResponseModel>("pdd.ad.api.keyword.update", updateAdApiKeyword);
            return result;
        }
        /// <summary>
        /// 创建计划
        /// </summary>
        public async Task<CreateAdApiPlanResponseModel> CreateAdApiPlanAsync(CreateAdApiPlanRequestModel createAdApiPlan)
        {
            var result = await PostAsync<CreateAdApiPlanRequestModel, CreateAdApiPlanResponseModel>("pdd.ad.api.plan.create", createAdApiPlan);
            return result;
        }
        /// <summary>
        /// 删除计划
        /// </summary>
        public async Task<DeleteAdApiPlanResponseModel> DeleteAdApiPlanAsync(DeleteAdApiPlanRequestModel deleteAdApiPlan)
        {
            var result = await PostAsync<DeleteAdApiPlanRequestModel, DeleteAdApiPlanResponseModel>("pdd.ad.api.plan.delete", deleteAdApiPlan);
            return result;
        }
        /// <summary>
        /// 校验是否能创建计划
        /// </summary>
        public async Task<PlanAdApiPlanQueryCanCreateAdResponseModel> PlanAdApiPlanQueryCanCreateAdAsync(PlanAdApiPlanQueryCanCreateAdRequestModel planAdApiPlanQueryCanCreateAd)
        {
            var result = await PostAsync<PlanAdApiPlanQueryCanCreateAdRequestModel, PlanAdApiPlanQueryCanCreateAdResponseModel>("pdd.ad.api.plan.query.can.create.ad.plan", planAdApiPlanQueryCanCreateAd);
            return result;
        }
        /// <summary>
        /// 当天是否允许计划的推广预算
        /// </summary>
        public async Task<CostAdApiPlanQueryCanUpdateMaxResponseModel> CostAdApiPlanQueryCanUpdateMaxAsync(CostAdApiPlanQueryCanUpdateMaxRequestModel costAdApiPlanQueryCanUpdateMax)
        {
            var result = await PostAsync<CostAdApiPlanQueryCanUpdateMaxRequestModel, CostAdApiPlanQueryCanUpdateMaxResponseModel>("pdd.ad.api.plan.query.can.update.max.cost", costAdApiPlanQueryCanUpdateMax);
            return result;
        }
        /// <summary>
        /// 查询计划列表页
        /// </summary>
        public async Task<ListAdApiPlanQueryResponseModel> ListAdApiPlanQueryAsync(ListAdApiPlanQueryRequestModel listAdApiPlanQuery)
        {
            var result = await PostAsync<ListAdApiPlanQueryRequestModel, ListAdApiPlanQueryResponseModel>("pdd.ad.api.plan.query.list", listAdApiPlanQuery);
            return result;
        }
        /// <summary>
        /// 启动或暂停计划
        /// </summary>
        public async Task<StatusAdApiPlanUpdateDataOperateResponseModel> StatusAdApiPlanUpdateDataOperateAsync(StatusAdApiPlanUpdateDataOperateRequestModel statusAdApiPlanUpdateDataOperate)
        {
            var result = await PostAsync<StatusAdApiPlanUpdateDataOperateRequestModel, StatusAdApiPlanUpdateDataOperateResponseModel>("pdd.ad.api.plan.update.data.operate.status", statusAdApiPlanUpdateDataOperate);
            return result;
        }
        /// <summary>
        /// 更新日消耗上限
        /// </summary>
        public async Task<CostAdApiPlanUpdateMaxResponseModel> CostAdApiPlanUpdateMaxAsync(CostAdApiPlanUpdateMaxRequestModel costAdApiPlanUpdateMax)
        {
            var result = await PostAsync<CostAdApiPlanUpdateMaxRequestModel, CostAdApiPlanUpdateMaxResponseModel>("pdd.ad.api.plan.update.max.cost", costAdApiPlanUpdateMax);
            return result;
        }
        /// <summary>
        /// 更新分时折扣
        /// </summary>
        public async Task<DiscountAdApiPlanUpdatePlanResponseModel> DiscountAdApiPlanUpdatePlanAsync(DiscountAdApiPlanUpdatePlanRequestModel discountAdApiPlanUpdatePlan)
        {
            var result = await PostAsync<DiscountAdApiPlanUpdatePlanRequestModel, DiscountAdApiPlanUpdatePlanResponseModel>("pdd.ad.api.plan.update.plan.discount", discountAdApiPlanUpdatePlan);
            return result;
        }
        /// <summary>
        /// 更新计划名称
        /// </summary>
        public async Task<NameAdApiPlanUpdatePlanResponseModel> NameAdApiPlanUpdatePlanAsync(NameAdApiPlanUpdatePlanRequestModel nameAdApiPlanUpdatePlan)
        {
            var result = await PostAsync<NameAdApiPlanUpdatePlanRequestModel, NameAdApiPlanUpdatePlanResponseModel>("pdd.ad.api.plan.update.plan.name", nameAdApiPlanUpdatePlan);
            return result;
        }
        /// <summary>
        /// 切换计划至ocpc
        /// </summary>
        public async Task<OcpcAdApiPlanUpdatePlanToResponseModel> OcpcAdApiPlanUpdatePlanToAsync(OcpcAdApiPlanUpdatePlanToRequestModel ocpcAdApiPlanUpdatePlanTo)
        {
            var result = await PostAsync<OcpcAdApiPlanUpdatePlanToRequestModel, OcpcAdApiPlanUpdatePlanToResponseModel>("pdd.ad.api.plan.update.plan.to.ocpc", ocpcAdApiPlanUpdatePlanTo);
            return result;
        }
        /// <summary>
        /// 广告主分天报表查询
        /// </summary>
        public async Task<QueryAdApiReportDailyReportResponseModel> QueryAdApiReportDailyReportAsync(QueryAdApiReportDailyReportRequestModel queryAdApiReportDailyReport)
        {
            var result = await PostAsync<QueryAdApiReportDailyReportRequestModel, QueryAdApiReportDailyReportResponseModel>("pdd.ad.api.report.daily.report.query", queryAdApiReportDailyReport);
            return result;
        }
        /// <summary>
        /// 广告主报表分级查询接口
        /// </summary>
        public async Task<QueryAdApiReportEntityReportResponseModel> QueryAdApiReportEntityReportAsync(QueryAdApiReportEntityReportRequestModel queryAdApiReportEntityReport)
        {
            var result = await PostAsync<QueryAdApiReportEntityReportRequestModel, QueryAdApiReportEntityReportResponseModel>("pdd.ad.api.report.entity.report.query", queryAdApiReportEntityReport);
            return result;
        }
        /// <summary>
        /// 报表小时数据查询接口
        /// </summary>
        public async Task<QueryAdApiReportHourlyReportResponseModel> QueryAdApiReportHourlyReportAsync(QueryAdApiReportHourlyReportRequestModel queryAdApiReportHourlyReport)
        {
            var result = await PostAsync<QueryAdApiReportHourlyReportRequestModel, QueryAdApiReportHourlyReportResponseModel>("pdd.ad.api.report.hourly.report.query", queryAdApiReportHourlyReport);
            return result;
        }
        /// <summary>
        /// 删除定向/资源位
        /// </summary>
        public async Task<DeleteAdApiUnitBidResponseModel> DeleteAdApiUnitBidAsync(DeleteAdApiUnitBidRequestModel deleteAdApiUnitBid)
        {
            var result = await PostAsync<DeleteAdApiUnitBidRequestModel, DeleteAdApiUnitBidResponseModel>("pdd.ad.api.unit.bid.delete", deleteAdApiUnitBid);
            return result;
        }
        /// <summary>
        /// 获取可用资源位
        /// </summary>
        public async Task<ProfileAdApiUnitBidQueryBaseLocationResponseModel> ProfileAdApiUnitBidQueryBaseLocationAsync(ProfileAdApiUnitBidQueryBaseLocationRequestModel profileAdApiUnitBidQueryBaseLocation)
        {
            var result = await PostAsync<ProfileAdApiUnitBidQueryBaseLocationRequestModel, ProfileAdApiUnitBidQueryBaseLocationResponseModel>("pdd.ad.api.unit.bid.query.base.location.profile", profileAdApiUnitBidQueryBaseLocation);
            return result;
        }
        /// <summary>
        /// 获取可用基础定向
        /// </summary>
        public async Task<ProfileAdApiUnitBidQueryBaseTargetResponseModel> ProfileAdApiUnitBidQueryBaseTargetAsync(ProfileAdApiUnitBidQueryBaseTargetRequestModel profileAdApiUnitBidQueryBaseTarget)
        {
            var result = await PostAsync<ProfileAdApiUnitBidQueryBaseTargetRequestModel, ProfileAdApiUnitBidQueryBaseTargetResponseModel>("pdd.ad.api.unit.bid.query.base.target.profile", profileAdApiUnitBidQueryBaseTarget);
            return result;
        }
        /// <summary>
        /// 查询定向/资源位列表
        /// </summary>
        public async Task<ListAdApiUnitBidQueryResponseModel> ListAdApiUnitBidQueryAsync(ListAdApiUnitBidQueryRequestModel listAdApiUnitBidQuery)
        {
            var result = await PostAsync<ListAdApiUnitBidQueryRequestModel, ListAdApiUnitBidQueryResponseModel>("pdd.ad.api.unit.bid.query.list", listAdApiUnitBidQuery);
            return result;
        }
        /// <summary>
        /// 获取定向标签数据
        /// </summary>
        public async Task<ListAdApiUnitBidQueryTargetingTagResponseModel> ListAdApiUnitBidQueryTargetingTagAsync(ListAdApiUnitBidQueryTargetingTagRequestModel listAdApiUnitBidQueryTargetingTag)
        {
            var result = await PostAsync<ListAdApiUnitBidQueryTargetingTagRequestModel, ListAdApiUnitBidQueryTargetingTagResponseModel>("pdd.ad.api.unit.bid.query.targeting.tag.list", listAdApiUnitBidQueryTargetingTag);
            return result;
        }
        /// <summary>
        /// 同步定向/资源位
        /// </summary>
        public async Task<SyncAdApiUnitBidResponseModel> SyncAdApiUnitBidAsync(SyncAdApiUnitBidRequestModel syncAdApiUnitBid)
        {
            var result = await PostAsync<SyncAdApiUnitBidRequestModel, SyncAdApiUnitBidResponseModel>("pdd.ad.api.unit.bid.sync", syncAdApiUnitBid);
            return result;
        }
        /// <summary>
        /// 更新单个定向/资源位
        /// </summary>
        public async Task<UpdateAdApiUnitBidResponseModel> UpdateAdApiUnitBidAsync(UpdateAdApiUnitBidRequestModel updateAdApiUnitBid)
        {
            var result = await PostAsync<UpdateAdApiUnitBidRequestModel, UpdateAdApiUnitBidResponseModel>("pdd.ad.api.unit.bid.update", updateAdApiUnitBid);
            return result;
        }
        /// <summary>
        /// 创建单元
        /// </summary>
        public async Task<CreateAdApiUnitResponseModel> CreateAdApiUnitAsync(CreateAdApiUnitRequestModel createAdApiUnit)
        {
            var result = await PostAsync<CreateAdApiUnitRequestModel, CreateAdApiUnitResponseModel>("pdd.ad.api.unit.create", createAdApiUnit);
            return result;
        }
        /// <summary>
        /// 检查创意标题是否合法
        /// </summary>
        public async Task<TitleAdApiUnitCreativeCheckResponseModel> TitleAdApiUnitCreativeCheckAsync(TitleAdApiUnitCreativeCheckRequestModel titleAdApiUnitCreativeCheck)
        {
            var result = await PostAsync<TitleAdApiUnitCreativeCheckRequestModel, TitleAdApiUnitCreativeCheckResponseModel>("pdd.ad.api.unit.creative.check.title", titleAdApiUnitCreativeCheck);
            return result;
        }
        /// <summary>
        /// 创建创意
        /// </summary>
        public async Task<CreateAdApiUnitCreativeResponseModel> CreateAdApiUnitCreativeAsync(CreateAdApiUnitCreativeRequestModel createAdApiUnitCreative)
        {
            var result = await PostAsync<CreateAdApiUnitCreativeRequestModel, CreateAdApiUnitCreativeResponseModel>("pdd.ad.api.unit.creative.create", createAdApiUnitCreative);
            return result;
        }
        /// <summary>
        /// 删除创意
        /// </summary>
        public async Task<DeleteAdApiUnitCreativeResponseModel> DeleteAdApiUnitCreativeAsync(DeleteAdApiUnitCreativeRequestModel deleteAdApiUnitCreative)
        {
            var result = await PostAsync<DeleteAdApiUnitCreativeRequestModel, DeleteAdApiUnitCreativeResponseModel>("pdd.ad.api.unit.creative.delete", deleteAdApiUnitCreative);
            return result;
        }
        /// <summary>
        /// 智能创意流量比例分配
        /// </summary>
        public async Task<RateAdApiUnitCreativeDistributeFlowResponseModel> RateAdApiUnitCreativeDistributeFlowAsync(RateAdApiUnitCreativeDistributeFlowRequestModel rateAdApiUnitCreativeDistributeFlow)
        {
            var result = await PostAsync<RateAdApiUnitCreativeDistributeFlowRequestModel, RateAdApiUnitCreativeDistributeFlowResponseModel>("pdd.ad.api.unit.creative.distribute.flow.rate", rateAdApiUnitCreativeDistributeFlow);
            return result;
        }
        /// <summary>
        /// 查询智能创意流量分配比例,万分比
        /// </summary>
        public async Task<RateAdApiUnitCreativeQueryFlowResponseModel> RateAdApiUnitCreativeQueryFlowAsync(RateAdApiUnitCreativeQueryFlowRequestModel rateAdApiUnitCreativeQueryFlow)
        {
            var result = await PostAsync<RateAdApiUnitCreativeQueryFlowRequestModel, RateAdApiUnitCreativeQueryFlowResponseModel>("pdd.ad.api.unit.creative.query.flow.rate", rateAdApiUnitCreativeQueryFlow);
            return result;
        }
        /// <summary>
        /// 查询创意列表
        /// </summary>
        public async Task<ListAdApiUnitCreativeQueryResponseModel> ListAdApiUnitCreativeQueryAsync(ListAdApiUnitCreativeQueryRequestModel listAdApiUnitCreativeQuery)
        {
            var result = await PostAsync<ListAdApiUnitCreativeQueryRequestModel, ListAdApiUnitCreativeQueryResponseModel>("pdd.ad.api.unit.creative.query.list", listAdApiUnitCreativeQuery);
            return result;
        }
        /// <summary>
        /// 更新创意内容
        /// </summary>
        public async Task<ContentAdApiUnitCreativeUpdateResponseModel> ContentAdApiUnitCreativeUpdateAsync(ContentAdApiUnitCreativeUpdateRequestModel contentAdApiUnitCreativeUpdate)
        {
            var result = await PostAsync<ContentAdApiUnitCreativeUpdateRequestModel, ContentAdApiUnitCreativeUpdateResponseModel>("pdd.ad.api.unit.creative.update.content", contentAdApiUnitCreativeUpdate);
            return result;
        }
        /// <summary>
        /// 批量启动或暂停创意
        /// </summary>
        public async Task<StatusAdApiUnitCreativeUpdateDataOperateResponseModel> StatusAdApiUnitCreativeUpdateDataOperateAsync(StatusAdApiUnitCreativeUpdateDataOperateRequestModel statusAdApiUnitCreativeUpdateDataOperate)
        {
            var result = await PostAsync<StatusAdApiUnitCreativeUpdateDataOperateRequestModel, StatusAdApiUnitCreativeUpdateDataOperateResponseModel>("pdd.ad.api.unit.creative.update.data.operate.status", statusAdApiUnitCreativeUpdateDataOperate);
            return result;
        }
        /// <summary>
        /// 更新智能创意
        /// </summary>
        public async Task<CreativeAdApiUnitCreativeUpdateSmartResponseModel> CreativeAdApiUnitCreativeUpdateSmartAsync(CreativeAdApiUnitCreativeUpdateSmartRequestModel creativeAdApiUnitCreativeUpdateSmart)
        {
            var result = await PostAsync<CreativeAdApiUnitCreativeUpdateSmartRequestModel, CreativeAdApiUnitCreativeUpdateSmartResponseModel>("pdd.ad.api.unit.creative.update.smart.creative", creativeAdApiUnitCreativeUpdateSmart);
            return result;
        }
        /// <summary>
        /// 删除单元
        /// </summary>
        public async Task<DeleteAdApiUnitResponseModel> DeleteAdApiUnitAsync(DeleteAdApiUnitRequestModel deleteAdApiUnit)
        {
            var result = await PostAsync<DeleteAdApiUnitRequestModel, DeleteAdApiUnitResponseModel>("pdd.ad.api.unit.delete", deleteAdApiUnit);
            return result;
        }
        /// <summary>
        /// 查询单元列表页
        /// </summary>
        public async Task<ListAdApiUnitQueryResponseModel> ListAdApiUnitQueryAsync(ListAdApiUnitQueryRequestModel listAdApiUnitQuery)
        {
            var result = await PostAsync<ListAdApiUnitQueryRequestModel, ListAdApiUnitQueryResponseModel>("pdd.ad.api.unit.query.list", listAdApiUnitQuery);
            return result;
        }
        /// <summary>
        /// 批量启动或暂停单元
        /// </summary>
        public async Task<StatusAdApiUnitUpdateDataOperateResponseModel> StatusAdApiUnitUpdateDataOperateAsync(StatusAdApiUnitUpdateDataOperateRequestModel statusAdApiUnitUpdateDataOperate)
        {
            var result = await PostAsync<StatusAdApiUnitUpdateDataOperateRequestModel, StatusAdApiUnitUpdateDataOperateResponseModel>("pdd.ad.api.unit.update.data.operate.status", statusAdApiUnitUpdateDataOperate);
            return result;
        }
        /// <summary>
        /// 更新优化信息
        /// </summary>
        public async Task<MessageAdApiUnitUpdateOptimizationResponseModel> MessageAdApiUnitUpdateOptimizationAsync(MessageAdApiUnitUpdateOptimizationRequestModel messageAdApiUnitUpdateOptimization)
        {
            var result = await PostAsync<MessageAdApiUnitUpdateOptimizationRequestModel, MessageAdApiUnitUpdateOptimizationResponseModel>("pdd.ad.api.unit.update.optimization.message", messageAdApiUnitUpdateOptimization);
            return result;
        }
        /// <summary>
        /// 更新单元出价
        /// </summary>
        public async Task<BidAdApiUnitUpdateUnitResponseModel> BidAdApiUnitUpdateUnitAsync(BidAdApiUnitUpdateUnitRequestModel bidAdApiUnitUpdateUnit)
        {
            var result = await PostAsync<BidAdApiUnitUpdateUnitRequestModel, BidAdApiUnitUpdateUnitResponseModel>("pdd.ad.api.unit.update.unit.bid", bidAdApiUnitUpdateUnit);
            return result;
        }
        /// <summary>
        /// 更新单元名称
        /// </summary>
        public async Task<NameAdApiUnitUpdateUnitResponseModel> NameAdApiUnitUpdateUnitAsync(NameAdApiUnitUpdateUnitRequestModel nameAdApiUnitUpdateUnit)
        {
            var result = await PostAsync<NameAdApiUnitUpdateUnitRequestModel, NameAdApiUnitUpdateUnitResponseModel>("pdd.ad.api.unit.update.unit.name", nameAdApiUnitUpdateUnit);
            return result;
        }

    }
}
