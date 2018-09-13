using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class QuerySmsSendRecordListRequestModel : PddRequestModel
    {
        /// <summary>
/// 场景id,见前面枚举值用户关怀传[1,3]  ,智能营销[4, 5, 6, 8，9] 不传的话全部
/// </summary>
[JsonProperty("scene")]
public object Scene {get;set;}
/// <summary>
/// 开始时间 2018-08-09 15:20:12
/// </summary>
[JsonProperty("start_time")]
public object StartTime {get;set;}
/// <summary>
/// 结束时间 2018-08-09 15:20:12
/// </summary>
[JsonProperty("end_time")]
public object EndTime {get;set;}
/// <summary>
/// 1-成功 2-失败 全部-不传
/// </summary>
[JsonProperty("status")]
public int? Status {get;set;}
/// <summary>
/// 页码
/// </summary>
[JsonProperty("page_number")]
public int? PageNumber {get;set;}
/// <summary>
/// 每页数量
/// </summary>
[JsonProperty("page_size")]
public int? PageSize {get;set;}

}
}
