using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Order
{
public partial class SyncErpOrderRequestModel : PddRequestModel
{
/// <summary>
/// 物流公司编码
/// </summary>
[JsonProperty("logistics_id")]
public long LogisticsId {get;set;}
/// <summary>
/// 订单号
/// </summary>
[JsonProperty("order_sn")]
public string OrderSn {get;set;}
/// <summary>
/// 订单状态：1-已打单
/// </summary>
[JsonProperty("order_state")]
public int OrderState {get;set;}
/// <summary>
/// 运单号
/// </summary>
[JsonProperty("waybill_no")]
public string WaybillNo {get;set;}

}

}
