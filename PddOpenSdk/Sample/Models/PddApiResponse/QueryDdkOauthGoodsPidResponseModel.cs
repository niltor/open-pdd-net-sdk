using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class QueryDdkOauthGoodsPidResponseModel : PddResponseModel
    {
        /// <summary>
/// 多多进宝推广位对象列表
/// </summary>
[JsonProperty("p_id_list")]
public object PIdList {get;set;}
/// <summary>
/// 返回推广位总数
/// </summary>
[JsonProperty("total_count")]
public int TotalCount {get;set;}
/// <summary>
/// 推广位生成时间
/// </summary>
[JsonProperty("create_time")]
public object CreateTime {get;set;}
/// <summary>
/// 推广位ID
/// </summary>
[JsonProperty("p_id")]
public object PId {get;set;}

    public partial class PIdListResponseModel : PddResponseModel
    {
        /// <summary>
/// 推广位生成时间
/// </summary>
[JsonProperty("create_time")]
public object CreateTime {get;set;}
/// <summary>
/// 推广位ID
/// </summary>
[JsonProperty("p_id")]
public object PId {get;set;}

}

}
}
