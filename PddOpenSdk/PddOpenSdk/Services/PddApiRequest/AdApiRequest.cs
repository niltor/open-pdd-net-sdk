namespace PddOpenSdk.Services.PddApiRequest
{
    public class ad extends Request {
        /// <summary>
/// 获取关键词推广报表信息
/// </summary>
/// <param name="Type">该值为：pdd.ad.chart.bykeyword.get</param>
/// <param name="Date">报表日期，仅能查询近30天的报表数据，格式为：YYYY-MM-DD</param>
/// <param name="Page">返回页数，默认1页</param>
/// <param name="PageSize">每页返回条数，默认20条</param>
public async Task<GetAdChartBykeywordApiResult> GetAdChartBykeywordAsync(string Type,string Date,number Page,number PageSize)
{
    var dic = new Dictionary<string, string>();
    dic.Add("type",Type);
dic.Add("date",Date);
dic.Add("page",Page);
dic.Add("page_size",Page Size);
    
    var result = Post<GetAdChartBykeywordApiResult>(pdd.ad.chart.bykeyword.get,);
    return JsonConvert.DeserializeObject<GetAdChartBykeywordApiResult>(result);
}/// <summary>
/// 系统推荐关键词
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="GoodsId">商品id</param>
public async Task<GetAdKeywordRcommendedApiResult> GetAdKeywordRcommendedAsync(number SceneType,number GoodsId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("scene_type",Scene Type);
dic.Add("goods_id",Goods Id);
    
    var result = Post<GetAdKeywordRcommendedApiResult>(pdd.ad.keyword.rcommended.get,);
    return JsonConvert.DeserializeObject<GetAdKeywordRcommendedApiResult>(result);
}/// <summary>
/// 关键词商品相关性
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="Words">["test"]</param>
/// <param name="GoodsId">商品id</param>
public async Task<GetAdKeywordRelevanceApiResult> GetAdKeywordRelevanceAsync(number SceneType,string Words,number GoodsId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("scene_type",Scene Type);
dic.Add("words",Words);
dic.Add("goods_id",Goods Id);
    
    var result = Post<GetAdKeywordRelevanceApiResult>(pdd.ad.keyword.relevance.get,);
    return JsonConvert.DeserializeObject<GetAdKeywordRelevanceApiResult>(result);
}/// <summary>
/// 推广单元修改关键词出价
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="Keywords"></param>
/// <param name="Bid">关键字出价（厘）范围需在0.10~99.0元区间内</param>
/// <param name="KeywordId">关键词id</param>
public async Task<UpdateAdKeywordApiResult> UpdateAdKeywordAsync(number SceneType,string Keywords,number Bid,number KeywordId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("scene_type",Scene Type);
dic.Add("keywords",Keywords);
dic.Add("bid",Bid);
dic.Add("keyword_id",Keyword Id);
    
    var result = Post<UpdateAdKeywordApiResult>(pdd.ad.keyword.update,);
    return JsonConvert.DeserializeObject<UpdateAdKeywordApiResult>(result);
}/// <summary>
/// 推广单元删除关键词
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="KeywordIds">keyword_id列表，[1,2]</param>
public async Task<DeleteAdKeywordApiResult> DeleteAdKeywordAsync(number SceneType,string KeywordIds)
{
    var dic = new Dictionary<string, string>();
    dic.Add("scene_type",Scene Type);
dic.Add("keyword_ids",Keyword Ids);
    
    var result = Post<DeleteAdKeywordApiResult>(pdd.ad.keyword.delete,);
    return JsonConvert.DeserializeObject<DeleteAdKeywordApiResult>(result);
}/// <summary>
/// 推广单元添加关键词
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="UnitId">计划id</param>
/// <param name="Keywords">[{"word":"test","bid":200}]</param>
/// <param name="Bid">关键字出价（厘）范围需在0.10~99.0元区间内</param>
/// <param name="Word">关键词</param>
public async Task<CreateAdKeywordApiResult> CreateAdKeywordAsync(number SceneType,number UnitId,string Keywords,number Bid,string Word)
{
    var dic = new Dictionary<string, string>();
    dic.Add("scene_type",Scene Type);
dic.Add("unit_id",Unit Id);
dic.Add("keywords",Keywords);
dic.Add("bid",Bid);
dic.Add("word",Word);
    
    var result = Post<CreateAdKeywordApiResult>(pdd.ad.keyword.create,);
    return JsonConvert.DeserializeObject<CreateAdKeywordApiResult>(result);
}/// <summary>
/// 删除推广单元-批量
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="UnitIds">unit_id列表，[1,2]</param>
public async Task<DeleteAdUnitApiResult> DeleteAdUnitAsync(number SceneType,string UnitIds)
{
    var dic = new Dictionary<string, string>();
    dic.Add("scene_type",Scene Type);
dic.Add("unit_ids",Unit Ids);
    
    var result = Post<DeleteAdUnitApiResult>(pdd.ad.unit.delete,);
    return JsonConvert.DeserializeObject<DeleteAdUnitApiResult>(result);
}/// <summary>
/// 添加推广单元
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="PlanId">计划id</param>
/// <param name="GoodsId">商品id</param>
/// <param name="Keywords">[{"word":"test","bid":200}]</param>
/// <param name="Bid">关键字出价（厘）范围需在0.10~99.0元区间内</param>
/// <param name="Word">关键词</param>
public async Task<CreateAdUnitApiResult> CreateAdUnitAsync(number SceneType,string PlanId,number GoodsId,string Keywords,number Bid,string Word)
{
    var dic = new Dictionary<string, string>();
    dic.Add("scene_type",Scene Type);
dic.Add("plan_id",Plan Id);
dic.Add("goods_id",Goods Id);
dic.Add("keywords",Keywords);
dic.Add("bid",Bid);
dic.Add("word",Word);
    
    var result = Post<CreateAdUnitApiResult>(pdd.ad.unit.create,);
    return JsonConvert.DeserializeObject<CreateAdUnitApiResult>(result);
}/// <summary>
/// 暂停、开启推广单元
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="UnitIds">unit_id列表，[1,2]</param>
/// <param name="OptStatus">1 已启用,2 已暂停</param>
public async Task<UpdateAdUnitOptStatusApiResult> UpdateAdUnitOptStatusAsync(number SceneType,string UnitIds,number OptStatus)
{
    var dic = new Dictionary<string, string>();
    dic.Add("scene_type",Scene Type);
dic.Add("unit_ids",Unit Ids);
dic.Add("opt_status",Opt Status);
    
    var result = Post<UpdateAdUnitOptStatusApiResult>(pdd.ad.unit.opt.status.update,);
    return JsonConvert.DeserializeObject<UpdateAdUnitOptStatusApiResult>(result);
}/// <summary>
/// 根据计划id获取推广单元基本信息
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="PlanId">计划id</param>
public async Task<IdAdUnitGetByPlanApiResult> IdAdUnitGetByPlanAsync(number SceneType,string PlanId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("scene_type",Scene Type);
dic.Add("plan_id",Plan Id);
    
    var result = Post<IdAdUnitGetByPlanApiResult>(pdd.ad.unit.get.by.plan.id,);
    return JsonConvert.DeserializeObject<IdAdUnitGetByPlanApiResult>(result);
}/// <summary>
/// 修改推广计划状态（暂停、开启）
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="PlanId">计划id</param>
/// <param name="OptStatus">1 已启用,2 已暂停</param>
public async Task<UpdateAdPlanOptStatusApiResult> UpdateAdPlanOptStatusAsync(number SceneType,string PlanId,number OptStatus)
{
    var dic = new Dictionary<string, string>();
    dic.Add("scene_type",Scene Type);
dic.Add("plan_id",Plan Id);
dic.Add("opt_status",Opt Status);
    
    var result = Post<UpdateAdPlanOptStatusApiResult>(pdd.ad.plan.opt.status.update,);
    return JsonConvert.DeserializeObject<UpdateAdPlanOptStatusApiResult>(result);
}/// <summary>
/// 修改推广计划日限额
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="PlanId">计划id</param>
/// <param name="MaxCost">计划日限额，单位厘</param>
public async Task<UpdateAdPlanMaxCostApiResult> UpdateAdPlanMaxCostAsync(number SceneType,string PlanId,number MaxCost)
{
    var dic = new Dictionary<string, string>();
    dic.Add("scene_type",Scene Type);
dic.Add("plan_id",Plan Id);
dic.Add("max_cost",Max Cost);
    
    var result = Post<UpdateAdPlanMaxCostApiResult>(pdd.ad.plan.max.cost.update,);
    return JsonConvert.DeserializeObject<UpdateAdPlanMaxCostApiResult>(result);
}/// <summary>
/// 修改推广计划名称
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="PlanId">计划id</param>
/// <param name="PlanName">计划名</param>
public async Task<UpdateAdPlanNameApiResult> UpdateAdPlanNameAsync(number SceneType,string PlanId,string PlanName)
{
    var dic = new Dictionary<string, string>();
    dic.Add("scene_type",Scene Type);
dic.Add("plan_id",Plan Id);
dic.Add("plan_name",Plan Name);
    
    var result = Post<UpdateAdPlanNameApiResult>(pdd.ad.plan.name.update,);
    return JsonConvert.DeserializeObject<UpdateAdPlanNameApiResult>(result);
}/// <summary>
/// 删除推广计划
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="PlanIds">plan_id 列表，示例：[1,2]</param>
public async Task<DeleteAdPlanApiResult> DeleteAdPlanAsync(number SceneType,string PlanIds)
{
    var dic = new Dictionary<string, string>();
    dic.Add("scene_type",Scene Type);
dic.Add("plan_ids",Plan Ids);
    
    var result = Post<DeleteAdPlanApiResult>(pdd.ad.plan.delete,);
    return JsonConvert.DeserializeObject<DeleteAdPlanApiResult>(result);
}/// <summary>
/// 新建推广计划
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="PlanName">计划名</param>
/// <param name="MaxCost">单日消耗，单位厘;上限不能超过1000000元，单日消耗上限不能低于100元</param>
public async Task<CreateAdPlanApiResult> CreateAdPlanAsync(number SceneType,string PlanName,number MaxCost)
{
    var dic = new Dictionary<string, string>();
    dic.Add("scene_type",Scene Type);
dic.Add("plan_name",Plan Name);
dic.Add("max_cost",Max Cost);
    
    var result = Post<CreateAdPlanApiResult>(pdd.ad.plan.create,);
    return JsonConvert.DeserializeObject<CreateAdPlanApiResult>(result);
}/// <summary>
/// 关键词实时报表数据
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="UnitId">单元id</param>
public async Task<GetAdHistoryRtKeywordReportApiResult> GetAdHistoryRtKeywordReportAsync(number SceneType,number UnitId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("scene_type",Scene Type);
dic.Add("unit_id",Unit Id);
    
    var result = Post<GetAdHistoryRtKeywordReportApiResult>(pdd.ad.history.rt.keyword.report.get,);
    return JsonConvert.DeserializeObject<GetAdHistoryRtKeywordReportApiResult>(result);
}/// <summary>
/// 推广单元实时报表数据
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="PlanId">计划id</param>
public async Task<GetAdHistoryRtUnitReportApiResult> GetAdHistoryRtUnitReportAsync(number SceneType,number PlanId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("scene_type",Scene Type);
dic.Add("plan_id",Plan Id);
    
    var result = Post<GetAdHistoryRtUnitReportApiResult>(pdd.ad.history.rt.unit.report.get,);
    return JsonConvert.DeserializeObject<GetAdHistoryRtUnitReportApiResult>(result);
}/// <summary>
/// 推广计划实时报表数据
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
public async Task<GetAdHistoryRtPlanReportApiResult> GetAdHistoryRtPlanReportAsync(number SceneType)
{
    var dic = new Dictionary<string, string>();
    dic.Add("scene_type",Scene Type);
    
    var result = Post<GetAdHistoryRtPlanReportApiResult>(pdd.ad.history.rt.plan.report.get,);
    return JsonConvert.DeserializeObject<GetAdHistoryRtPlanReportApiResult>(result);
}/// <summary>
/// 账户推广实时报表数据
/// </summary>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
public async Task<GetAdHistoryRtReportApiResult> GetAdHistoryRtReportAsync(number SceneType)
{
    var dic = new Dictionary<string, string>();
    dic.Add("scene_type",Scene Type);
    
    var result = Post<GetAdHistoryRtReportApiResult>(pdd.ad.history.rt.report.get,);
    return JsonConvert.DeserializeObject<GetAdHistoryRtReportApiResult>(result);
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
public async Task<GetAdHistoryKeywordReportApiResult> GetAdHistoryKeywordReportAsync(string BeginDate,string EndDate,number SceneType,number GroupBy,number OrderBy,number SortBy,number Page,number PageSize,number UnitId,string Keyword,number PlanId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("begin_date",Begin Date);
dic.Add("end_date",End Date);
dic.Add("scene_type",Scene Type);
dic.Add("group_by",Group By);
dic.Add("order_by",Order By);
dic.Add("sort_by",Sort By);
dic.Add("page",Page);
dic.Add("page_size",Page Size);
dic.Add("unit_id",Unit Id);
dic.Add("keyword",Keyword);
dic.Add("plan_id",Plan Id);
    
    var result = Post<GetAdHistoryKeywordReportApiResult>(pdd.ad.history.keyword.report.get,);
    return JsonConvert.DeserializeObject<GetAdHistoryKeywordReportApiResult>(result);
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
public async Task<GetAdHistoryUnitReportApiResult> GetAdHistoryUnitReportAsync(string BeginDate,string EndDate,number SceneType,number GroupBy,number OrderBy,number SortBy,number Page,number PageSize,number UnitId,number PlanId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("begin_date",Begin Date);
dic.Add("end_date",End Date);
dic.Add("scene_type",Scene Type);
dic.Add("group_by",Group By);
dic.Add("order_by",Order By);
dic.Add("sort_by",Sort By);
dic.Add("page",Page);
dic.Add("page_size",Page Size);
dic.Add("unit_id",Unit Id);
dic.Add("plan_Id",Plan Id);
    
    var result = Post<GetAdHistoryUnitReportApiResult>(pdd.ad.history.unit.report.get,);
    return JsonConvert.DeserializeObject<GetAdHistoryUnitReportApiResult>(result);
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
public async Task<GetAdHistoryPlanReportApiResult> GetAdHistoryPlanReportAsync(string BeginDate,string EndDate,number SceneType,number GroupBy,number OrderBy,number SortBy,number Page,number PageSize,number PlanId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("begin_date",Begin Date);
dic.Add("end_date",End Date);
dic.Add("scene_type",Scene Type);
dic.Add("group_by",Group By);
dic.Add("order_by",Order By);
dic.Add("sort_by",Sort By);
dic.Add("page",Page);
dic.Add("page_size",Page Size);
dic.Add("plan_id",Plan Id);
    
    var result = Post<GetAdHistoryPlanReportApiResult>(pdd.ad.history.plan.report.get,);
    return JsonConvert.DeserializeObject<GetAdHistoryPlanReportApiResult>(result);
}/// <summary>
/// 账户推广历史报表数据
/// </summary>
/// <param name="BeginDate">开始时间：2018-05-01（周期不超过一个月，记录保存最近30天）</param>
/// <param name="EndDate">结束时间：2018-05-02（周期不超过一个月，记录保存最近30天）</param>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）</param>
/// <param name="OrderBy">0--曝光量排序,1--点击量排序,2--点击率,3--点击单价排序,4--消耗排序,5--订单数排序,6--交易额排序,7--产出比排序,8--日期;默认8</param>
/// <param name="SortBy">0--降序,1--升序;默认0</param>
public async Task<GetAdHistoryReportApiResult> GetAdHistoryReportAsync(string BeginDate,string EndDate,number SceneType,number OrderBy,number SortBy)
{
    var dic = new Dictionary<string, string>();
    dic.Add("begin_date",Begin Date);
dic.Add("end_date",End Date);
dic.Add("scene_type",Scene Type);
dic.Add("order_by",Order By);
dic.Add("sort_by",Sort By);
    
    var result = Post<GetAdHistoryReportApiResult>(pdd.ad.history.report.get,);
    return JsonConvert.DeserializeObject<GetAdHistoryReportApiResult>(result);
}/// <summary>
/// 是否可以创建计划验证接口
/// </summary>
/// <param name="PlanName">计划名</param>
/// <param name="SceneType">0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告</param>
public async Task<PlanAdCanCreateApiResult> PlanAdCanCreateAsync(string PlanName,number SceneType)
{
    var dic = new Dictionary<string, string>();
    dic.Add("plan_name",Plan Name);
dic.Add("scene_type",Scene Type);
    
    var result = Post<PlanAdCanCreateApiResult>(pdd.ad.can.create.plan,);
    return JsonConvert.DeserializeObject<PlanAdCanCreateApiResult>(result);
}/// <summary>
/// 创意日报报表
/// </summary>
/// <param name="BeginDate">开始时间 2018-01-01</param>
/// <param name="EndDate">结束时间 2018-01-01</param>
/// <param name="PageSize">页面大小,默认100</param>
/// <param name="PageNumber">页面数,默认1</param>
public async Task<GetAdCreativeReportApiResult> GetAdCreativeReportAsync(string BeginDate,string EndDate,number PageSize,number PageNumber)
{
    var dic = new Dictionary<string, string>();
    dic.Add("begin_date",Begin Date);
dic.Add("end_date",End Date);
dic.Add("page_size",Page Size);
dic.Add("page_number",Page Number);
    
    var result = Post<GetAdCreativeReportApiResult>(pdd.ad.creative.report.get,);
    return JsonConvert.DeserializeObject<GetAdCreativeReportApiResult>(result);
}
    }
}
