using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class GetGoodsInformationRequestModel : PddRequestModel
    {
        /// <summary>
/// 该值为：pdd.goods.information.get
/// </summary>
[JsonProperty("type")]
public string Type {get;set;}
/// <summary>
/// 商品编码
/// </summary>
[JsonProperty("goods_id")]
public string GoodsId {get;set;}

}
}
