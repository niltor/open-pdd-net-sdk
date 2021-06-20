using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Util
{
public partial class ReportOpenWaybillTypeRequestModel : PddRequestModel
{
/// <summary>
/// 订单号列表, 默认列表大小不超过100
/// </summary>
[JsonProperty("order_sn_list")]
public List<string> OrderSnList {get;set;}
/// <summary>
/// 面单类型(0-拼多多面单,1-友商平台面单,2-快递公司面单,99-其他)
/// </summary>
[JsonProperty("waybill_type")]
public int WaybillType {get;set;}

}

}
