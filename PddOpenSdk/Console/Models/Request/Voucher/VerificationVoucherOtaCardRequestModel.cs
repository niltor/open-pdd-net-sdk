using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Voucher
{
public partial class VerificationVoucherOtaCardRequestModel : PddRequestModel
{
/// <summary>
/// 待核销的券码
/// </summary>
[JsonProperty("card_no")]
public string CardNo {get;set;}
/// <summary>
/// 核销门店id
/// </summary>
[JsonProperty("store_id")]
public long StoreId {get;set;}
/// <summary>
/// 核销门店名称
/// </summary>
[JsonProperty("store_name")]
public string StoreName {get;set;}
/// <summary>
/// 拼多多订单编号
/// </summary>
[JsonProperty("order_sn")]
public string OrderSn {get;set;}

}

}
