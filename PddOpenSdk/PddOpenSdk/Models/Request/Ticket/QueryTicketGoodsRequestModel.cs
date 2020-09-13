using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ticket
{
public partial class QueryTicketGoodsRequestModel : PddRequestModel
{
/// <summary>
/// 草稿id，入参草稿id时，表示查询该草稿的信息
/// </summary>
[JsonProperty("goods_commit_id")]
public long? GoodsCommitId {get;set;}
/// <summary>
/// 商品id入参商品id时，表示查询该商品的线上商品信息。。
/// </summary>
[JsonProperty("goods_id")]
public long? GoodsId {get;set;}

}

}
