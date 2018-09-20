using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class FieldExchangeThirdResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品ID
/// </summary>
[JsonProperty("goods_id")]
public json string GoodsId {get;set;}
/// <summary>
/// 商品草稿ID
/// </summary>
[JsonProperty("goods_commit_id")]
public json string GoodsCommitId {get;set;}

}
}
