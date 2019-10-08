using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ddk
{
public partial class GenDdkResourceUrlRequestModel : PddRequestModel
{
/// <summary>
/// 自定义参数，为链接打上自定义标签。自定义参数最长限制64个字节
/// </summary>
[JsonProperty("custom_parameters")]
public string CustomParameters {get;set;}
/// <summary>
/// 是否生成小程序
/// </summary>
[JsonProperty("generate_we_app")]
public bool? GenerateWeApp {get;set;}
/// <summary>
/// 推广位
/// </summary>
[JsonProperty("pid")]
public string Pid {get;set;}
/// <summary>
/// 频道来源：4-限时秒杀,39997-充值中心, 39998-转链type，39999-电器城，39996-百亿补贴
/// </summary>
[JsonProperty("resource_type")]
public int? ResourceType {get;set;}
/// <summary>
/// 原链接
/// </summary>
[JsonProperty("url")]
public string Url {get;set;}
/// <summary>
/// 是否返回 schema URL
/// </summary>
[JsonProperty("generate_schema_url")]
public bool? GenerateSchemaUrl {get;set;}

}

}
