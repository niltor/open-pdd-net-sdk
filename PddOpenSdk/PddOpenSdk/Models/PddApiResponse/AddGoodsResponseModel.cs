using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class AddGoodsResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品ID
/// </summary>
[JsonProperty("goods_id")]
public object GoodsId {get;set;}
/// <summary>
/// 上传商品的上传序列ID
/// </summary>
[JsonProperty("goods_commit_id")]
public int GoodsCommitId {get;set;}

}
}
