using PddOpenSdk.Models.PddApiResult;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Services.PddApiRequest
{
    public class AdApiRequest : PddRequest {
        /// <summary>
/// 获取关键词推广报表信息
/// </summary>
/// <param name="Type">该值为：pdd.ad.chart.bykeyword.get</param>
/// <param name="Date">报表日期，仅能查询近30天的报表数据，格式为：YYYY-MM-DD</param>
/// <param name="Page">返回页数，默认1页</param>
/// <param name="PageSize">每页返回条数，默认20条</param>
public async Task<GetAdChartBykeywordApiResult> GetAdChartBykeywordAsync(string Type,string Date,int Page,int PageSize)
{
    var dic = new Dictionary<string, object>();
    dic.Add("type",Type);
dic.Add("date",Date);
dic.Add("page",Page);
dic.Add("page_size",PageSize);
    
    var result = await PostAsync<GetAdChartBykeywordApiResult>("pdd.ad.chart.bykeyword.get",dic);
    return result;
}/// <summary>
/// 系统推荐关键词
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="GoodsId">商品id</param>
public async Task<GetAdKeywordRcommendedApiResult> GetAdKeywordRcommendedAsync(int SceneType,int GoodsId)
{
    var dic = new Dictionary<string, object>();
    dic.Add("scene_type",SceneType);
dic.Add("goods_id",GoodsId);
    
    var result = await PostAsync<GetAdKeywordRcommendedApiResult>("pdd.ad.keyword.rcommended.get",dic);
    return result;
}/// <summary>
/// 关键词商品相关性
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="Words">["test"]</param>
/// <param name="GoodsId">商品id</param>
public async Task<GetAdKeywordRelevanceApiResult> GetAdKeywordRelevanceAsync(int SceneType,string Words,int GoodsId)
{
    var dic = new Dictionary<string, object>();
    dic.Add("scene_type",SceneType);
dic.Add("words",Words);
dic.Add("goods_id",GoodsId);
    
    var result = await PostAsync<GetAdKeywordRelevanceApiResult>("pdd.ad.keyword.relevance.get",dic);
    return result;
}/// <summary>
/// 推广单元修改关键词出价
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="Keywords"></param>
/// <param name="Bid">关键字出价（厘）范围需在0.10~99.0元区间内</param>
/// <param name="KeywordId">关键词id</param>
public async Task<UpdateAdKeywordApiResult> UpdateAdKeywordAsync(int SceneType,string Keywords,int Bid,int KeywordId)
{
    var dic = new Dictionary<string, object>();
    dic.Add("scene_type",SceneType);
dic.Add("keywords",Keywords);
dic.Add("bid",Bid);
dic.Add("keyword_id",KeywordId);
    
    var result = await PostAsync<UpdateAdKeywordApiResult>("pdd.ad.keyword.update",dic);
    return result;
}/// <summary>
/// 推广单元删除关键词
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="KeywordIds">keyword_id列表，[1,2]</param>
public async Task<DeleteAdKeywordApiResult> DeleteAdKeywordAsync(int SceneType,string KeywordIds)
{
    var dic = new Dictionary<string, object>();
    dic.Add("scene_type",SceneType);
dic.Add("keyword_ids",KeywordIds);
    
    var result = await PostAsync<DeleteAdKeywordApiResult>("pdd.ad.keyword.delete",dic);
    return result;
}/// <summary>
/// 推广单元添加关键词
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="UnitId">单元id</param>
/// <param name="Keywords">[{"word":"test","bid":200}]</param>
/// <param name="Bid">关键字出价（厘）范围需在0.10~99.0元区间内</param>
/// <param name="Word">关键词</param>
public async Task<CreateAdKeywordApiResult> CreateAdKeywordAsync(int SceneType,int UnitId,string Keywords,int Bid,string Word)
{
    var dic = new Dictionary<string, object>();
    dic.Add("scene_type",SceneType);
dic.Add("unit_id",UnitId);
dic.Add("keywords",Keywords);
dic.Add("bid",Bid);
dic.Add("word",Word);
    
    var result = await PostAsync<CreateAdKeywordApiResult>("pdd.ad.keyword.create",dic);
    return result;
}/// <summary>
/// 删除推广单元-批量
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="UnitIds">unit_id列表，[1,2]</param>
public async Task<DeleteAdUnitApiResult> DeleteAdUnitAsync(int SceneType,string UnitIds)
{
    var dic = new Dictionary<string, object>();
    dic.Add("scene_type",SceneType);
dic.Add("unit_ids",UnitIds);
    
    var result = await PostAsync<DeleteAdUnitApiResult>("pdd.ad.unit.delete",dic);
    return result;
}/// <summary>
/// 添加推广单元
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="PlanId">计划id</param>
/// <param name="GoodsId">商品id</param>
/// <param name="Keywords">[{"word":"test","bid":200}]</param>
/// <param name="Bid">关键字出价（厘）范围需在0.10~99.0元区间内</param>
/// <param name="Word">关键词</param>
public async Task<CreateAdUnitApiResult> CreateAdUnitAsync(int SceneType,string PlanId,int GoodsId,string Keywords,int Bid,string Word)
{
    var dic = new Dictionary<string, object>();
    dic.Add("scene_type",SceneType);
dic.Add("plan_id",PlanId);
dic.Add("goods_id",GoodsId);
dic.Add("keywords",Keywords);
dic.Add("bid",Bid);
dic.Add("word",Word);
    
    var result = await PostAsync<CreateAdUnitApiResult>("pdd.ad.unit.create",dic);
    return result;
}/// <summary>
/// 暂停、开启推广单元
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="UnitIds">unit_id列表，[1,2]</param>
/// <param name="OptStatus">1 已启用,2 已暂停</param>
public async Task<UpdateAdUnitOptStatusApiResult> UpdateAdUnitOptStatusAsync(int SceneType,string UnitIds,int OptStatus)
{
    var dic = new Dictionary<string, object>();
    dic.Add("scene_type",SceneType);
dic.Add("unit_ids",UnitIds);
dic.Add("opt_status",OptStatus);
    
    var result = await PostAsync<UpdateAdUnitOptStatusApiResult>("pdd.ad.unit.opt.status.update",dic);
    return result;
}/// <summary>
/// 根据计划id获取推广单元基本信息
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="PlanId">计划id</param>
public async Task<IdAdUnitGetByPlanApiResult> IdAdUnitGetByPlanAsync(int SceneType,string PlanId)
{
    var dic = new Dictionary<string, object>();
    dic.Add("scene_type",SceneType);
dic.Add("plan_id",PlanId);
    
    var result = await PostAsync<IdAdUnitGetByPlanApiResult>("pdd.ad.unit.get.by.plan.id",dic);
    return result;
}/// <summary>
/// 修改推广计划状态（暂停、开启）
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="PlanId">计划id</param>
/// <param name="OptStatus">1 已启用,2 已暂停</param>
public async Task<UpdateAdPlanOptStatusApiResult> UpdateAdPlanOptStatusAsync(int SceneType,string PlanId,int OptStatus)
{
    var dic = new Dictionary<string, object>();
    dic.Add("scene_type",SceneType);
dic.Add("plan_id",PlanId);
dic.Add("opt_status",OptStatus);
    
    var result = await PostAsync<UpdateAdPlanOptStatusApiResult>("pdd.ad.plan.opt.status.update",dic);
    return result;
}/// <summary>
/// 修改推广计划日限额
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="PlanId">计划id</param>
/// <param name="MaxCost">计划日限额，单位厘</param>
public async Task<UpdateAdPlanMaxCostApiResult> UpdateAdPlanMaxCostAsync(int SceneType,string PlanId,int MaxCost)
{
    var dic = new Dictionary<string, object>();
    dic.Add("scene_type",SceneType);
dic.Add("plan_id",PlanId);
dic.Add("max_cost",MaxCost);
    
    var result = await PostAsync<UpdateAdPlanMaxCostApiResult>("pdd.ad.plan.max.cost.update",dic);
    return result;
}/// <summary>
/// 修改推广计划名称
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="PlanId">计划id</param>
/// <param name="PlanName">计划名</param>
public async Task<UpdateAdPlanNameApiResult> UpdateAdPlanNameAsync(int SceneType,string PlanId,string PlanName)
{
    var dic = new Dictionary<string, object>();
    dic.Add("scene_type",SceneType);
dic.Add("plan_id",PlanId);
dic.Add("plan_name",PlanName);
    
    var result = await PostAsync<UpdateAdPlanNameApiResult>("pdd.ad.plan.name.update",dic);
    return result;
}/// <summary>
/// 删除推广计划
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="PlanIds">plan_id 列表，示例：[1,2]</param>
public async Task<DeleteAdPlanApiResult> DeleteAdPlanAsync(int SceneType,string PlanIds)
{
    var dic = new Dictionary<string, object>();
    dic.Add("scene_type",SceneType);
dic.Add("plan_ids",PlanIds);
    
    var result = await PostAsync<DeleteAdPlanApiResult>("pdd.ad.plan.delete",dic);
    return result;
}/// <summary>
/// 新建推广计划
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="PlanName">计划名</param>
/// <param name="MaxCost">单日消耗，单位厘;上限不能超过1000000元，单日消耗上限不能低于100元</param>
public async Task<CreateAdPlanApiResult> CreateAdPlanAsync(int SceneType,string PlanName,int MaxCost)
{
    var dic = new Dictionary<string, object>();
    dic.Add("scene_type",SceneType);
dic.Add("plan_name",PlanName);
dic.Add("max_cost",MaxCost);
    
    var result = await PostAsync<CreateAdPlanApiResult>("pdd.ad.plan.create",dic);
    return result;
}/// <summary>
/// 获取现有计划基础信息
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="PlanId">计划id</param>
public async Task<GetAdPlanInfoListApiResult> GetAdPlanInfoListAsync(int SceneType,int PlanId)
{
    var dic = new Dictionary<string, object>();
    dic.Add("scene_type",SceneType);
dic.Add("plan_id",PlanId);
    
    var result = await PostAsync<GetAdPlanInfoListApiResult>("pdd.ad.plan.info.list.get",dic);
    return result;
}/// <summary>
/// 获取拼多多推广账户余额
/// </summary>
public async Task<GetAdBalanceApiResult> GetAdBalanceAsync()
{
    var dic = new Dictionary<string, object>();
        
    var result = await PostAsync<GetAdBalanceApiResult>("pdd.ad.balance.get",dic);
    return result;
}/// <summary>
/// 关键词实时报表数据
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="UnitId">单元id</param>
public async Task<GetAdHistoryRtKeywordReportApiResult> GetAdHistoryRtKeywordReportAsync(int SceneType,int UnitId)
{
    var dic = new Dictionary<string, object>();
    dic.Add("scene_type",SceneType);
dic.Add("unit_id",UnitId);
    
    var result = await PostAsync<GetAdHistoryRtKeywordReportApiResult>("pdd.ad.history.rt.keyword.report.get",dic);
    return result;
}/// <summary>
/// 推广单元实时报表数据
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="PlanId">计划id</param>
public async Task<GetAdHistoryRtUnitReportApiResult> GetAdHistoryRtUnitReportAsync(int SceneType,int PlanId)
{
    var dic = new Dictionary<string, object>();
    dic.Add("scene_type",SceneType);
dic.Add("plan_id",PlanId);
    
    var result = await PostAsync<GetAdHistoryRtUnitReportApiResult>("pdd.ad.history.rt.unit.report.get",dic);
    return result;
}/// <summary>
/// 推广计划实时报表数据
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
public async Task<GetAdHistoryRtPlanReportApiResult> GetAdHistoryRtPlanReportAsync(int SceneType)
{
    var dic = new Dictionary<string, object>();
    dic.Add("scene_type",SceneType);
    
    var result = await PostAsync<GetAdHistoryRtPlanReportApiResult>("pdd.ad.history.rt.plan.report.get",dic);
    return result;
}/// <summary>
/// 账户推广实时报表数据
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
public async Task<GetAdHistoryRtReportApiResult> GetAdHistoryRtReportAsync(int SceneType)
{
    var dic = new Dictionary<string, object>();
    dic.Add("scene_type",SceneType);
    
    var result = await PostAsync<GetAdHistoryRtReportApiResult>("pdd.ad.history.rt.report.get",dic);
    return result;
}/// <summary>
/// 关键词历史报表数据
/// </summary>
/// <param name="BeginDate">开始时间：2018-05-01（周期不超过一个月，记录保存最近30天）</param>
/// <param name="EndDate">结束时间：2018-05-02（周期不超过一个月，记录保存最近30天）</param>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="GroupBy">1--按日期分组,2--按关键词id分组</param>
/// <param name="OrderBy">0--曝光量排序,1--点击量排序,2--点击率,3--点击单价排序,4--消耗排序,5--订单数排序,6--交易额排序,7--产出比排序,8--日期,9--千次曝光单价;默认8</param>
/// <param name="SortBy">0--降序,1--升序;默认0</param>
/// <param name="Page">页码，默认1，当group_by=2时才生效</param>
/// <param name="PageSize">每页数量，默认100，当group_by=2时才生效</param>
/// <param name="UnitId">单元id，groupBy = 1时必须传值，groupBy = 2时可以传值</param>
/// <param name="Keyword">关键词，仅当groupBy = 1时必须传值</param>
/// <param name="PlanId">计划id，仅当groupBy = 2时可以传值</param>
public async Task<GetAdHistoryKeywordReportApiResult> GetAdHistoryKeywordReportAsync(string BeginDate,string EndDate,int SceneType,int GroupBy,int OrderBy,int SortBy,int Page,int PageSize,int UnitId,string Keyword,int PlanId)
{
    var dic = new Dictionary<string, object>();
    dic.Add("begin_date",BeginDate);
dic.Add("end_date",EndDate);
dic.Add("scene_type",SceneType);
dic.Add("group_by",GroupBy);
dic.Add("order_by",OrderBy);
dic.Add("sort_by",SortBy);
dic.Add("page",Page);
dic.Add("page_size",PageSize);
dic.Add("unit_id",UnitId);
dic.Add("keyword",Keyword);
dic.Add("plan_id",PlanId);
    
    var result = await PostAsync<GetAdHistoryKeywordReportApiResult>("pdd.ad.history.keyword.report.get",dic);
    return result;
}/// <summary>
/// 推广单元历史报表数据
/// </summary>
/// <param name="BeginDate">开始时间：2018-05-01（周期不超过一个月，记录保存最近30天）</param>
/// <param name="EndDate">结束时间：2018-05-02（周期不超过一个月，记录保存最近30天）</param>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="GroupBy">1--按日期分组,2--按单元id分组</param>
/// <param name="OrderBy">0--曝光量排序,1--点击量排序,2--点击率,3--点击单价排序,4--消耗排序,5--订单数排序,6--交易额排序,7--产出比排序,8--日期,默认8</param>
/// <param name="SortBy">0--降序,1--升序;默认0</param>
/// <param name="Page">页码，默认1，当group_by=2时才生效</param>
/// <param name="PageSize">每页数量，默认100，当group_by=2时才生效</param>
/// <param name="UnitId">单元id，单元id，仅当groupBy = 1时传值</param>
/// <param name="PlanId">计划id，groupBy = 2时传值</param>
public async Task<GetAdHistoryUnitReportApiResult> GetAdHistoryUnitReportAsync(string BeginDate,string EndDate,int SceneType,int GroupBy,int OrderBy,int SortBy,int Page,int PageSize,int UnitId,int PlanId)
{
    var dic = new Dictionary<string, object>();
    dic.Add("begin_date",BeginDate);
dic.Add("end_date",EndDate);
dic.Add("scene_type",SceneType);
dic.Add("group_by",GroupBy);
dic.Add("order_by",OrderBy);
dic.Add("sort_by",SortBy);
dic.Add("page",Page);
dic.Add("page_size",PageSize);
dic.Add("unit_id",UnitId);
dic.Add("plan_Id",PlanId);
    
    var result = await PostAsync<GetAdHistoryUnitReportApiResult>("pdd.ad.history.unit.report.get",dic);
    return result;
}/// <summary>
/// 推广计划历史报表数据
/// </summary>
/// <param name="BeginDate">开始时间：2018-05-01（周期不超过一个月，记录保存最近30天）</param>
/// <param name="EndDate">结束时间：2018-05-02（周期不超过一个月，记录保存最近30天）</param>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="GroupBy">1--按日期分组,2--按计划id分组</param>
/// <param name="OrderBy">0--曝光量排序,1--点击量排序,2--点击率,3--点击单价排序,4--消耗排序,5--订单数排序,6--交易额排序,7--产出比排序,8--日期,9--千次曝光单价;默认8</param>
/// <param name="SortBy">0--降序,1--升序;默认0</param>
/// <param name="Page">页码，默认1，当group_by=2时才生效</param>
/// <param name="PageSize">每页数量，默认100，当group_by=2时才生效</param>
/// <param name="PlanId">计划id，当group_by=1时，plan_Id必填</param>
public async Task<GetAdHistoryPlanReportApiResult> GetAdHistoryPlanReportAsync(string BeginDate,string EndDate,int SceneType,int GroupBy,int OrderBy,int SortBy,int Page,int PageSize,int PlanId)
{
    var dic = new Dictionary<string, object>();
    dic.Add("begin_date",BeginDate);
dic.Add("end_date",EndDate);
dic.Add("scene_type",SceneType);
dic.Add("group_by",GroupBy);
dic.Add("order_by",OrderBy);
dic.Add("sort_by",SortBy);
dic.Add("page",Page);
dic.Add("page_size",PageSize);
dic.Add("plan_id",PlanId);
    
    var result = await PostAsync<GetAdHistoryPlanReportApiResult>("pdd.ad.history.plan.report.get",dic);
    return result;
}/// <summary>
/// 账户推广历史报表数据
/// </summary>
/// <param name="BeginDate">开始时间：2018-05-01（周期不超过一个月，记录保存最近30天）</param>
/// <param name="EndDate">结束时间：2018-05-02（周期不超过一个月，记录保存最近30天）</param>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="OrderBy">0--曝光量排序,1--点击量排序,2--点击率,3--点击单价排序,4--消耗排序,5--订单数排序,6--交易额排序,7--产出比排序,8--日期;默认8</param>
/// <param name="SortBy">0--降序,1--升序;默认0</param>
public async Task<GetAdHistoryReportApiResult> GetAdHistoryReportAsync(string BeginDate,string EndDate,int SceneType,int OrderBy,int SortBy)
{
    var dic = new Dictionary<string, object>();
    dic.Add("begin_date",BeginDate);
dic.Add("end_date",EndDate);
dic.Add("scene_type",SceneType);
dic.Add("order_by",OrderBy);
dic.Add("sort_by",SortBy);
    
    var result = await PostAsync<GetAdHistoryReportApiResult>("pdd.ad.history.report.get",dic);
    return result;
}/// <summary>
/// 是否可以创建计划验证接口
/// </summary>
/// <param name="PlanName">计划名</param>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告</param>
public async Task<PlanAdCanCreateApiResult> PlanAdCanCreateAsync(string PlanName,int SceneType)
{
    var dic = new Dictionary<string, object>();
    dic.Add("plan_name",PlanName);
dic.Add("scene_type",SceneType);
    
    var result = await PostAsync<PlanAdCanCreateApiResult>("pdd.ad.can.create.plan",dic);
    return result;
}/// <summary>
/// 创意日报报表
/// </summary>
/// <param name="BeginDate">开始时间 2018-01-01</param>
/// <param name="EndDate">结束时间 2018-01-01</param>
/// <param name="PageSize">页面大小,默认100</param>
/// <param name="PageNumber">页面数,默认1</param>
public async Task<GetAdCreativeReportApiResult> GetAdCreativeReportAsync(string BeginDate,string EndDate,int PageSize,int PageNumber)
{
    var dic = new Dictionary<string, object>();
    dic.Add("begin_date",BeginDate);
dic.Add("end_date",EndDate);
dic.Add("page_size",PageSize);
dic.Add("page_number",PageNumber);
    
    var result = await PostAsync<GetAdCreativeReportApiResult>("pdd.ad.creative.report.get",dic);
    return result;
}
    }
}
