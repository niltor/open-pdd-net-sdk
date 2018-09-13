using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class FieldExchangeThirdResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品ID
/// </summary>
[JsonProperty("商品ID")]
public Json string GoodsId {get;set;}
/// <summary>
/// 商品草稿ID
/// </summary>
[JsonProperty("商品草稿ID")]
public Json string GoodsCommitId {get;set;}
}
}

