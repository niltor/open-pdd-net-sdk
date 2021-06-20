using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Order
{
public partial class UpdateOrderNoteRequestModel : PddRequestModel
{
/// <summary>
/// 订单备注
/// </summary>
[JsonProperty("note")]
public string Note {get;set;}
/// <summary>
/// 备注标记：1-红色，2-黄色，3-绿色，4-蓝色，5-紫色，tag与tag_name关联，都入参或都不入参
/// </summary>
[JsonProperty("tag")]
public int? Tag {get;set;}
/// <summary>
/// 标记名称；长度最大为3个字符，tag与tag_name关联，都入参或都不入参
/// </summary>
[JsonProperty("tag_name")]
public string TagName {get;set;}
/// <summary>
/// 订单号
/// </summary>
[JsonProperty("order_sn")]
public string OrderSn {get;set;}

}

}
