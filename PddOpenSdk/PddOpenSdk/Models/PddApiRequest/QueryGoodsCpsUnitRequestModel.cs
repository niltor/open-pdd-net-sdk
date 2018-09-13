using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class QueryGoodsCpsUnitRequestModel : PddRequestModel
    {
        /// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id")]
public object GoodsId {get;set;}

}
}
