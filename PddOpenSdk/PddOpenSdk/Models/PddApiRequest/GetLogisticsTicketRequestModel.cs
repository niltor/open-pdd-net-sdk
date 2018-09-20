using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class GetLogisticsTicketRequestModel : PddRequestModel
    {
        /// <summary>
/// 必填，最后更新时间开始时间的时间戳，指格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数。示例：1523762012。
/// </summary>
[JsonProperty("start_updated_at")]
public int StartUpdatedAt {get;set;}
/// <summary>
/// 必填，最后更新时间结束时间的时间戳，指格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数 PS：开始时间结束时间间距不超过 30 分钟。示例：1523763012。
/// </summary>
[JsonProperty("end_updated_at")]
public int EndUpdatedAt {get;set;}
/// <summary>
/// 返回页码 默认 1，页码从 1 开始 PS：当前采用分页返回，数量和页数会一起传，如果不传，则采用 默认值。注：必须采用倒序的分页方式（从最后一页往回取）才能避免漏单问题
/// </summary>
[JsonProperty("page")]
public int? Page {get;set;}
/// <summary>
/// 返回数量，默认 100。最大 100
/// </summary>
[JsonProperty("page_size")]
public int? PageSize {get;set;}

}
}
