using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class GetGoodsDetailRequestModel : PddRequestModel
    {
        /// <summary>
/// 1213414
/// </summary>
[JsonProperty("goods_id")]
public int GoodsId {get;set;}

}
}
