using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class QueryDdkGoodsPidRequestModel : PddRequestModel
    {
        /// <summary>
/// 该值为：pdd.ddk.goods.pid.query
/// </summary>
[JsonProperty("type")]
public string Type {get;set;}
/// <summary>
/// 返回的页数
/// </summary>
[JsonProperty("page")]
public int? Page {get;set;}
/// <summary>
/// 返回的每页推广位数量
/// </summary>
[JsonProperty("page_size")]
public int? PageSize {get;set;}

}
}
