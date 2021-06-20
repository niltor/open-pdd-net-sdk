using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Goods
{
public partial class GetGoodsOptResponseModel : PddResponseModel
{
/// <summary>
/// 返回response
/// </summary>
[JsonProperty("goods_opt_get_response")]
public GoodsOptGetResponseResponseModel GoodsOptGetResponse {get;set;}
public partial class GoodsOptGetResponseResponseModel : PddResponseModel
{
/// <summary>
/// opt列表
/// </summary>
[JsonProperty("goods_opt_list")]
public List<GoodsOptListResponseModel> GoodsOptList {get;set;}
public partial class GoodsOptListResponseModel : PddResponseModel
{
/// <summary>
/// 层级，1-一级，2-二级，3-三级，4-四级
/// </summary>
[JsonProperty("level")]
public int? Level {get;set;}
/// <summary>
/// 商品标签ID
/// </summary>
[JsonProperty("opt_id")]
public long? OptId {get;set;}
/// <summary>
/// 商品标签名
/// </summary>
[JsonProperty("opt_name")]
public string OptName {get;set;}
/// <summary>
/// id所属父ID，其中，parent_id=0时为顶级节点
/// </summary>
[JsonProperty("parent_opt_id")]
public long? ParentOptId {get;set;}

}

}

}

}
