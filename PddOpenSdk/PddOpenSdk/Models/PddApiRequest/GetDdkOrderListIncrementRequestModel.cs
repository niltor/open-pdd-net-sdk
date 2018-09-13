using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class GetDdkOrderListIncrementRequestModel : PddRequestModel
    {
        /// <summary>
/// 该值为:pdd.ddk.order.list.increment.get
/// </summary>
[JsonProperty("type")]
public object Type {get;set;}
/// <summary>
/// 最近90天内多多进宝商品订单更新时间--查询时间开始。note：此时间为时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数
/// </summary>
[JsonProperty("start_update_time")]
public int StartUpdateTime {get;set;}
/// <summary>
/// 最近90天内多多进宝商品订单更新时间--查询时间结束。note：此时间为时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数
/// </summary>
[JsonProperty("end_update_time")]
public object EndUpdateTime {get;set;}
/// <summary>
/// 推广位ID
/// </summary>
[JsonProperty("p_id")]
public object PId {get;set;}
/// <summary>
/// 返回的每页结果订单数，默认为100，范围为10到100，建议使用40~50，可以提高成功率，减少超时数量。
/// </summary>
[JsonProperty("page_size")]
public int? PageSize {get;set;}
/// <summary>
/// 第几页，从1到10000，默认1，注：使用最后更新时间范围增量同步时，必须采用倒序的分页方式（从最后一页往回取）才能避免漏单问题。
/// </summary>
[JsonProperty("page")]
public int? Page {get;set;}

}
}
