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
public object AppNewBillListResponse {get;set;}

    public partial class AppNewBillListResponseResponseModel : PddResponseModel
    {
        
}

}
}
