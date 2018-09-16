using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetDdkOrderListIncrementResponseModel : PddResponseModel
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
/// <summary>
/// 使用多多进宝券的面额（单位为分）
/// </summary>
[JsonProperty("duo_coupon_amount")]
public int DuoCouponAmount {get;set;}

    public partial class OrderListResponseModel : PddResponseModel
    {
        
}

}
}
