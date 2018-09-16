using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class TemplateSmsCreateCustomRequestModel : PddRequestModel
    {
        /// <summary>
/// 短信模板名称
/// </summary>
[JsonProperty("name")]
public object Name {get;set;}
/// <summary>
/// 拼接短信内容
/// </summary>
[JsonProperty("content")]
public object Content {get;set;}
/// <summary>
/// 短信内容
/// </summary>
[JsonProperty("value")]
public object Value {get;set;}
/// <summary>
/// 文本类型。1：自定义短信内容，2：店铺短链接，3：商品短链接，4：优惠券面额，5：优惠券到期时间
/// </summary>
[JsonProperty("type")]
public object Type {get;set;}

    public partial class ContentRequestModel : PddRequestModel
    {
        /// <summary>
/// 短信内容
/// </summary>
[JsonProperty("value")]
public object Value {get;set;}
/// <summary>
/// 文本类型。1：自定义短信内容，2：店铺短链接，3：商品短链接，4：优惠券面额，5：优惠券到期时间
/// </summary>
[JsonProperty("type")]
public object Type {get;set;}

}

}
}
