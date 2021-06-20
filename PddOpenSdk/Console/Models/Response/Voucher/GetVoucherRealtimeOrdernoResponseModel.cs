using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Voucher
{
public partial class GetVoucherRealtimeOrdernoResponseModel : PddResponseModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("response")]
public ResponseResponseModel Response {get;set;}
public partial class ResponseResponseModel : PddResponseModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("code")]
public int? Code {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("message")]
public string Message {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("result")]
public List<ResultResponseModel> Result {get;set;}
public partial class ResultResponseModel : PddResponseModel
{
/// <summary>
/// 外部订单号
/// </summary>
[JsonProperty("external_order_no")]
public string ExternalOrderNo {get;set;}
/// <summary>
/// 总可核销次数
/// </summary>
[JsonProperty("total_times")]
public int? TotalTimes {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("verify_list")]
public List<VerifyListResponseModel> VerifyList {get;set;}
public partial class VerifyListResponseModel : PddResponseModel
{
/// <summary>
/// 核销流水号
/// </summary>
[JsonProperty("verify_serial_no")]
public string VerifySerialNo {get;set;}
/// <summary>
/// 核销时间，13位时间戳
/// </summary>
[JsonProperty("verify_time")]
public long? VerifyTime {get;set;}
/// <summary>
/// 核销次数
/// </summary>
[JsonProperty("verify_times")]
public int? VerifyTimes {get;set;}

}

}

}

}

}
