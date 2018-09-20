using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class QuerySmsSellRecordListRequestModel : PddRequestModel
    {
        /// <summary>
/// 全部不传status; 待发送 status 1; 已发送 status2; 已取消 status3
/// </summary>
[JsonProperty("status")]
public int? Status {get;set;}
/// <summary>
/// //排序  1-升序 2-倒序
/// </summary>
[JsonProperty("order_by_send_time")]
public int? OrderBySendTime {get;set;}
/// <summary>
/// 页码数
/// </summary>
[JsonProperty("page_number")]
public int? PageNumber {get;set;}
/// <summary>
/// 单页条目数
/// </summary>
[JsonProperty("page_size")]
public int? PageSize {get;set;}

}
}
