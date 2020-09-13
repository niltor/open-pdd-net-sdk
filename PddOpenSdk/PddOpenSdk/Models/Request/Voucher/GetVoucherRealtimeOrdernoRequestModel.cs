using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Voucher
{
public partial class GetVoucherRealtimeOrdernoRequestModel : PddRequestModel
{
/// <summary>
/// 请求体
/// </summary>
[JsonProperty("data")]
public DataRequestModel Data {get;set;}
public partial class DataRequestModel : PddRequestModel
{
/// <summary>
/// 拼多多订单号
/// </summary>
[JsonProperty("order_sn")]
public string OrderSn {get;set;}

}

}

}
