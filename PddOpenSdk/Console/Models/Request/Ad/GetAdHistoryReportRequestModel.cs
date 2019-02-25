using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ad
{
public partial class GetAdHistoryReportRequestModel : PddRequestModel
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
/// 0--曝光量排序,1--点击量排序,2--点击率,3--点击单价排序,4--消耗排序,5--订单数排序,6--交易额排序,7--产出比排序,8--日期;默认8
/// </summary>
[JsonProperty("order_by")]
public int? OrderBy {get;set;}
/// <summary>
/// 0--降序,1--升序;默认0
/// </summary>
[JsonProperty("sort_by")]
public int? SortBy {get;set;}

}

}
