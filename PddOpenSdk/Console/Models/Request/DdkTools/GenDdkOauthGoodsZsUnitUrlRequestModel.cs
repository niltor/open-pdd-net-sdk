using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.DdkTools
{
public partial class GenDdkOauthGoodsZsUnitUrlRequestModel : PddRequestModel
{
/// <summary>
/// 自定义参数，为链接打上自定义标签；自定义参数最长限制64个字节；格式为：  {"uid":"11111","sid":"22222"} ，其中 uid 用户唯一标识，可自行加密后传入，每个用户仅且对应一个标识，必填； sid 上下文信息标识，例如sessionId等，非必填。该json字符串中也可以加入其他自定义的key。（如果使用GET请求，请使用URLEncode处理参数）
/// </summary>
[JsonProperty("custom_parameters")]
public string CustomParameters {get;set;}
/// <summary>
/// 是否返回 schema URL
/// </summary>
[JsonProperty("generate_schema_url")]
public bool? GenerateSchemaUrl {get;set;}
/// <summary>
/// 渠道id
/// </summary>
[JsonProperty("pid")]
public string Pid {get;set;}
/// <summary>
/// 需转链的链接，支持拼多多商品链接、进宝长链/短链（即为pdd.ddk.goods.promotion.url.generate接口生成的长短链）
/// </summary>
[JsonProperty("source_url")]
public string SourceUrl {get;set;}

}

}
