using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class GetDdkGoodsBasicInfoRequestModel : PddRequestModel
    {
        /// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id_list")]
public object GoodsIdList {get;set;}

}
}
