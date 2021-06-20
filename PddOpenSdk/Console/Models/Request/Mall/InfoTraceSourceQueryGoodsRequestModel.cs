using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Mall
{
public partial class InfoTraceSourceQueryGoodsRequestModel : PddRequestModel
{
/// <summary>
/// 请求方法
/// </summary>
[JsonProperty("httpMethod")]
public string HttpMethod {get;set;}
/// <summary>
/// 请求参数
/// </summary>
[JsonProperty("params")]
public ParamsRequestModel Params {get;set;}
public partial class ParamsRequestModel : PddRequestModel
{
/// <summary>
/// 接口调用账号（由平台分配）
/// </summary>
[JsonProperty("userid")]
public string Userid {get;set;}
/// <summary>
/// 请求时间戳，10分钟有效，格式：yyyy-MM-dd HH:mm:ss
/// </summary>
[JsonProperty("timestamp")]
public string Timestamp {get;set;}
/// <summary>
/// 签名
/// </summary>
[JsonProperty("sign")]
public string Sign {get;set;}
/// <summary>
/// 防伪溯源码ID
/// </summary>
[JsonProperty("id")]
public string Id {get;set;}

}

}

}
