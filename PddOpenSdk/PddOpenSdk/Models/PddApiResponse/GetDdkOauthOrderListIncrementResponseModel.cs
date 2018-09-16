using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetDdkOauthOrderListIncrementResponseModel : PddResponseModel
    {
        /// <summary>
/// 多多进宝推广位对象列表
/// </summary>
[JsonProperty("order_list")]
public object OrderList {get;set;}
/// <summary>
/// 请求到的结果数
/// </summary>
[JsonProperty("total_count")]
public object TotalCount {get;set;}

    public partial class OrderListResponseModel : PddResponseModel
    {
        
}

}
}
