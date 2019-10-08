using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ad
{
public partial class GetAdHistoryKeywordReportRequestModel : PddRequestModel
{
/// <summary>
/// 开始时间：2018-05-01（周期不超过一个月，记录保存最近30天）
/// </summary>
[JsonProperty("begin_date")]
public string BeginDate {get;set;}
/// <summary>
/// 结束时间：2018-05-02（周期不超过一个月，记录保存最近30天）
/// </summary>
[JsonProperty("end_date")]
public string EndDate {get;set;}
/// <summary>
/// 0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）
/// </summary>
[JsonProperty("scene_type")]
public int SceneType {get;set;}
/// <summary>
/// 0--曝光量排序,1--点击量排序,2--点击率,3--点击单价排序,4--消耗排序,5--订单数排序,6--交易额排序,7--产出比排序,8--日期,9--千次曝光单价;默认8
/// </summary>
[JsonProperty("order_by")]
public int? OrderBy {get;set;}
/// <summary>
/// 0--降序,1--升序;默认0
/// </summary>
[JsonProperty("sort_by")]
public int? SortBy {get;set;}
/// <summary>
/// 1--按日期分组,2--按关键词id分组
/// </summary>
[JsonProperty("group_by")]
public int GroupBy {get;set;}
/// <summary>
/// 页码，默认1，当group_by=2时才生效
/// </summary>
[JsonProperty("page")]
public int? Page {get;set;}
/// <summary>
/// 每页数量，默认100，当group_by=2时才生效
/// </summary>
[JsonProperty("page_size")]
public int? PageSize {get;set;}
/// <summary>
/// 单元id，groupBy = 1时必须传值，groupBy = 2时可以传值
/// </summary>
[JsonProperty("unit_id")]
public long? UnitId {get;set;}
/// <summary>
/// 关键词，仅当groupBy = 1时必须传值
/// </summary>
[JsonProperty("keyword")]
public string Keyword {get;set;}
/// <summary>
/// 计划id，仅当groupBy = 2时可以传值
/// </summary>
[JsonProperty("plan_id")]
public long? PlanId {get;set;}

}

}
