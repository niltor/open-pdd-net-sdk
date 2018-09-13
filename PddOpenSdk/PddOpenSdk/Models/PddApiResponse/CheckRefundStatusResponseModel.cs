using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class CheckRefundStatusResponseModel : PddResponseModel
    {
        /// <summary>
/// 存在售后的订单列表对象
/// </summary>
[JsonProperty("order_sns_exists_refund")]
public object OrderSnsExistsRefund {get;set;}
/// <summary>
/// 订单编号
/// </summary>
[JsonProperty("order_sn")]
public object OrderSn {get;set;}

    public partial class OrderSnsExistsRefundResponseModel : PddResponseModel
    {
        /// <summary>
/// 订单编号
/// </summary>
[JsonProperty("order_sn")]
public object OrderSn {get;set;}

}

}
}
