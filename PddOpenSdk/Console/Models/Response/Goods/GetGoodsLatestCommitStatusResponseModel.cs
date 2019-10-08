using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Goods
{
public partial class GetGoodsLatestCommitStatusResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("goods_latest_commit_status_get_response")]
public GoodsLatestCommitStatusGetResponseResponseModel GoodsLatestCommitStatusGetResponse {get;set;}
public partial class GoodsLatestCommitStatusGetResponseResponseModel : PddResponseModel
{
/// <summary>
/// list
/// </summary>
[JsonProperty("list")]
public List<ListResponseModel> List {get;set;}
public partial class ListResponseModel : PddResponseModel
{
/// <summary>
/// 草稿状态
/// </summary>
[JsonProperty("check_status")]
public int? CheckStatus {get;set;}
/// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id")]
public long? GoodsId {get;set;}
/// <summary>
/// 驳回原因
/// </summary>
[JsonProperty("reject_comment")]
public string RejectComment {get;set;}

}

}

}

}
