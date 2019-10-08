using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Sms
{
public partial class TemplateSmsCreateCustomRequestModel : PddRequestModel
{
/// <summary>
/// 短信模板名称
/// </summary>
[JsonProperty("name")]
public string Name {get;set;}
/// <summary>
/// 拼接短信内容
/// </summary>
[JsonProperty("content")]
public List<ContentRequestModel> Content {get;set;}
public partial class ContentRequestModel : PddRequestModel
{
/// <summary>
/// 短信内容
/// </summary>
[JsonProperty("value")]
public string Value {get;set;}
/// <summary>
/// 文本类型。1：自定义短信内容，2：店铺短链接，3：商品短链接，4：优惠券面额，5：优惠券到期时间
/// </summary>
[JsonProperty("type")]
public int Type {get;set;}

}

}

}
