using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class SetGoodsSaleStatusRequestModel : PddRequestModel
    {
        /// <summary>
/// 拼多多商品id
/// </summary>
[JsonProperty("goods_id")]
public int GoodsId {get;set;}
/// <summary>
/// 上下架状态：1:上架 0:下架
/// </summary>
[JsonProperty("is_onsale")]
public int IsOnsale {get;set;}
}
}

