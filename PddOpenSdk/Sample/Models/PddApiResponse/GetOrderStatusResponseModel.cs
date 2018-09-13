using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GetOrderStatusResponseModel : PddResponseModel
    {
        /// <summary>
/// 订单状态列表对象
/// </summary>
[JsonProperty("order_status_list")]
public object OrderStatusList {get;set;}
/// <summary>
/// 订单编号
/// </summary>
[JsonProperty("orderSn")]
public object Ordersn {get;set;}
/// <summary>
/// 订单发货状态，1：待发货，2：已发货待签收，3：已签收 0：异常
/// </summary>
[JsonProperty("order_status")]
public object OrderStatus {get;set;}
/// <summary>
/// 订单售后状态，1：无售后或售后关闭，2：售后处理中，3：退款中，4：退款成功，0：异常
/// </summary>
[JsonProperty("refund_status")]
public object RefundStatus {get;set;}

    public partial class OrderStatusListResponseModel : PddResponseModel
    {
        /// <summary>
/// 订单编号
/// </summary>
[JsonProperty("orderSn")]
public object Ordersn {get;set;}
/// <summary>
/// 订单发货状态，1：待发货，2：已发货待签收，3：已签收 0：异常
/// </summary>
[JsonProperty("order_status")]
public object OrderStatus {get;set;}
/// <summary>
/// 订单售后状态，1：无售后或售后关闭，2：售后处理中，3：退款中，4：退款成功，0：异常
/// </summary>
[JsonProperty("refund_status")]
public object RefundStatus {get;set;}

}

}
}
