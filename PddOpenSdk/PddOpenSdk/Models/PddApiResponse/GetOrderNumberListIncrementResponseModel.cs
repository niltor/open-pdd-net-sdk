using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetOrderNumberListIncrementResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回订单的总数
/// </summary>
[JsonProperty("total_count")]
public int TotalCount {get;set;}
/// <summary>
/// 订单列表对象
/// </summary>
[JsonProperty("order_sn_list")]
public object OrderSnList {get;set;}

    public partial class OrderSnListResponseModel : PddResponseModel
    {
        
}

}
}
