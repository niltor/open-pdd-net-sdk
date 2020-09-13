using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Fds
{
public partial class CancelFdsWaybillRequestModel : PddRequestModel
{
/// <summary>
/// 入参信息
/// </summary>
[JsonProperty("pdd_fds_waybill_cancel_request")]
public PddFdsWaybillCancelRequestRequestModel PddFdsWaybillCancelRequest {get;set;}
public partial class PddFdsWaybillCancelRequestRequestModel : PddRequestModel
{
/// <summary>
/// 代打店铺id
/// </summary>
[JsonProperty("mall_mask_id")]
public string MallMaskId {get;set;}
/// <summary>
/// 代打订单号
/// </summary>
[JsonProperty("order_mask_sn")]
public string OrderMaskSn {get;set;}
/// <summary>
/// 面单号
/// </summary>
[JsonProperty("waybill_code")]
public string WaybillCode {get;set;}
/// <summary>
/// 物流公司 Code ，枚举： YTO- 圆通，ZTO-中通，YUNDA-韵达，STO-申通
/// </summary>
[JsonProperty("wp_code")]
public string WpCode {get;set;}

}

}

}
