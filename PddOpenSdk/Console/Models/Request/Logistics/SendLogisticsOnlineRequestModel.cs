using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Logistics
{
public partial class SendLogisticsOnlineRequestModel : PddRequestModel
{
/// <summary>
/// 20150909-452750051
/// </summary>
[JsonProperty("order_sn")]
public string OrderSn {get;set;}
/// <summary>
/// 快递公司编号
/// </summary>
[JsonProperty("logistics_id")]
public long LogisticsId {get;set;}
/// <summary>
/// 快递单号
/// </summary>
[JsonProperty("tracking_number")]
public string TrackingNumber {get;set;}
/// <summary>
/// 退货地址的id，不填则取商家默认地址
/// </summary>
[JsonProperty("refund_address_id")]
public string RefundAddressId {get;set;}

}

}
