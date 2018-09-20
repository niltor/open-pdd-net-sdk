using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetOrderNumberListResponseModel : PddResponseModel
    {
        /// <summary>
/// 订单全量列表响应对象
/// </summary>
[JsonProperty("order_sn_list_get_response")]
public OrderSnListGetResponseResponseModel OrderSnListGetResponse {get;set;}

    public partial class OrderSnListGetResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 订单全量列表对象
/// </summary>
[JsonProperty("order_sn_list")]
public OrderSnListResponseModel OrderSnList {get;set;}
/// <summary>
/// 返回的订单总数，至多返回近90天的订单
/// </summary>
[JsonProperty("total_count")]
public int TotalCount {get;set;}

    public partial class OrderSnListResponseModel : PddResponseModel
    {
        /// <summary>
/// 订单编号
/// </summary>
[JsonProperty("order_sn")]
public string OrderSn {get;set;}

}

}

}
}
