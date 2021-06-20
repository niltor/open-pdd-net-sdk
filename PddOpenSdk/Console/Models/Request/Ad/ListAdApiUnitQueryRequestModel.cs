using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ad
{
public partial class ListAdApiUnitQueryRequestModel : PddRequestModel
{
/// <summary>
/// 报表数据开始日期
/// </summary>
[JsonProperty("beginDate")]
public string BeginDate {get;set;}
/// <summary>
/// 报表数据截止日期
/// </summary>
[JsonProperty("endDate")]
public string EndDate {get;set;}
/// <summary>
/// 排序字段。0表示按曝光量排序，1表示按点击量排序，2表示按点击率排序，3表示按点击单价排序，4表示按消耗排序，5表示按订单数排序，6表示按交易额排序，7表示按产出比排序，8表示按日期排序，9表示按千次曝光单价排序，10表示按店铺收藏数排序，11表示按商品收藏数排序，12表示按点击转化率排序，13表示按转化成本排序，14表示按平均成交金额排序。
/// </summary>
[JsonProperty("orderBy")]
public int? OrderBy {get;set;}
/// <summary>
/// 广告计划ID。
/// </summary>
[JsonProperty("planId")]
public long PlanId {get;set;}
/// <summary>
/// 场景类型。0表示搜索，2表示展示。
/// </summary>
[JsonProperty("scenesType")]
public int ScenesType {get;set;}
/// <summary>
/// 排序类型。0表示降序，1表示升序。
/// </summary>
[JsonProperty("sortBy")]
public int? SortBy {get;set;}

}

}
