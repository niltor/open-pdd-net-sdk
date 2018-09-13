using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class SyncErpOrderRequestModel : PddRequestModel
    {
        /// <summary>
/// 订单号
/// </summary>
[JsonProperty("order_sn")]
public String OrderSn {get;set;}
/// <summary>
/// 订单状态：1-已打单
/// </summary>
[JsonProperty("order_state")]
public Integer OrderState {get;set;}
/// <summary>
/// 运单号
/// </summary>
[JsonProperty("waybill_no")]
public String WaybillNo {get;set;}
/// <summary>
/// 物流公司编码
/// </summary>
[JsonProperty("logistics_id")]
public Integer LogisticsId {get;set;}
}
}

