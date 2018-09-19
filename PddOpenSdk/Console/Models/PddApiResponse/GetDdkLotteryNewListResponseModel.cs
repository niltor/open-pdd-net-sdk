using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetDdkLotteryNewListResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回列表
/// </summary>
[JsonProperty("list")]
public List<ListResponseModel> List {get;set;}
/// <summary>
/// 每页订单数量
/// </summary>
[JsonProperty("page_num")]
public object PageNum {get;set;}
/// <summary>
/// 分页数
/// </summary>
[JsonProperty("page_size")]
public object PageSize {get;set;}
/// <summary>
/// 返回总数量
/// </summary>
[JsonProperty("total_count")]
public object TotalCount {get;set;}

    public partial class ListResponseModel : PddResponseModel
    {
        
}

}
}
