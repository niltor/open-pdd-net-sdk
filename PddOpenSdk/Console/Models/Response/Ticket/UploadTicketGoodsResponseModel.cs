using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ticket
{
public partial class UploadTicketGoodsResponseModel : PddResponseModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("goods_upload_response")]
public GoodsUploadResponseResponseModel GoodsUploadResponse {get;set;}
public partial class GoodsUploadResponseResponseModel : PddResponseModel
{
/// <summary>
/// 草稿id
/// </summary>
[JsonProperty("goods_commit_id")]
public long? GoodsCommitId {get;set;}
/// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id")]
public long? GoodsId {get;set;}

}

}

}
