using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Oversea
{
public partial class GetOverseaClearanceResponseModel : PddResponseModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("clearance_response")]
public ClearanceResponseResponseModel ClearanceResponse {get;set;}
public partial class ClearanceResponseResponseModel : PddResponseModel
{
/// <summary>
/// 身份证姓名
/// </summary>
[JsonProperty("id_card_name")]
public string IdCardName {get;set;}
/// <summary>
/// 身份证号
/// </summary>
[JsonProperty("id_card_no")]
public string IdCardNo {get;set;}
/// <summary>
/// 支付申报订单号
/// </summary>
[JsonProperty("inner_transaction_id")]
public string InnerTransactionId {get;set;}
/// <summary>
/// 支付单号
/// </summary>
[JsonProperty("pay_no")]
public string PayNo {get;set;}
/// <summary>
/// 支付方式，枚举值：WEIXIN,ALIPAY,DUODUOPAY
/// </summary>
[JsonProperty("pay_type")]
public string PayType {get;set;}
/// <summary>
/// 订单号
/// </summary>
[JsonProperty("order_sn")]
public string OrderSn {get;set;}

}

}

}
