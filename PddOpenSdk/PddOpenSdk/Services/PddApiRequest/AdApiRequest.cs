using App.Models.PddApiRequest;
using App.Models.PddApiResponse;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace App.Services.PddApiRequest
{
    public class AdApiRequest : PddRequest {
        /// <summary>
/// 获取关键词推广报表信息
/// </summary>
public async Task<GetAdChartBykeywordResponseModel> GetAdChartBykeywordAsync(GetAdChartBykeywordRequestModel getAdChartBykeyword)
{
    var result = await PostAsync<GetAdChartBykeywordRequestModel,GetAdChartBykeywordResponseModel>("pdd.ad.chart.bykeyword.get",getAdChartBykeyword);
    return result;
}
/// <summary>
/// 系统推荐关键词
/// </summary>
public async Task<GetAdKeywordRcommendedResponseModel> GetAdKeywordRcommendedAsync(GetAdKeywordRcommendedRequestModel getAdKeywordRcommended)
{
    var result = await PostAsync<GetAdKeywordRcommendedRequestModel,GetAdKeywordRcommendedResponseModel>("pdd.ad.keyword.rcommended.get",getAdKeywordRcommended);
    return result;
}
/// <summary>
/// 关键词商品相关性
/// </summary>
public async Task<GetAdKeywordRelevanceResponseModel> GetAdKeywordRelevanceAsync(GetAdKeywordRelevanceRequestModel getAdKeywordRelevance)
{
    var result = await PostAsync<GetAdKeywordRelevanceRequestModel,GetAdKeywordRelevanceResponseModel>("pdd.ad.keyword.relevance.get",getAdKeywordRelevance);
    return result;
}
/// <summary>
/// 推广单元修改关键词出价
/// </summary>
public async Task<UpdateAdKeywordResponseModel> UpdateAdKeywordAsync(UpdateAdKeywordRequestModel updateAdKeyword)
{
    var result = await PostAsync<UpdateAdKeywordRequestModel,UpdateAdKeywordResponseModel>("pdd.ad.keyword.update",updateAdKeyword);
    return result;
}
/// <summary>
/// 推广单元删除关键词
/// </summary>
public async Task<DeleteAdKeywordResponseModel> DeleteAdKeywordAsync(DeleteAdKeywordRequestModel deleteAdKeyword)
{
    var result = await PostAsync<DeleteAdKeywordRequestModel,DeleteAdKeywordResponseModel>("pdd.ad.keyword.delete",deleteAdKeyword);
    return result;
}
/// <summary>
/// 推广单元添加关键词
/// </summary>
public async Task<CreateAdKeywordResponseModel> CreateAdKeywordAsync(CreateAdKeywordRequestModel createAdKeyword)
{
    var result = await PostAsync<CreateAdKeywordRequestModel,CreateAdKeywordResponseModel>("pdd.ad.keyword.create",createAdKeyword);
    return result;
}
/// <summary>
/// 删除推广单元-批量
/// </summary>
public async Task<DeleteAdUnitResponseModel> DeleteAdUnitAsync(DeleteAdUnitRequestModel deleteAdUnit)
{
    var result = await PostAsync<DeleteAdUnitRequestModel,DeleteAdUnitResponseModel>("pdd.ad.unit.delete",deleteAdUnit);
    return result;
}
/// <summary>
/// 添加推广单元
/// </summary>
public async Task<CreateAdUnitResponseModel> CreateAdUnitAsync(CreateAdUnitRequestModel createAdUnit)
{
    var result = await PostAsync<CreateAdUnitRequestModel,CreateAdUnitResponseModel>("pdd.ad.unit.create",createAdUnit);
    return result;
}
/// <summary>
/// 暂停、开启推广单元
/// </summary>
public async Task<UpdateAdUnitOptStatusResponseModel> UpdateAdUnitOptStatusAsync(UpdateAdUnitOptStatusRequestModel updateAdUnitOptStatus)
{
    var result = await PostAsync<UpdateAdUnitOptStatusRequestModel,UpdateAdUnitOptStatusResponseModel>("pdd.ad.unit.opt.status.update",updateAdUnitOptStatus);
    return result;
}
/// <summary>
/// 根据计划id获取推广单元基本信息
/// </summary>
public async Task<IdAdUnitGetByPlanResponseModel> IdAdUnitGetByPlanAsync(IdAdUnitGetByPlanRequestModel idAdUnitGetByPlan)
{
    var result = await PostAsync<IdAdUnitGetByPlanRequestModel,IdAdUnitGetByPlanResponseModel>("pdd.ad.unit.get.by.plan.id",idAdUnitGetByPlan);
    return result;
}
/// <summary>
/// 修改推广计划状态（暂停、开启）
/// </summary>
public async Task<UpdateAdPlanOptStatusResponseModel> UpdateAdPlanOptStatusAsync(UpdateAdPlanOptStatusRequestModel updateAdPlanOptStatus)
{
    var result = await PostAsync<UpdateAdPlanOptStatusRequestModel,UpdateAdPlanOptStatusResponseModel>("pdd.ad.plan.opt.status.update",updateAdPlanOptStatus);
    return result;
}
/// <summary>
/// 修改推广计划日限额
/// </summary>
public async Task<UpdateAdPlanMaxCostResponseModel> UpdateAdPlanMaxCostAsync(UpdateAdPlanMaxCostRequestModel updateAdPlanMaxCost)
{
    var result = await PostAsync<UpdateAdPlanMaxCostRequestModel,UpdateAdPlanMaxCostResponseModel>("pdd.ad.plan.max.cost.update",updateAdPlanMaxCost);
    return result;
}
/// <summary>
/// 修改推广计划名称
/// </summary>
public async Task<UpdateAdPlanNameResponseModel> UpdateAdPlanNameAsync(UpdateAdPlanNameRequestModel updateAdPlanName)
{
    var result = await PostAsync<UpdateAdPlanNameRequestModel,UpdateAdPlanNameResponseModel>("pdd.ad.plan.name.update",updateAdPlanName);
    return result;
}
/// <summary>
/// 删除推广计划
/// </summary>
public async Task<DeleteAdPlanResponseModel> DeleteAdPlanAsync(DeleteAdPlanRequestModel deleteAdPlan)
{
    var result = await PostAsync<DeleteAdPlanRequestModel,DeleteAdPlanResponseModel>("pdd.ad.plan.delete",deleteAdPlan);
    return result;
}
/// <summary>
/// 新建推广计划
/// </summary>
public async Task<CreateAdPlanResponseModel> CreateAdPlanAsync(CreateAdPlanRequestModel createAdPlan)
{
    var result = await PostAsync<CreateAdPlanRequestModel,CreateAdPlanResponseModel>("pdd.ad.plan.create",createAdPlan);
    return result;
}
/// <summary>
/// 获取现有计划基础信息
/// </summary>
public async Task<GetAdPlanInfoListResponseModel> GetAdPlanInfoListAsync(GetAdPlanInfoListRequestModel getAdPlanInfoList)
{
    var result = await PostAsync<GetAdPlanInfoListRequestModel,GetAdPlanInfoListResponseModel>("pdd.ad.plan.info.list.get",getAdPlanInfoList);
    return result;
}
/// <summary>
/// 获取拼多多推广账户余额
/// </summary>
public async Task<GetAdBalanceResponseModel> GetAdBalanceAsync(GetAdBalanceRequestModel getAdBalance)
{
    var result = await PostAsync<GetAdBalanceRequestModel,GetAdBalanceResponseModel>("pdd.ad.balance.get",getAdBalance);
    return result;
}
/// <summary>
/// 关键词实时报表数据
/// </summary>
public async Task<GetAdHistoryRtKeywordReportResponseModel> GetAdHistoryRtKeywordReportAsync(GetAdHistoryRtKeywordReportRequestModel getAdHistoryRtKeywordReport)
{
    var result = await PostAsync<GetAdHistoryRtKeywordReportRequestModel,GetAdHistoryRtKeywordReportResponseModel>("pdd.ad.history.rt.keyword.report.get",getAdHistoryRtKeywordReport);
    return result;
}
/// <summary>
/// 推广单元实时报表数据
/// </summary>
public async Task<GetAdHistoryRtUnitReportResponseModel> GetAdHistoryRtUnitReportAsync(GetAdHistoryRtUnitReportRequestModel getAdHistoryRtUnitReport)
{
    var result = await PostAsync<GetAdHistoryRtUnitReportRequestModel,GetAdHistoryRtUnitReportResponseModel>("pdd.ad.history.rt.unit.report.get",getAdHistoryRtUnitReport);
    return result;
}
/// <summary>
/// 推广计划实时报表数据
/// </summary>
public async Task<GetAdHistoryRtPlanReportResponseModel> GetAdHistoryRtPlanReportAsync(GetAdHistoryRtPlanReportRequestModel getAdHistoryRtPlanReport)
{
    var result = await PostAsync<GetAdHistoryRtPlanReportRequestModel,GetAdHistoryRtPlanReportResponseModel>("pdd.ad.history.rt.plan.report.get",getAdHistoryRtPlanReport);
    return result;
}
/// <summary>
/// 账户推广实时报表数据
/// </summary>
public async Task<GetAdHistoryRtReportResponseModel> GetAdHistoryRtReportAsync(GetAdHistoryRtReportRequestModel getAdHistoryRtReport)
{
    var result = await PostAsync<GetAdHistoryRtReportRequestModel,GetAdHistoryRtReportResponseModel>("pdd.ad.history.rt.report.get",getAdHistoryRtReport);
    return result;
}
/// <summary>
/// 关键词历史报表数据
/// </summary>
public async Task<GetAdHistoryKeywordReportResponseModel> GetAdHistoryKeywordReportAsync(GetAdHistoryKeywordReportRequestModel getAdHistoryKeywordReport)
{
    var result = await PostAsync<GetAdHistoryKeywordReportRequestModel,GetAdHistoryKeywordReportResponseModel>("pdd.ad.history.keyword.report.get",getAdHistoryKeywordReport);
    return result;
}
/// <summary>
/// 推广单元历史报表数据
/// </summary>
public async Task<GetAdHistoryUnitReportResponseModel> GetAdHistoryUnitReportAsync(GetAdHistoryUnitReportRequestModel getAdHistoryUnitReport)
{
    var result = await PostAsync<GetAdHistoryUnitReportRequestModel,GetAdHistoryUnitReportResponseModel>("pdd.ad.history.unit.report.get",getAdHistoryUnitReport);
    return result;
}
/// <summary>
/// 推广计划历史报表数据
/// </summary>
public async Task<GetAdHistoryPlanReportResponseModel> GetAdHistoryPlanReportAsync(GetAdHistoryPlanReportRequestModel getAdHistoryPlanReport)
{
    var result = await PostAsync<GetAdHistoryPlanReportRequestModel,GetAdHistoryPlanReportResponseModel>("pdd.ad.history.plan.report.get",getAdHistoryPlanReport);
    return result;
}
/// <summary>
/// 账户推广历史报表数据
/// </summary>
public async Task<GetAdHistoryReportResponseModel> GetAdHistoryReportAsync(GetAdHistoryReportRequestModel getAdHistoryReport)
{
    var result = await PostAsync<GetAdHistoryReportRequestModel,GetAdHistoryReportResponseModel>("pdd.ad.history.report.get",getAdHistoryReport);
    return result;
}
/// <summary>
/// 是否可以创建计划验证接口
/// </summary>
public async Task<PlanAdCanCreateResponseModel> PlanAdCanCreateAsync(PlanAdCanCreateRequestModel planAdCanCreate)
{
    var result = await PostAsync<PlanAdCanCreateRequestModel,PlanAdCanCreateResponseModel>("pdd.ad.can.create.plan",planAdCanCreate);
    return result;
}
/// <summary>
/// 创意日报报表
/// </summary>
public async Task<GetAdCreativeReportResponseModel> GetAdCreativeReportAsync(GetAdCreativeReportRequestModel getAdCreativeReport)
{
    var result = await PostAsync<GetAdCreativeReportRequestModel,GetAdCreativeReportResponseModel>("pdd.ad.creative.report.get",getAdCreativeReport);
    return result;
}

    }
}
