using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Goods
{
public partial class GetGoodsSizespecTemplateResponseModel : PddResponseModel
{
/// <summary>
/// 响应
/// </summary>
[JsonProperty("response")]
public ResponseResponseModel Response {get;set;}
public partial class ResponseResponseModel : PddResponseModel
{
/// <summary>
/// 错误码
/// </summary>
[JsonProperty("error_code")]
public int? ErrorCode {get;set;}
/// <summary>
/// 错误描述
/// </summary>
[JsonProperty("error_msg")]
public string ErrorMsg {get;set;}
/// <summary>
/// 结果
/// </summary>
[JsonProperty("result")]
public ResultResponseModel Result {get;set;}
/// <summary>
/// 请求成功
/// </summary>
[JsonProperty("success")]
public bool? Success {get;set;}
public partial class ResultResponseModel : PddResponseModel
{
/// <summary>
/// 尺码表分类id
/// </summary>
[JsonProperty("class_id")]
public long? ClassId {get;set;}
/// <summary>
/// 尺码表内容
/// </summary>
[JsonProperty("content")]
public ContentResponseModel Content {get;set;}
/// <summary>
/// 创建时间
/// </summary>
[JsonProperty("create_at")]
public long? CreateAt {get;set;}
/// <summary>
/// 扩展类型
/// </summary>
[JsonProperty("extend_type")]
public int? ExtendType {get;set;}
/// <summary>
/// 尺码表id
/// </summary>
[JsonProperty("id")]
public long? Id {get;set;}
/// <summary>
/// 是否尺码表分类默认
/// </summary>
[JsonProperty("is_default")]
public bool? IsDefault {get;set;}
/// <summary>
/// 尺码表属于的店铺
/// </summary>
[JsonProperty("mall_id")]
public long? MallId {get;set;}
/// <summary>
/// 尺码表名称
/// </summary>
[JsonProperty("name")]
public string Name {get;set;}
/// <summary>
/// 是否可复用
/// </summary>
[JsonProperty("reusable")]
public bool? Reusable {get;set;}
/// <summary>
/// 更新时间
/// </summary>
[JsonProperty("update_at")]
public long? UpdateAt {get;set;}
/// <summary>
/// 使用的商品数
/// </summary>
[JsonProperty("used")]
public long? Used {get;set;}
public partial class ContentResponseModel : PddResponseModel
{
/// <summary>
/// 尺码表元数据（表头）
/// </summary>
[JsonProperty("meta")]
public MetaResponseModel Meta {get;set;}
/// <summary>
/// 尺码表图片
/// </summary>
[JsonProperty("pic_url")]
public string PicUrl {get;set;}
/// <summary>
/// 尺码表行数据
/// </summary>
[JsonProperty("records")]
public List<RecordsResponseModel> Records {get;set;}
public partial class MetaResponseModel : PddResponseModel
{
/// <summary>
/// 可批量的尺码元素id
/// </summary>
[JsonProperty("batchable_element_ids")]
public List<int?> BatchableElementIds {get;set;}
/// <summary>
/// 尺码元素
/// </summary>
[JsonProperty("elements")]
public List<ElementsResponseModel> Elements {get;set;}
/// <summary>
/// 尺码组
/// </summary>
[JsonProperty("groups")]
public List<GroupsResponseModel> Groups {get;set;}
public partial class ElementsResponseModel : PddResponseModel
{
/// <summary>
/// 尺码元数据id
/// </summary>
[JsonProperty("id")]
public int? Id {get;set;}
/// <summary>
/// 尺码元数据名称
/// </summary>
[JsonProperty("name")]
public string Name {get;set;}

}
public partial class GroupsResponseModel : PddResponseModel
{
/// <summary>
/// 尺码元数据id
/// </summary>
[JsonProperty("id")]
public int? Id {get;set;}
/// <summary>
/// 尺码元数据名称
/// </summary>
[JsonProperty("name")]
public string Name {get;set;}

}

}
public partial class RecordsResponseModel : PddResponseModel
{
/// <summary>
/// 尺码组和尺码表元素的值
/// </summary>
[JsonProperty("values")]
public Dictionary<string, object> Values {get;set;}
public partial class ValuesResponseModel : PddResponseModel
{
/// <summary>
/// 尺码组和尺码表元素的id
/// </summary>
[JsonProperty("$key")]
public int? Key {get;set;}
/// <summary>
/// 尺码组和尺码表元素的值
/// </summary>
[JsonProperty("$value")]
public string Value {get;set;}

}

}

}

}

}

}

}
