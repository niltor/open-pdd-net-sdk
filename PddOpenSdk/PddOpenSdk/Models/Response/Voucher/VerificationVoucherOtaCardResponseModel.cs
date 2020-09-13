using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Voucher
{
public partial class VerificationVoucherOtaCardResponseModel : PddResponseModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("voucher_ota_card_verification_response")]
public VoucherOtaCardVerificationResponseResponseModel VoucherOtaCardVerificationResponse {get;set;}
public partial class VoucherOtaCardVerificationResponseResponseModel : PddResponseModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("errorCode")]
public int? ErrorCode {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("errorMsg")]
public string ErrorMsg {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("result")]
public ResultResponseModel Result {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("success")]
public bool? Success {get;set;}
public partial class ResultResponseModel : PddResponseModel
{
/// <summary>
/// 券码
/// </summary>
[JsonProperty("card_no")]
public string CardNo {get;set;}
/// <summary>
/// 店铺编码
/// </summary>
[JsonProperty("mall_id")]
public long? MallId {get;set;}
/// <summary>
/// 订单号
/// </summary>
[JsonProperty("order_sn")]
public string OrderSn {get;set;}
/// <summary>
/// 核销状态（1-未核销，2-已核销， 3-已过期，4-已销毁，99-核销中）
/// </summary>
[JsonProperty("status")]
public int? Status {get;set;}
/// <summary>
/// 门店编码
/// </summary>
[JsonProperty("store_id")]
public long? StoreId {get;set;}
/// <summary>
/// 门店名称
/// </summary>
[JsonProperty("store_name")]
public string StoreName {get;set;}
/// <summary>
/// 核销时间（yyyy-MM-dd HH:mm:ss格式）
/// </summary>
[JsonProperty("verification_time")]
public string VerificationTime {get;set;}

}

}

}

}
