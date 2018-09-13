using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class UpdateGoodsSkuPriceResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("goods_update_sku_price_response")]
public object GoodsUpdateSkuPriceResponse {get;set;}
/// <summary>
/// 是否成功
/// </summary>
[JsonProperty("is_success")]
public bool IsSuccess {get;set;}

    public partial class GoodsUpdateSkuPriceResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 是否成功
/// </summary>
[JsonProperty("is_success")]
public bool IsSuccess {get;set;}

}

}
}
