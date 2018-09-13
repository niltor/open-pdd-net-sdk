using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class CommitGoodsSubmitGoodsResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回response
/// </summary>
[JsonProperty("goods_update_response")]
public object GoodsUpdateResponse {get;set;}
/// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id")]
public string GoodsId {get;set;}
/// <summary>
/// 提交申请的序列id
/// </summary>
[JsonProperty("goods_commit_id")]
public string GoodsCommitId {get;set;}

    public partial class GoodsUpdateResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id")]
public string GoodsId {get;set;}
/// <summary>
/// 提交申请的序列id
/// </summary>
[JsonProperty("goods_commit_id")]
public string GoodsCommitId {get;set;}

}

}
}
