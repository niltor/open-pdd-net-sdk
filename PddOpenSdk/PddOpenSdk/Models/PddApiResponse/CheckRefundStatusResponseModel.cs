using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class CheckRefundStatusResponseModel : PddResponseModel
    {
        /// <summary>
/// 存在售后的订单列表对象
/// </summary>
[JsonProperty("order_sns_exists_refund")]
public OrderSnsExistsRefundResponseModel OrderSnsExistsRefund {get;set;}

    public partial class OrderSnsExistsRefundResponseModel : PddResponseModel
    {
        /// <summary>
/// 订单编号
/// </summary>
[JsonProperty("order_sn")]
public string OrderSn {get;set;}

}

}
}
