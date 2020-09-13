using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Goods
{
public partial class AddGoodsResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("goods_add_response")]
public GoodsAddResponseResponseModel GoodsAddResponse {get;set;}
public partial class GoodsAddResponseResponseModel : PddResponseModel
{
/// <summary>
/// 上传商品的上传序列ID
/// </summary>
[JsonProperty("goods_commit_id")]
public long? GoodsCommitId {get;set;}
/// <summary>
/// 商品ID
/// </summary>
[JsonProperty("goods_id")]
public long? GoodsId {get;set;}

}

}

}
