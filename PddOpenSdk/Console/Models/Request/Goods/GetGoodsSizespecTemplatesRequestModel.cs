using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Goods
{
public partial class GetGoodsSizespecTemplatesRequestModel : PddRequestModel
{
/// <summary>
/// 尺码表分类id，pdd.goods.sizespec.class.get得到
/// </summary>
[JsonProperty("class_id")]
public long ClassId {get;set;}
/// <summary>
/// 限制数量
/// </summary>
[JsonProperty("limit")]
public long Limit {get;set;}
/// <summary>
/// 偏移量
/// </summary>
[JsonProperty("offset")]
public long Offset {get;set;}

}

}
