using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class GetGoodsInformationRequestModel : PddRequestModel
    {
        /// <summary>
/// 该值为：pdd.goods.information.get
/// </summary>
[JsonProperty("type")]
public object Type {get;set;}
/// <summary>
/// 商品编码
/// </summary>
[JsonProperty("goods_id")]
public object GoodsId {get;set;}

}
}
