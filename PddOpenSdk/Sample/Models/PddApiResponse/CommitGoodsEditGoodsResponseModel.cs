using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class CommitGoodsEditGoodsResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品ID
/// </summary>
[JsonProperty("goods_id")]
public int GoodsId {get;set;}
/// <summary>
/// 草稿id
/// </summary>
[JsonProperty("goods_commit_id")]
public int GoodsCommitId {get;set;}

}
}
