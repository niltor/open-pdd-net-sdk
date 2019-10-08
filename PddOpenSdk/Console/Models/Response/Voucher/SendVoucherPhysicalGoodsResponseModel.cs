using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Voucher
{
public partial class SendVoucherPhysicalGoodsResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("voucher_physical_voucher_send_response")]
public VoucherPhysicalVoucherSendResponseResponseModel VoucherPhysicalVoucherSendResponse {get;set;}
public partial class VoucherPhysicalVoucherSendResponseResponseModel : PddResponseModel
{
/// <summary>
/// 请求成功
/// </summary>
[JsonProperty("is_success")]
public bool? IsSuccess {get;set;}

}

}

}
