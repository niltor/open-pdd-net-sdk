using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class SendLogisticsOnlineRequestModel : PddRequestModel
    {
        /// <summary>
/// 该值为：pdd.logistics.online.send
/// </summary>
[JsonProperty("type")]
public object Type {get;set;}
/// <summary>
/// 20150909-452750051
/// </summary>
[JsonProperty("order_sn")]
public object OrderSn {get;set;}
/// <summary>
/// 快递公司编号
/// </summary>
[JsonProperty("logistics_id")]
public object LogisticsId {get;set;}
/// <summary>
/// 快递单号
/// </summary>
[JsonProperty("tracking_number")]
public object TrackingNumber {get;set;}
/// <summary>
/// 退货地址的id，不填则取商家默认地址
/// </summary>
[JsonProperty("refund_address_id")]
public int? RefundAddressId {get;set;}

}
}
