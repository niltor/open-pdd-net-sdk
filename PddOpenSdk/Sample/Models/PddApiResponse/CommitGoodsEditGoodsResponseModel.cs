using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class CommitGoodsEditGoodsResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品ID
/// </summary>
[JsonProperty("商品ID")]
public int GoodsId {get;set;}
/// <summary>
/// 草稿id
/// </summary>
[JsonProperty("草稿id")]
public int GoodsCommitId {get;set;}
}
}

