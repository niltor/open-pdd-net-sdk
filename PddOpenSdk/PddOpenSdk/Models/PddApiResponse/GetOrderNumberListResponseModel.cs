using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GetOrderNumberListResponseModel : PddResponseModel
    {
        /// <summary>
/// 订单全量列表响应对象
/// </summary>
[JsonProperty("order_sn_list_get_response")]
public object OrderSnListGetResponse {get;set;}
/// <summary>
/// 订单全量列表对象
/// </summary>
[JsonProperty("order_sn_list")]
public object OrderSnList {get;set;}
/// <summary>
/// 返回的订单总数，至多返回近90天的订单
/// </summary>
[JsonProperty("total_count")]
public int TotalCount {get;set;}
/// <summary>
/// 订单编号
/// </summary>
[JsonProperty("order_sn")]
public object OrderSn {get;set;}

    public partial class OrderSnListGetResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 订单全量列表对象
/// </summary>
[JsonProperty("order_sn_list")]
public object OrderSnList {get;set;}
/// <summary>
/// 返回的订单总数，至多返回近90天的订单
/// </summary>
[JsonProperty("total_count")]
public int TotalCount {get;set;}

}

    public partial class OrderSnListResponseModel : PddResponseModel
    {
        /// <summary>
/// 订单编号
/// </summary>
[JsonProperty("order_sn")]
public object OrderSn {get;set;}

}

}
}
