
using PddOpenSdk.Models.Request.Ad;
using PddOpenSdk.Models.Response.Ad;
namespace PddOpenSdk.Services.PddApi;
public class AdApi : PddCommonApi
{
    public AdApi() { }
    public AdApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }

    /// <summary>
    /// 广告主开户
    /// </summary>
    public async Task<AccountAdApiAdvertiserOpenResponse> AccountAdApiAdvertiserOpenAsync(AccountAdApiAdvertiserOpen accountAdApiAdvertiserOpen)
    {
        var result = await PostAsync<AccountAdApiAdvertiserOpen, AccountAdApiAdvertiserOpenResponse>("pdd.ad.api.advertiser.open.account", accountAdApiAdvertiserOpen);
        return result;
    }

    /// <summary>
    /// 查询广告主账户余额
    /// </summary>
    public async Task<BalanceAdApiAdvertiserQueryAccountResponse> BalanceAdApiAdvertiserQueryAccountAsync(BalanceAdApiAdvertiserQueryAccount balanceAdApiAdvertiserQueryAccount)
    {
        var result = await PostAsync<BalanceAdApiAdvertiserQueryAccount, BalanceAdApiAdvertiserQueryAccountResponse>("pdd.ad.api.advertiser.query.account.balance", balanceAdApiAdvertiserQueryAccount);
        return result;
    }

    /// <summary>
    /// 查询广告开户信息
    /// </summary>
    public async Task<InfoAdApiAdvertiserQueryAccountResponse> InfoAdApiAdvertiserQueryAccountAsync(InfoAdApiAdvertiserQueryAccount infoAdApiAdvertiserQueryAccount)
    {
        var result = await PostAsync<InfoAdApiAdvertiserQueryAccount, InfoAdApiAdvertiserQueryAccountResponse>("pdd.ad.api.advertiser.query.account.info", infoAdApiAdvertiserQueryAccount);
        return result;
    }

    /// <summary>
    /// 查询广告主详情信息
    /// </summary>
    public async Task<DetailAdApiAdvertiserQueryResponse> DetailAdApiAdvertiserQueryAsync(DetailAdApiAdvertiserQuery detailAdApiAdvertiserQuery)
    {
        var result = await PostAsync<DetailAdApiAdvertiserQuery, DetailAdApiAdvertiserQueryResponse>("pdd.ad.api.advertiser.query.detail", detailAdApiAdvertiserQuery);
        return result;
    }

    /// <summary>
    /// 查询商品轮播图
    /// </summary>
    public async Task<ImagesAdApiGoodsQueryGalleryResponse> ImagesAdApiGoodsQueryGalleryAsync(ImagesAdApiGoodsQueryGallery imagesAdApiGoodsQueryGallery)
    {
        var result = await PostAsync<ImagesAdApiGoodsQueryGallery, ImagesAdApiGoodsQueryGalleryResponse>("pdd.ad.api.goods.query.gallery.images", imagesAdApiGoodsQueryGallery);
        return result;
    }

    /// <summary>
    /// 查询商品长图
    /// </summary>
    public async Task<ImagesAdApiGoodsQueryLongResponse> ImagesAdApiGoodsQueryLongAsync(ImagesAdApiGoodsQueryLong imagesAdApiGoodsQueryLong)
    {
        var result = await PostAsync<ImagesAdApiGoodsQueryLong, ImagesAdApiGoodsQueryLongResponse>("pdd.ad.api.goods.query.long.images", imagesAdApiGoodsQueryLong);
        return result;
    }

    /// <summary>
    /// 查询可用商品列表（分页）
    /// </summary>
    public async Task<PageAdApiGoodsQueryResponse> PageAdApiGoodsQueryAsync(PageAdApiGoodsQuery pageAdApiGoodsQuery)
    {
        var result = await PostAsync<PageAdApiGoodsQuery, PageAdApiGoodsQueryResponse>("pdd.ad.api.goods.query.page", pageAdApiGoodsQuery);
        return result;
    }

    /// <summary>
    /// 批量创建关键词
    /// </summary>
    public async Task<CreateAdApiKeywordResponse> CreateAdApiKeywordAsync(CreateAdApiKeyword createAdApiKeyword)
    {
        var result = await PostAsync<CreateAdApiKeyword, CreateAdApiKeywordResponse>("pdd.ad.api.keyword.create", createAdApiKeyword);
        return result;
    }

    /// <summary>
    /// 批量删除关键词
    /// </summary>
    public async Task<DeleteAdApiKeywordResponse> DeleteAdApiKeywordAsync(DeleteAdApiKeyword deleteAdApiKeyword)
    {
        var result = await PostAsync<DeleteAdApiKeyword, DeleteAdApiKeywordResponse>("pdd.ad.api.keyword.delete", deleteAdApiKeyword);
        return result;
    }

    /// <summary>
    /// 查询关键词列表
    /// </summary>
    public async Task<ListAdApiKeywordQueryResponse> ListAdApiKeywordQueryAsync(ListAdApiKeywordQuery listAdApiKeywordQuery)
    {
        var result = await PostAsync<ListAdApiKeywordQuery, ListAdApiKeywordQueryResponse>("pdd.ad.api.keyword.query.list", listAdApiKeywordQuery);
        return result;
    }

    /// <summary>
    /// 获取推荐关键词
    /// </summary>
    public async Task<GetAdApiKeywordRecommendResponse> GetAdApiKeywordRecommendAsync(GetAdApiKeywordRecommend getAdApiKeywordRecommend)
    {
        var result = await PostAsync<GetAdApiKeywordRecommend, GetAdApiKeywordRecommendResponse>("pdd.ad.api.keyword.recommend.get", getAdApiKeywordRecommend);
        return result;
    }

    /// <summary>
    /// 关键词相关性查询
    /// </summary>
    public async Task<GetAdApiKeywordRelevanceResponse> GetAdApiKeywordRelevanceAsync(GetAdApiKeywordRelevance getAdApiKeywordRelevance)
    {
        var result = await PostAsync<GetAdApiKeywordRelevance, GetAdApiKeywordRelevanceResponse>("pdd.ad.api.keyword.relevance.get", getAdApiKeywordRelevance);
        return result;
    }

    /// <summary>
    /// 批量修改关键词
    /// </summary>
    public async Task<UpdateAdApiKeywordResponse> UpdateAdApiKeywordAsync(UpdateAdApiKeyword updateAdApiKeyword)
    {
        var result = await PostAsync<UpdateAdApiKeyword, UpdateAdApiKeywordResponse>("pdd.ad.api.keyword.update", updateAdApiKeyword);
        return result;
    }

    /// <summary>
    /// 创建计划
    /// </summary>
    public async Task<CreateAdApiPlanResponse> CreateAdApiPlanAsync(CreateAdApiPlan createAdApiPlan)
    {
        var result = await PostAsync<CreateAdApiPlan, CreateAdApiPlanResponse>("pdd.ad.api.plan.create", createAdApiPlan);
        return result;
    }

    /// <summary>
    /// 删除计划
    /// </summary>
    public async Task<DeleteAdApiPlanResponse> DeleteAdApiPlanAsync(DeleteAdApiPlan deleteAdApiPlan)
    {
        var result = await PostAsync<DeleteAdApiPlan, DeleteAdApiPlanResponse>("pdd.ad.api.plan.delete", deleteAdApiPlan);
        return result;
    }

    /// <summary>
    /// 校验是否能创建计划
    /// </summary>
    public async Task<PlanAdApiPlanQueryCanCreateAdResponse> PlanAdApiPlanQueryCanCreateAdAsync(PlanAdApiPlanQueryCanCreateAd planAdApiPlanQueryCanCreateAd)
    {
        var result = await PostAsync<PlanAdApiPlanQueryCanCreateAd, PlanAdApiPlanQueryCanCreateAdResponse>("pdd.ad.api.plan.query.can.create.ad.plan", planAdApiPlanQueryCanCreateAd);
        return result;
    }

    /// <summary>
    /// 当天是否允许计划的推广预算
    /// </summary>
    public async Task<CostAdApiPlanQueryCanUpdateMaxResponse> CostAdApiPlanQueryCanUpdateMaxAsync(CostAdApiPlanQueryCanUpdateMax costAdApiPlanQueryCanUpdateMax)
    {
        var result = await PostAsync<CostAdApiPlanQueryCanUpdateMax, CostAdApiPlanQueryCanUpdateMaxResponse>("pdd.ad.api.plan.query.can.update.max.cost", costAdApiPlanQueryCanUpdateMax);
        return result;
    }

    /// <summary>
    /// 查询计划列表页
    /// </summary>
    public async Task<ListAdApiPlanQueryResponse> ListAdApiPlanQueryAsync(ListAdApiPlanQuery listAdApiPlanQuery)
    {
        var result = await PostAsync<ListAdApiPlanQuery, ListAdApiPlanQueryResponse>("pdd.ad.api.plan.query.list", listAdApiPlanQuery);
        return result;
    }

    /// <summary>
    /// 启动或暂停计划
    /// </summary>
    public async Task<StatusAdApiPlanUpdateDataOperateResponse> StatusAdApiPlanUpdateDataOperateAsync(StatusAdApiPlanUpdateDataOperate statusAdApiPlanUpdateDataOperate)
    {
        var result = await PostAsync<StatusAdApiPlanUpdateDataOperate, StatusAdApiPlanUpdateDataOperateResponse>("pdd.ad.api.plan.update.data.operate.status", statusAdApiPlanUpdateDataOperate);
        return result;
    }

    /// <summary>
    /// 更新日消耗上限
    /// </summary>
    public async Task<CostAdApiPlanUpdateMaxResponse> CostAdApiPlanUpdateMaxAsync(CostAdApiPlanUpdateMax costAdApiPlanUpdateMax)
    {
        var result = await PostAsync<CostAdApiPlanUpdateMax, CostAdApiPlanUpdateMaxResponse>("pdd.ad.api.plan.update.max.cost", costAdApiPlanUpdateMax);
        return result;
    }

    /// <summary>
    /// 更新分时折扣
    /// </summary>
    public async Task<DiscountAdApiPlanUpdatePlanResponse> DiscountAdApiPlanUpdatePlanAsync(DiscountAdApiPlanUpdatePlan discountAdApiPlanUpdatePlan)
    {
        var result = await PostAsync<DiscountAdApiPlanUpdatePlan, DiscountAdApiPlanUpdatePlanResponse>("pdd.ad.api.plan.update.plan.discount", discountAdApiPlanUpdatePlan);
        return result;
    }

    /// <summary>
    /// 更新计划名称
    /// </summary>
    public async Task<NameAdApiPlanUpdatePlanResponse> NameAdApiPlanUpdatePlanAsync(NameAdApiPlanUpdatePlan nameAdApiPlanUpdatePlan)
    {
        var result = await PostAsync<NameAdApiPlanUpdatePlan, NameAdApiPlanUpdatePlanResponse>("pdd.ad.api.plan.update.plan.name", nameAdApiPlanUpdatePlan);
        return result;
    }

    /// <summary>
    /// 切换计划至ocpc
    /// </summary>
    public async Task<OcpcAdApiPlanUpdatePlanToResponse> OcpcAdApiPlanUpdatePlanToAsync(OcpcAdApiPlanUpdatePlanTo ocpcAdApiPlanUpdatePlanTo)
    {
        var result = await PostAsync<OcpcAdApiPlanUpdatePlanTo, OcpcAdApiPlanUpdatePlanToResponse>("pdd.ad.api.plan.update.plan.to.ocpc", ocpcAdApiPlanUpdatePlanTo);
        return result;
    }

    /// <summary>
    /// 广告主分天报表查询
    /// </summary>
    public async Task<QueryAdApiReportDailyReportResponse> QueryAdApiReportDailyReportAsync(QueryAdApiReportDailyReport queryAdApiReportDailyReport)
    {
        var result = await PostAsync<QueryAdApiReportDailyReport, QueryAdApiReportDailyReportResponse>("pdd.ad.api.report.daily.report.query", queryAdApiReportDailyReport);
        return result;
    }

    /// <summary>
    /// 广告主报表分级查询接口
    /// </summary>
    public async Task<QueryAdApiReportEntityReportResponse> QueryAdApiReportEntityReportAsync(QueryAdApiReportEntityReport queryAdApiReportEntityReport)
    {
        var result = await PostAsync<QueryAdApiReportEntityReport, QueryAdApiReportEntityReportResponse>("pdd.ad.api.report.entity.report.query", queryAdApiReportEntityReport);
        return result;
    }

    /// <summary>
    /// 报表小时数据查询接口
    /// </summary>
    public async Task<QueryAdApiReportHourlyReportResponse> QueryAdApiReportHourlyReportAsync(QueryAdApiReportHourlyReport queryAdApiReportHourlyReport)
    {
        var result = await PostAsync<QueryAdApiReportHourlyReport, QueryAdApiReportHourlyReportResponse>("pdd.ad.api.report.hourly.report.query", queryAdApiReportHourlyReport);
        return result;
    }

    /// <summary>
    /// 删除定向/资源位
    /// </summary>
    public async Task<DeleteAdApiUnitBidResponse> DeleteAdApiUnitBidAsync(DeleteAdApiUnitBid deleteAdApiUnitBid)
    {
        var result = await PostAsync<DeleteAdApiUnitBid, DeleteAdApiUnitBidResponse>("pdd.ad.api.unit.bid.delete", deleteAdApiUnitBid);
        return result;
    }

    /// <summary>
    /// 获取可用资源位
    /// </summary>
    public async Task<ProfileAdApiUnitBidQueryBaseLocationResponse> ProfileAdApiUnitBidQueryBaseLocationAsync(ProfileAdApiUnitBidQueryBaseLocation profileAdApiUnitBidQueryBaseLocation)
    {
        var result = await PostAsync<ProfileAdApiUnitBidQueryBaseLocation, ProfileAdApiUnitBidQueryBaseLocationResponse>("pdd.ad.api.unit.bid.query.base.location.profile", profileAdApiUnitBidQueryBaseLocation);
        return result;
    }

    /// <summary>
    /// 获取可用基础定向
    /// </summary>
    public async Task<ProfileAdApiUnitBidQueryBaseTargetResponse> ProfileAdApiUnitBidQueryBaseTargetAsync(ProfileAdApiUnitBidQueryBaseTarget profileAdApiUnitBidQueryBaseTarget)
    {
        var result = await PostAsync<ProfileAdApiUnitBidQueryBaseTarget, ProfileAdApiUnitBidQueryBaseTargetResponse>("pdd.ad.api.unit.bid.query.base.target.profile", profileAdApiUnitBidQueryBaseTarget);
        return result;
    }

    /// <summary>
    /// 查询定向/资源位列表
    /// </summary>
    public async Task<ListAdApiUnitBidQueryResponse> ListAdApiUnitBidQueryAsync(ListAdApiUnitBidQuery listAdApiUnitBidQuery)
    {
        var result = await PostAsync<ListAdApiUnitBidQuery, ListAdApiUnitBidQueryResponse>("pdd.ad.api.unit.bid.query.list", listAdApiUnitBidQuery);
        return result;
    }

    /// <summary>
    /// 获取定向标签数据
    /// </summary>
    public async Task<ListAdApiUnitBidQueryTargetingTagResponse> ListAdApiUnitBidQueryTargetingTagAsync(ListAdApiUnitBidQueryTargetingTag listAdApiUnitBidQueryTargetingTag)
    {
        var result = await PostAsync<ListAdApiUnitBidQueryTargetingTag, ListAdApiUnitBidQueryTargetingTagResponse>("pdd.ad.api.unit.bid.query.targeting.tag.list", listAdApiUnitBidQueryTargetingTag);
        return result;
    }

    /// <summary>
    /// 同步定向/资源位
    /// </summary>
    public async Task<SyncAdApiUnitBidResponse> SyncAdApiUnitBidAsync(SyncAdApiUnitBid syncAdApiUnitBid)
    {
        var result = await PostAsync<SyncAdApiUnitBid, SyncAdApiUnitBidResponse>("pdd.ad.api.unit.bid.sync", syncAdApiUnitBid);
        return result;
    }

    /// <summary>
    /// 更新单个定向/资源位
    /// </summary>
    public async Task<UpdateAdApiUnitBidResponse> UpdateAdApiUnitBidAsync(UpdateAdApiUnitBid updateAdApiUnitBid)
    {
        var result = await PostAsync<UpdateAdApiUnitBid, UpdateAdApiUnitBidResponse>("pdd.ad.api.unit.bid.update", updateAdApiUnitBid);
        return result;
    }

    /// <summary>
    /// 创建单元
    /// </summary>
    public async Task<CreateAdApiUnitResponse> CreateAdApiUnitAsync(CreateAdApiUnit createAdApiUnit)
    {
        var result = await PostAsync<CreateAdApiUnit, CreateAdApiUnitResponse>("pdd.ad.api.unit.create", createAdApiUnit);
        return result;
    }

    /// <summary>
    /// 检查创意标题是否合法
    /// </summary>
    public async Task<TitleAdApiUnitCreativeCheckResponse> TitleAdApiUnitCreativeCheckAsync(TitleAdApiUnitCreativeCheck titleAdApiUnitCreativeCheck)
    {
        var result = await PostAsync<TitleAdApiUnitCreativeCheck, TitleAdApiUnitCreativeCheckResponse>("pdd.ad.api.unit.creative.check.title", titleAdApiUnitCreativeCheck);
        return result;
    }

    /// <summary>
    /// 创建创意
    /// </summary>
    public async Task<CreateAdApiUnitCreativeResponse> CreateAdApiUnitCreativeAsync(CreateAdApiUnitCreative createAdApiUnitCreative)
    {
        var result = await PostAsync<CreateAdApiUnitCreative, CreateAdApiUnitCreativeResponse>("pdd.ad.api.unit.creative.create", createAdApiUnitCreative);
        return result;
    }

    /// <summary>
    /// 删除创意
    /// </summary>
    public async Task<DeleteAdApiUnitCreativeResponse> DeleteAdApiUnitCreativeAsync(DeleteAdApiUnitCreative deleteAdApiUnitCreative)
    {
        var result = await PostAsync<DeleteAdApiUnitCreative, DeleteAdApiUnitCreativeResponse>("pdd.ad.api.unit.creative.delete", deleteAdApiUnitCreative);
        return result;
    }

    /// <summary>
    /// 智能创意流量比例分配
    /// </summary>
    public async Task<RateAdApiUnitCreativeDistributeFlowResponse> RateAdApiUnitCreativeDistributeFlowAsync(RateAdApiUnitCreativeDistributeFlow rateAdApiUnitCreativeDistributeFlow)
    {
        var result = await PostAsync<RateAdApiUnitCreativeDistributeFlow, RateAdApiUnitCreativeDistributeFlowResponse>("pdd.ad.api.unit.creative.distribute.flow.rate", rateAdApiUnitCreativeDistributeFlow);
        return result;
    }

    /// <summary>
    /// 查询智能创意流量分配比例,万分比
    /// </summary>
    public async Task<RateAdApiUnitCreativeQueryFlowResponse> RateAdApiUnitCreativeQueryFlowAsync(RateAdApiUnitCreativeQueryFlow rateAdApiUnitCreativeQueryFlow)
    {
        var result = await PostAsync<RateAdApiUnitCreativeQueryFlow, RateAdApiUnitCreativeQueryFlowResponse>("pdd.ad.api.unit.creative.query.flow.rate", rateAdApiUnitCreativeQueryFlow);
        return result;
    }

    /// <summary>
    /// 查询创意列表
    /// </summary>
    public async Task<ListAdApiUnitCreativeQueryResponse> ListAdApiUnitCreativeQueryAsync(ListAdApiUnitCreativeQuery listAdApiUnitCreativeQuery)
    {
        var result = await PostAsync<ListAdApiUnitCreativeQuery, ListAdApiUnitCreativeQueryResponse>("pdd.ad.api.unit.creative.query.list", listAdApiUnitCreativeQuery);
        return result;
    }

    /// <summary>
    /// 更新创意内容
    /// </summary>
    public async Task<ContentAdApiUnitCreativeUpdateResponse> ContentAdApiUnitCreativeUpdateAsync(ContentAdApiUnitCreativeUpdate contentAdApiUnitCreativeUpdate)
    {
        var result = await PostAsync<ContentAdApiUnitCreativeUpdate, ContentAdApiUnitCreativeUpdateResponse>("pdd.ad.api.unit.creative.update.content", contentAdApiUnitCreativeUpdate);
        return result;
    }

    /// <summary>
    /// 批量启动或暂停创意
    /// </summary>
    public async Task<StatusAdApiUnitCreativeUpdateDataOperateResponse> StatusAdApiUnitCreativeUpdateDataOperateAsync(StatusAdApiUnitCreativeUpdateDataOperate statusAdApiUnitCreativeUpdateDataOperate)
    {
        var result = await PostAsync<StatusAdApiUnitCreativeUpdateDataOperate, StatusAdApiUnitCreativeUpdateDataOperateResponse>("pdd.ad.api.unit.creative.update.data.operate.status", statusAdApiUnitCreativeUpdateDataOperate);
        return result;
    }

    /// <summary>
    /// 更新智能创意
    /// </summary>
    public async Task<CreativeAdApiUnitCreativeUpdateSmartResponse> CreativeAdApiUnitCreativeUpdateSmartAsync(CreativeAdApiUnitCreativeUpdateSmart creativeAdApiUnitCreativeUpdateSmart)
    {
        var result = await PostAsync<CreativeAdApiUnitCreativeUpdateSmart, CreativeAdApiUnitCreativeUpdateSmartResponse>("pdd.ad.api.unit.creative.update.smart.creative", creativeAdApiUnitCreativeUpdateSmart);
        return result;
    }

    /// <summary>
    /// 删除单元
    /// </summary>
    public async Task<DeleteAdApiUnitResponse> DeleteAdApiUnitAsync(DeleteAdApiUnit deleteAdApiUnit)
    {
        var result = await PostAsync<DeleteAdApiUnit, DeleteAdApiUnitResponse>("pdd.ad.api.unit.delete", deleteAdApiUnit);
        return result;
    }

    /// <summary>
    /// 查询单元列表页
    /// </summary>
    public async Task<ListAdApiUnitQueryResponse> ListAdApiUnitQueryAsync(ListAdApiUnitQuery listAdApiUnitQuery)
    {
        var result = await PostAsync<ListAdApiUnitQuery, ListAdApiUnitQueryResponse>("pdd.ad.api.unit.query.list", listAdApiUnitQuery);
        return result;
    }

    /// <summary>
    /// 批量启动或暂停单元
    /// </summary>
    public async Task<StatusAdApiUnitUpdateDataOperateResponse> StatusAdApiUnitUpdateDataOperateAsync(StatusAdApiUnitUpdateDataOperate statusAdApiUnitUpdateDataOperate)
    {
        var result = await PostAsync<StatusAdApiUnitUpdateDataOperate, StatusAdApiUnitUpdateDataOperateResponse>("pdd.ad.api.unit.update.data.operate.status", statusAdApiUnitUpdateDataOperate);
        return result;
    }

    /// <summary>
    /// 更新优化信息
    /// </summary>
    public async Task<MessageAdApiUnitUpdateOptimizationResponse> MessageAdApiUnitUpdateOptimizationAsync(MessageAdApiUnitUpdateOptimization messageAdApiUnitUpdateOptimization)
    {
        var result = await PostAsync<MessageAdApiUnitUpdateOptimization, MessageAdApiUnitUpdateOptimizationResponse>("pdd.ad.api.unit.update.optimization.message", messageAdApiUnitUpdateOptimization);
        return result;
    }

    /// <summary>
    /// 更新单元出价
    /// </summary>
    public async Task<BidAdApiUnitUpdateUnitResponse> BidAdApiUnitUpdateUnitAsync(BidAdApiUnitUpdateUnit bidAdApiUnitUpdateUnit)
    {
        var result = await PostAsync<BidAdApiUnitUpdateUnit, BidAdApiUnitUpdateUnitResponse>("pdd.ad.api.unit.update.unit.bid", bidAdApiUnitUpdateUnit);
        return result;
    }

    /// <summary>
    /// 更新单元名称
    /// </summary>
    public async Task<NameAdApiUnitUpdateUnitResponse> NameAdApiUnitUpdateUnitAsync(NameAdApiUnitUpdateUnit nameAdApiUnitUpdateUnit)
    {
        var result = await PostAsync<NameAdApiUnitUpdateUnit, NameAdApiUnitUpdateUnitResponse>("pdd.ad.api.unit.update.unit.name", nameAdApiUnitUpdateUnit);
        return result;
    }

}
