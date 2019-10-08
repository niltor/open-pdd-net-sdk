using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ddkoauth
{
public partial class GenDdkOauthGoodsZsUnitUrlRequestModel : PddRequestModel
{
/// <summary>
/// 需转链的链接
/// </summary>
[JsonProperty("source_url")]
public string SourceUrl {get;set;}
/// <summary>
/// 渠道id
/// </summary>
[JsonProperty("pid")]
public string Pid {get;set;}
/// <summary>
/// 是否返回 schema URL
/// </summary>
[JsonProperty("generate_schema_url")]
public string GenerateSchemaUrl {get;set;}

}

}
