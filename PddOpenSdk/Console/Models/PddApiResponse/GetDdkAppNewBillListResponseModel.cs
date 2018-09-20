using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetDdkAppNewBillListResponseModel : PddResponseModel
    {
        /// <summary>
/// 多多客拉新的奖励账单返回对象
/// </summary>
[JsonProperty("app_new_bill_list_response")]
public AppNewBillListResponseResponseModel AppNewBillListResponse {get;set;}

    public partial class AppNewBillListResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 账单列表对象
/// </summary>
[JsonProperty("list")]
public ListResponseModel List {get;set;}
/// <summary>
/// 账单总数
/// </summary>
[JsonProperty("total_count")]
public int TotalCount {get;set;}

    public partial class ListResponseModel : PddResponseModel
    {
        
}

}

}
}
