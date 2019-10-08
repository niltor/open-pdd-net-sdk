using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Goods
{
public partial class GetGoodsCommitStatusResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("goods_commit_status_get_response")]
public GoodsCommitStatusGetResponseResponseModel GoodsCommitStatusGetResponse {get;set;}
public partial class GoodsCommitStatusGetResponseResponseModel : PddResponseModel
{
/// <summary>
/// list
/// </summary>
[JsonProperty("list")]
public List<ListResponseModel> List {get;set;}
public partial class ListResponseModel : PddResponseModel
{
/// <summary>
/// 状态
/// </summary>
[JsonProperty("check_status")]
public int? CheckStatus {get;set;}
/// <summary>
/// 草稿id
/// </summary>
[JsonProperty("goods_commit_id")]
public long? GoodsCommitId {get;set;}
/// <summary>
/// 驳回原因
/// </summary>
[JsonProperty("reject_comment")]
public string RejectComment {get;set;}

}

}

}

}
