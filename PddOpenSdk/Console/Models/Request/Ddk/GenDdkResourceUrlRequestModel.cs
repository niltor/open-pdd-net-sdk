using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ddk
{
public partial class GenDdkResourceUrlRequestModel : PddRequestModel
{
/// <summary>
/// 自定义参数，为链接打上自定义标签；自定义参数最长限制64个字节；格式为： {"uid":"11111","sid":"22222"} ，其中 uid 用户唯一标识，可自行加密后传入，每个用户仅且对应一个标识，必填； sid 上下文信息标识，例如sessionId等，非必填。该json字符串中也可以加入其他自定义的key
/// </summary>
[JsonProperty("custom_parameters")]
public string CustomParameters {get;set;}
/// <summary>
/// 是否生成拼多多福利券微信小程序推广信息
/// </summary>
[JsonProperty("generate_we_app")]
public bool? GenerateWeApp {get;set;}
/// <summary>
/// 推广位
/// </summary>
[JsonProperty("pid")]
public string Pid {get;set;}
/// <summary>
/// 频道来源：4-限时秒杀,39997-充值中心, 39998-活动转链，39996-百亿补贴，39999-电器城，40000-领券中心，50005-火车票
/// </summary>
[JsonProperty("resource_type")]
public int? ResourceType {get;set;}
/// <summary>
/// 原链接
/// </summary>
[JsonProperty("url")]
public string Url {get;set;}

}

}
