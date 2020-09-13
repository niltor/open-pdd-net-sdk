using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ddk
{
public partial class GenDdkLiveUrlRequestModel : PddRequestModel
{
/// <summary>
/// 自定义参数，为链接打上自定义标签；自定义参数最长限制64个字节；格式为：{"uid":"11111","sid":"22222"} ，其中 uid 为用户唯一标识，可自行加密后传入，每个用户仅且对应一个标识，必填； sid 上下文信息标识，例如sessionId等，非必填。该json字符串中也可以加入其他自定义的key。授权绑定备案支持优先对该自定义参数里面uid的解析绑定。
/// </summary>
[JsonProperty("custom_parameters")]
public string CustomParameters {get;set;}
/// <summary>
/// 是否生成唤起拼多多APP链接，默认true
/// </summary>
[JsonProperty("generate_mobile")]
public bool? GenerateMobile {get;set;}
/// <summary>
/// 是否返回 schema URL
/// </summary>
[JsonProperty("generate_schema_url")]
public bool? GenerateSchemaUrl {get;set;}
/// <summary>
/// 是否生成短链接，默认true
/// </summary>
[JsonProperty("generate_short_url")]
public bool? GenerateShortUrl {get;set;}
/// <summary>
/// 是否生成小程序推广，默认false
/// </summary>
[JsonProperty("generate_we_app")]
public bool? GenerateWeApp {get;set;}
/// <summary>
/// 直播间类型；1-达人，2-店铺，3-预约直播间；默认1
/// </summary>
[JsonProperty("live_type")]
public int LiveType {get;set;}
/// <summary>
/// 推广位ID
/// </summary>
[JsonProperty("p_id")]
public string PId {get;set;}
/// <summary>
/// 直播间id或者店铺id
/// </summary>
[JsonProperty("room_id")]
public string RoomId {get;set;}

}

}
