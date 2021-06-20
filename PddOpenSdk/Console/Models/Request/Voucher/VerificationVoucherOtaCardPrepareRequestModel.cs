using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Voucher
{
public partial class VerificationVoucherOtaCardPrepareRequestModel : PddRequestModel
{
/// <summary>
/// 请求体
/// </summary>
[JsonProperty("request")]
public RequestRequestModel Request {get;set;}
public partial class RequestRequestModel : PddRequestModel
{
/// <summary>
/// 卡密
/// </summary>
[JsonProperty("card_no")]
public string CardNo {get;set;}
/// <summary>
/// 门店id
/// </summary>
[JsonProperty("store_id")]
public long? StoreId {get;set;}

}

}

}
