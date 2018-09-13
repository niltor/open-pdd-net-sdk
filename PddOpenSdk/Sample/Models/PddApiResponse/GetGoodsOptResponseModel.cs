using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GetGoodsOptResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回response
/// </summary>
[JsonProperty("返回response")]
public List<GoodsOptGetResponse> GoodsOptGetResponse {get;set;}
/// <summary>
/// opt列表
/// </summary>
[JsonProperty("opt列表")]
public List<GoodsOptList> GoodsOptList {get;set;}
/// <summary>
/// 层级，1-一级，2-二级，3-三级，4-四级
/// </summary>
[JsonProperty("层级，1-一级，2-二级，3-三级，4-四级")]
public int Level {get;set;}
/// <summary>
/// id所属父ID，其中，parent_id=0时为顶级节点
/// </summary>
[JsonProperty("id所属父ID，其中，parent_id=0时为顶级节点")]
public int ParentOptId {get;set;}
/// <summary>
/// 商品标签名
/// </summary>
[JsonProperty("商品标签名")]
public string OptName {get;set;}
/// <summary>
/// 商品标签ID
/// </summary>
[JsonProperty("商品标签ID")]
public int OptId {get;set;}
}
}

    public partial class GoodsOptGetResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// opt列表
/// </summary>
[JsonProperty("opt列表")]
public List<GoodsOptList> GoodsOptList {get;set;}
}


    public partial class GoodsOptListResponseModel : PddResponseModel
    {
        /// <summary>
/// 层级，1-一级，2-二级，3-三级，4-四级
/// </summary>
[JsonProperty("层级，1-一级，2-二级，3-三级，4-四级")]
public int Level {get;set;}
/// <summary>
/// id所属父ID，其中，parent_id=0时为顶级节点
/// </summary>
[JsonProperty("id所属父ID，其中，parent_id=0时为顶级节点")]
public int ParentOptId {get;set;}
/// <summary>
/// 商品标签名
/// </summary>
[JsonProperty("商品标签名")]
public string OptName {get;set;}
/// <summary>
/// 商品标签ID
/// </summary>
[JsonProperty("商品标签ID")]
public int OptId {get;set;}
}


