using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.WayBill
{
public partial class CancelWaybillResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("pdd_waybill_cancel_response")]
public PddWaybillCancelResponseResponseModel PddWaybillCancelResponse {get;set;}
public partial class PddWaybillCancelResponseResponseModel : PddResponseModel
{
/// <summary>
/// 调用取消是否成功
/// </summary>
[JsonProperty("cancel_result")]
public bool? CancelResult {get;set;}

}

}

}
