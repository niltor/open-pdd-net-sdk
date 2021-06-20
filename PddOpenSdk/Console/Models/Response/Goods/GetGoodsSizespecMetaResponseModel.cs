using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Goods
{
public partial class GetGoodsSizespecMetaResponseModel : PddResponseModel
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
/// 错误消息
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

}

}

}
