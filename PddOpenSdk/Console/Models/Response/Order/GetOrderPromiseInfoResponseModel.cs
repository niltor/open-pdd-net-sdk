using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Order
{
public partial class GetOrderPromiseInfoResponseModel : PddResponseModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("promise_info_get_response")]
public PromiseInfoGetResponseResponseModel PromiseInfoGetResponse {get;set;}
public partial class PromiseInfoGetResponseResponseModel : PddResponseModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("promise_info")]
public PromiseInfoResponseModel PromiseInfo {get;set;}
public partial class PromiseInfoResponseModel : PddResponseModel
{
/// <summary>
/// 承诺详情
/// </summary>
[JsonProperty("detail_info")]
public Dictionary<string, object> DetailInfo {get;set;}
/// <summary>
/// 额外信息
/// </summary>
[JsonProperty("extra_info")]
public Dictionary<string, object> ExtraInfo {get;set;}
/// <summary>
/// 是否已删除
/// </summary>
[JsonProperty("is_deleted")]
public bool? IsDeleted {get;set;}
/// <summary>
/// 订单号
/// </summary>
[JsonProperty("order_sn")]
public string OrderSn {get;set;}
/// <summary>
/// 服务承诺描述
/// </summary>
[JsonProperty("promise_desc")]
public string PromiseDesc {get;set;}
/// <summary>
/// 服务承诺单性质，1-平台协议，2-客服承 诺，3-平台建议
/// </summary>
[JsonProperty("promise_level")]
public int? PromiseLevel {get;set;}
/// <summary>
/// 服务承诺状态，0-已创建，1-履约中，2-履 约未达成，3-履约成功
/// </summary>
[JsonProperty("promise_status")]
public int? PromiseStatus {get;set;}
/// <summary>
/// 服务承诺类型，1-指定快递/物流，2-优先发 货
/// </summary>
[JsonProperty("promise_type")]
public int? PromiseType {get;set;}
/// <summary>
/// 承诺信息id
/// </summary>
[JsonProperty("promise_id")]
public long? PromiseId {get;set;}
/// <summary>
/// 业务场景，1-发货场景
/// </summary>
[JsonProperty("scene_type")]
public int? SceneType {get;set;}
/// <summary>
/// 最后更新时间
/// </summary>
[JsonProperty("updated_at")]
public string UpdatedAt {get;set;}
public partial class DetailInfoResponseModel : PddResponseModel
{
/// <summary>
/// key 详情请参阅接口文档
/// </summary>
[JsonProperty("$key")]
public string Key {get;set;}
/// <summary>
/// value 详情请参阅接口文档
/// </summary>
[JsonProperty("$value")]
public string Value {get;set;}

}
public partial class ExtraInfoResponseModel : PddResponseModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("$key")]
public string Key {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("$value")]
public string Value {get;set;}

}

}

}

}

}
