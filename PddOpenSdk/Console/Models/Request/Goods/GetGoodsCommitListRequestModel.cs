using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Goods
{
public partial class GetGoodsCommitListRequestModel : PddRequestModel
{
/// <summary>
/// 草稿状态（0:编辑中,1:审核中,2:审核通过,3:审核驳回）
/// </summary>
[JsonProperty("check_status")]
public int CheckStatus {get;set;}
/// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id")]
public long? GoodsId {get;set;}
/// <summary>
/// 页码，最多不超过100
/// </summary>
[JsonProperty("page")]
public int Page {get;set;}
/// <summary>
/// 每页数量，最多不超过100
/// </summary>
[JsonProperty("page_size")]
public int PageSize {get;set;}

}

}
