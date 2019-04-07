using System.Threading.Tasks;
using PddOpenSdk.Models.Request.Ad;
using PddOpenSdk.Models.Response.Ad;
namespace PddOpenSdk.Services.PddApi
{
    public class AdApi : PddCommonApi {
        /// <summary>
        /// 获取关键词推广报表信息
        /// </summary>
        public async Task<GetAdChartBykeywordResponseModel> GetAdChartBykeywordAsync (GetAdChartBykeywordRequestModel getAdChartBykeyword) {
            var result = await PostAsync<GetAdChartBykeywordRequestModel, GetAdChartBykeywordResponseModel> ("pdd.ad.chart.bykeyword.get", getAdChartBykeyword);
            return result;
        }
        /// <summary>
        /// 系统推荐关键词
        /// </summary>
        public async Task<GetAdKeywordRcommendedResponseModel> GetAdKeywordRcommendedAsync (GetAdKeywordRcommendedRequestModel getAdKeywordRcommended) {
            var result = await PostAsync<GetAdKeywordRcommendedRequestModel, GetAdKeywordRcommendedResponseModel> ("pdd.ad.keyword.rcommended.get", getAdKeywordRcommended);
            return result;
        }
        /// <summary>
        /// 关键词商品相关性
        /// </summary>
        public async Task<GetAdKeywordRelevanceResponseModel> GetAdKeywordRelevanceAsync (GetAdKeywordRelevanceRequestModel getAdKeywordRelevance) {
            var result = await PostAsync<GetAdKeywordRelevanceRequestModel, GetAdKeywordRelevanceResponseModel> ("pdd.ad.keyword.relevance.get", getAdKeywordRelevance);
            return result;
        }
        /// <summary>
        /// 推广单元修改关键词出价
        /// </summary>
        public async Task<UpdateAdKeywordResponseModel> UpdateAdKeywordAsync (UpdateAdKeywordRequestModel updateAdKeyword) {
            var result = await PostAsync<UpdateAdKeywordRequestModel, UpdateAdKeywordResponseModel> ("pdd.ad.keyword.update", updateAdKeyword);
            return result;
        }
        /// <summary>
        /// 推广单元删除关键词
        /// </summary>
        public async Task<DeleteAdKeywordResponseModel> DeleteAdKeywordAsync (DeleteAdKeywordRequestModel deleteAdKeyword) {
            var result = await PostAsync<DeleteAdKeywordRequestModel, DeleteAdKeywordResponseModel> ("pdd.ad.keyword.delete", deleteAdKeyword);
            return result;
        }
        /// <summary>
        /// 推广单元添加关键词
        /// </summary>
        public async Task<CreateAdKeywordResponseModel> CreateAdKeywordAsync (CreateAdKeywordRequestModel createAdKeyword) {
            var result = await PostAsync<CreateAdKeywordRequestModel, CreateAdKeywordResponseModel> ("pdd.ad.keyword.create", createAdKeyword);
            return result;
        }
        /// <summary>
        /// 删除推广单元-批量
        /// </summary>
        public async Task<DeleteAdUnitResponseModel> DeleteAdUnitAsync (DeleteAdUnitRequestModel deleteAdUnit) {
            var result = await PostAsync<DeleteAdUnitRequestModel, DeleteAdUnitResponseModel> ("pdd.ad.unit.delete", deleteAdUnit);
            return result;
        }
        /// <summary>
        /// 添加推广单元
        /// </summary>
        public async Task<CreateAdUnitResponseModel> CreateAdUnitAsync (CreateAdUnitRequestModel createAdUnit) {
            var result = await PostAsync<CreateAdUnitRequestModel, CreateAdUnitResponseModel> ("pdd.ad.unit.create", createAdUnit);
            return result;
        }
        /// <summary>
        /// 暂停、开启推广单元
        /// </summary>
        public async Task<UpdateAdUnitOptStatusResponseModel> UpdateAdUnitOptStatusAsync (UpdateAdUnitOptStatusRequestModel updateAdUnitOptStatus) {
            var result = await PostAsync<UpdateAdUnitOptStatusRequestModel, UpdateAdUnitOptStatusResponseModel> ("pdd.ad.unit.opt.status.update", updateAdUnitOptStatus);
            return result;
        }
        /// <summary>
        /// 根据计划id获取推广单元基本信息
        /// </summary>
        public async Task<IdAdUnitGetByPlanResponseModel> IdAdUnitGetByPlanAsync (IdAdUnitGetByPlanRequestModel idAdUnitGetByPlan) {
            var result = await PostAsync<IdAdUnitGetByPlanRequestModel, IdAdUnitGetByPlanResponseModel> ("pdd.ad.unit.get.by.plan.id", idAdUnitGetByPlan);
            return result;
        }
        /// <summary>
        /// 修改推广计划状态（暂停、开启）
        /// </summary>
        public async Task<UpdateAdPlanOptStatusResponseModel> UpdateAdPlanOptStatusAsync (UpdateAdPlanOptStatusRequestModel updateAdPlanOptStatus) {
            var result = await PostAsync<UpdateAdPlanOptStatusRequestModel, UpdateAdPlanOptStatusResponseModel> ("pdd.ad.plan.opt.status.update", updateAdPlanOptStatus);
            return result;
        }
        /// <summary>
        /// 修改推广计划日限额
        /// </summary>
        public async Task<UpdateAdPlanMaxCostResponseModel> UpdateAdPlanMaxCostAsync (UpdateAdPlanMaxCostRequestModel updateAdPlanMaxCost) {
            var result = await PostAsync<UpdateAdPlanMaxCostRequestModel, UpdateAdPlanMaxCostResponseModel> ("pdd.ad.plan.max.cost.update", updateAdPlanMaxCost);
            return result;
        }
        /// <summary>
        /// 修改推广计划名称
        /// </summary>
        public async Task<UpdateAdPlanNameResponseModel> UpdateAdPlanNameAsync (UpdateAdPlanNameRequestModel updateAdPlanName) {
            var result = await PostAsync<UpdateAdPlanNameRequestModel, UpdateAdPlanNameResponseModel> ("pdd.ad.plan.name.update", updateAdPlanName);
            return result;
        }
        /// <summary>
        /// 删除推广计划
        /// </summary>
        public async Task<DeleteAdPlanResponseModel> DeleteAdPlanAsync (DeleteAdPlanRequestModel deleteAdPlan) {
            var result = await PostAsync<DeleteAdPlanRequestModel, DeleteAdPlanResponseModel> ("pdd.ad.plan.delete", deleteAdPlan);
            return result;
        }
        /// <summary>
        /// 获取现有计划基础信息
        /// </summary>
        public async Task<GetAdPlanInfoListResponseModel> GetAdPlanInfoListAsync (GetAdPlanInfoListRequestModel getAdPlanInfoList) {
            var result = await PostAsync<GetAdPlanInfoListRequestModel, GetAdPlanInfoListResponseModel> ("pdd.ad.plan.info.list.get", getAdPlanInfoList);
            return result;
        }
        /// <summary>
        /// 关键词实时报表数据
        /// </summary>
        public async Task<GetAdHistoryRtKeywordReportResponseModel> GetAdHistoryRtKeywordReportAsync (GetAdHistoryRtKeywordReportRequestModel getAdHistoryRtKeywordReport) {
            var result = await PostAsync<GetAdHistoryRtKeywordReportRequestModel, GetAdHistoryRtKeywordReportResponseModel> ("pdd.ad.history.rt.keyword.report.get", getAdHistoryRtKeywordReport);
            return result;
        }
        /// <summary>
        /// 推广单元实时报表数据
        /// </summary>
        public async Task<GetAdHistoryRtUnitReportResponseModel> GetAdHistoryRtUnitReportAsync (GetAdHistoryRtUnitReportRequestModel getAdHistoryRtUnitReport) {
            var result = await PostAsync<GetAdHistoryRtUnitReportRequestModel, GetAdHistoryRtUnitReportResponseModel> ("pdd.ad.history.rt.unit.report.get", getAdHistoryRtUnitReport);
            return result;
        }
        /// <summary>
        /// 推广计划实时报表数据
        /// </summary>
        public async Task<GetAdHistoryRtPlanReportResponseModel> GetAdHistoryRtPlanReportAsync (GetAdHistoryRtPlanReportRequestModel getAdHistoryRtPlanReport) {
            var result = await PostAsync<GetAdHistoryRtPlanReportRequestModel, GetAdHistoryRtPlanReportResponseModel> ("pdd.ad.history.rt.plan.report.get", getAdHistoryRtPlanReport);
            return result;
        }
        /// <summary>
        /// 账户推广实时报表数据
        /// </summary>
        public async Task<GetAdHistoryRtReportResponseModel> GetAdHistoryRtReportAsync (GetAdHistoryRtReportRequestModel getAdHistoryRtReport) {
            var result = await PostAsync<GetAdHistoryRtReportRequestModel, GetAdHistoryRtReportResponseModel> ("pdd.ad.history.rt.report.get", getAdHistoryRtReport);
            return result;
        }
        /// <summary>
        /// 关键词历史报表数据
        /// </summary>
        public async Task<GetAdHistoryKeywordReportResponseModel> GetAdHistoryKeywordReportAsync (GetAdHistoryKeywordReportRequestModel getAdHistoryKeywordReport) {
            var result = await PostAsync<GetAdHistoryKeywordReportRequestModel, GetAdHistoryKeywordReportResponseModel> ("pdd.ad.history.keyword.report.get", getAdHistoryKeywordReport);
            return result;
        }
        /// <summary>
        /// 推广单元历史报表数据
        /// </summary>
        public async Task<GetAdHistoryUnitReportResponseModel> GetAdHistoryUnitReportAsync (GetAdHistoryUnitReportRequestModel getAdHistoryUnitReport) {
            var result = await PostAsync<GetAdHistoryUnitReportRequestModel, GetAdHistoryUnitReportResponseModel> ("pdd.ad.history.unit.report.get", getAdHistoryUnitReport);
            return result;
        }
        /// <summary>
        /// 推广计划历史报表数据
        /// </summary>
        public async Task<GetAdHistoryPlanReportResponseModel> GetAdHistoryPlanReportAsync (GetAdHistoryPlanReportRequestModel getAdHistoryPlanReport) {
            var result = await PostAsync<GetAdHistoryPlanReportRequestModel, GetAdHistoryPlanReportResponseModel> ("pdd.ad.history.plan.report.get", getAdHistoryPlanReport);
            return result;
        }
        /// <summary>
        /// 账户推广历史报表数据
        /// </summary>
        public async Task<GetAdHistoryReportResponseModel> GetAdHistoryReportAsync (GetAdHistoryReportRequestModel getAdHistoryReport) {
            var result = await PostAsync<GetAdHistoryReportRequestModel, GetAdHistoryReportResponseModel> ("pdd.ad.history.report.get", getAdHistoryReport);
            return result;
        }
        /// <summary>
        /// 是否可以创建计划验证接口
        /// </summary>
        public async Task<PlanAdCanCreateResponseModel> PlanAdCanCreateAsync (PlanAdCanCreateRequestModel planAdCanCreate) {
            var result = await PostAsync<PlanAdCanCreateRequestModel, PlanAdCanCreateResponseModel> ("pdd.ad.can.create.plan", planAdCanCreate);
            return result;
        }
        /// <summary>
        /// 创意日报报表
        /// </summary>
        public async Task<GetAdCreativeReportResponseModel> GetAdCreativeReportAsync (GetAdCreativeReportRequestModel getAdCreativeReport) {
            var result = await PostAsync<GetAdCreativeReportRequestModel, GetAdCreativeReportResponseModel> ("pdd.ad.creative.report.get", getAdCreativeReport);
            return result;
        }
        /// <summary>
        /// 关键词历史报表数据， 一次性导出分天详情
        /// </summary>
        public async Task<ReportAdKeywordDailyResponseModel> ReportAdKeywordDailyAsync (ReportAdKeywordDailyRequestModel reportAdKeywordDaily) {
            var result = await PostAsync<ReportAdKeywordDailyRequestModel, ReportAdKeywordDailyResponseModel> ("pdd.ad.keyword.daily.report", reportAdKeywordDaily);
            return result;
        }
        /// <summary>
        /// 根据推广单元id获取现有创意列表
        /// </summary>
        public async Task<QueryAdCreativeResponseModel> QueryAdCreativeAsync (QueryAdCreativeRequestModel queryAdCreative) {
            var result = await PostAsync<QueryAdCreativeRequestModel, QueryAdCreativeResponseModel> ("pdd.ad.creative.query", queryAdCreative);
            return result;
        }
        /// <summary>
        /// 推广单元修改创意图片、创意标题
        /// </summary>
        public async Task<UpdateAdCreativeResponseModel> UpdateAdCreativeAsync (UpdateAdCreativeRequestModel updateAdCreative) {
            var result = await PostAsync<UpdateAdCreativeRequestModel, UpdateAdCreativeResponseModel> ("pdd.ad.creative.update", updateAdCreative);
            return result;
        }
        /// <summary>
        /// 推广单元删除创意（至少需保留一个创意）
        /// </summary>
        public async Task<DeleteAdCreativeResponseModel> DeleteAdCreativeAsync (DeleteAdCreativeRequestModel deleteAdCreative) {
            var result = await PostAsync<DeleteAdCreativeRequestModel, DeleteAdCreativeResponseModel> ("pdd.ad.creative.delete", deleteAdCreative);
            return result;
        }
        /// <summary>
        /// 推广单元增加创意
        /// </summary>
        public async Task<CreateAdCreativeResponseModel> CreateAdCreativeAsync (CreateAdCreativeRequestModel createAdCreative) {
            var result = await PostAsync<CreateAdCreativeRequestModel, CreateAdCreativeResponseModel> ("pdd.ad.creative.create", createAdCreative);
            return result;
        }
        /// <summary>
        /// 修改推广计划分时折扣
        /// </summary>
        public async Task<UpdateAdPlanDiscountResponseModel> UpdateAdPlanDiscountAsync (UpdateAdPlanDiscountRequestModel updateAdPlanDiscount) {
            var result = await PostAsync<UpdateAdPlanDiscountRequestModel, UpdateAdPlanDiscountResponseModel> ("pdd.ad.plan.discount.update", updateAdPlanDiscount);
            return result;
        }
        /// <summary>
        /// 创意历史报表数据
        /// </summary>
        public async Task<GetAdCreativeHistoryReportResponseModel> GetAdCreativeHistoryReportAsync (GetAdCreativeHistoryReportRequestModel getAdCreativeHistoryReport) {
            var result = await PostAsync<GetAdCreativeHistoryReportRequestModel, GetAdCreativeHistoryReportResponseModel> ("pdd.ad.creative.history.report.get", getAdCreativeHistoryReport);
            return result;
        }
        /// <summary>
        /// 获取可选资源位信息（日均可竞流量）
        /// </summary>
        public async Task<ListAdQueryLocationBidPvResponseModel> ListAdQueryLocationBidPvAsync (ListAdQueryLocationBidPvRequestModel listAdQueryLocationBidPv) {
            var result = await PostAsync<ListAdQueryLocationBidPvRequestModel, ListAdQueryLocationBidPvResponseModel> ("pdd.ad.query.location.bid.pv.list", listAdQueryLocationBidPv);
            return result;
        }
        /// <summary>
        /// 推广单元取消资源位
        /// </summary>
        public async Task<BidAdDeleteLocationResponseModel> BidAdDeleteLocationAsync (BidAdDeleteLocationRequestModel bidAdDeleteLocation) {
            var result = await PostAsync<BidAdDeleteLocationRequestModel, BidAdDeleteLocationResponseModel> ("pdd.ad.delete.location.bid", bidAdDeleteLocation);
            return result;
        }
        /// <summary>
        /// 推广单元修改资源位溢价（批量）
        /// </summary>
        public async Task<BidAdUpdateLocationResponseModel> BidAdUpdateLocationAsync (BidAdUpdateLocationRequestModel bidAdUpdateLocation) {
            var result = await PostAsync<BidAdUpdateLocationRequestModel, BidAdUpdateLocationResponseModel> ("pdd.ad.update.location.bid", bidAdUpdateLocation);
            return result;
        }
        /// <summary>
        /// 推广单元新增资源位信息（批量）
        /// </summary>
        public async Task<BidAdCreateLocationResponseModel> BidAdCreateLocationAsync (BidAdCreateLocationRequestModel bidAdCreateLocation) {
            var result = await PostAsync<BidAdCreateLocationRequestModel, BidAdCreateLocationResponseModel> ("pdd.ad.create.location.bid", bidAdCreateLocation);
            return result;
        }
        /// <summary>
        /// 根据推广单元id获取现有资源位列表
        /// </summary>
        public async Task<ListAdQueryLocationBidResponseModel> ListAdQueryLocationBidAsync (ListAdQueryLocationBidRequestModel listAdQueryLocationBid) {
            var result = await PostAsync<ListAdQueryLocationBidRequestModel, ListAdQueryLocationBidResponseModel> ("pdd.ad.query.location.bid.list", listAdQueryLocationBid);
            return result;
        }
        /// <summary>
        /// 资源位历史报表数据
        /// </summary>
        public async Task<ReportAdQueryLocationBidHistoryResponseModel> ReportAdQueryLocationBidHistoryAsync (ReportAdQueryLocationBidHistoryRequestModel reportAdQueryLocationBidHistory) {
            var result = await PostAsync<ReportAdQueryLocationBidHistoryRequestModel, ReportAdQueryLocationBidHistoryResponseModel> ("pdd.ad.query.location.bid.history.report", reportAdQueryLocationBidHistory);
            return result;
        }
        /// <summary>
        /// 推广单元增加定向（“定向”包括兴趣点）
        /// </summary>
        public async Task<BidAdCreateUnitResponseModel> BidAdCreateUnitAsync (BidAdCreateUnitRequestModel bidAdCreateUnit) {
            var result = await PostAsync<BidAdCreateUnitRequestModel, BidAdCreateUnitResponseModel> ("pdd.ad.create.unit.bid", bidAdCreateUnit);
            return result;
        }
        /// <summary>
        /// 【定向】用户数量预估，兴趣点查询等信息
        /// </summary>
        public async Task<ProfileAdBidQueryResponseModel> ProfileAdBidQueryAsync (ProfileAdBidQueryRequestModel profileAdBidQuery) {
            var result = await PostAsync<ProfileAdBidQueryRequestModel, ProfileAdBidQueryResponseModel> ("pdd.ad.bid.query.profile", profileAdBidQuery);
            return result;
        }
        /// <summary>
        /// 根据推广单元id获取现有定向
        /// </summary>
        public async Task<ListAdQueryBidResponseModel> ListAdQueryBidAsync (ListAdQueryBidRequestModel listAdQueryBid) {
            var result = await PostAsync<ListAdQueryBidRequestModel, ListAdQueryBidResponseModel> ("pdd.ad.query.bid.list", listAdQueryBid);
            return result;
        }
        /// <summary>
        /// 【定向】推广单元修改通投出价、定向溢价
        /// </summary>
        public async Task<BidAdUpdateResponseModel> BidAdUpdateAsync (BidAdUpdateRequestModel bidAdUpdate) {
            var result = await PostAsync<BidAdUpdateRequestModel, BidAdUpdateResponseModel> ("pdd.ad.update.bid", bidAdUpdate);
            return result;
        }
        /// <summary>
        /// 定向历史报表数据
        /// </summary>
        public async Task<ReportAdQueryUnitBidHistoryResponseModel> ReportAdQueryUnitBidHistoryAsync (ReportAdQueryUnitBidHistoryRequestModel reportAdQueryUnitBidHistory) {
            var result = await PostAsync<ReportAdQueryUnitBidHistoryRequestModel, ReportAdQueryUnitBidHistoryResponseModel> ("pdd.ad.query.unit.bid.history.report", reportAdQueryUnitBidHistory);
            return result;
        }
        /// <summary>
        /// 推广单元取消定向（不可取消通投）
        /// </summary>
        public async Task<BidAdDeleteResponseModel> BidAdDeleteAsync (BidAdDeleteRequestModel bidAdDelete) {
            var result = await PostAsync<BidAdDeleteRequestModel, BidAdDeleteResponseModel> ("pdd.ad.delete.bid", bidAdDelete);
            return result;
        }
        /// <summary>
        /// 获取拼多多推广账户余额
        /// </summary>
        public async Task<GetAdBalanceResponseModel> GetAdBalanceAsync (GetAdBalanceRequestModel getAdBalance) {
            var result = await PostAsync<GetAdBalanceRequestModel, GetAdBalanceResponseModel> ("pdd.ad.balance.get", getAdBalance);
            return result;
        }
        /// <summary>
        /// 新建推广计划
        /// </summary>
        public async Task<CreateAdPlanResponseModel> CreateAdPlanAsync (CreateAdPlanRequestModel createAdPlan) {
            var result = await PostAsync<CreateAdPlanRequestModel, CreateAdPlanResponseModel> ("pdd.ad.plan.create", createAdPlan);
            return result;
        }

    }
}