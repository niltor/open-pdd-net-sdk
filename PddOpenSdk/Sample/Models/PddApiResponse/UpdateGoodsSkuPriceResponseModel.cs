using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class UpdateGoodsSkuPriceResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("response")]
public  GoodsUpdateSkuPriceResponse {get;set;}
/// <summary>
/// 是否成功
/// </summary>
[JsonProperty("是否成功")]
public bool IsSuccess {get;set;}
}
}

    public partial class GoodsUpdateSkuPriceResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 是否成功
/// </summary>
[JsonProperty("是否成功")]
public bool IsSuccess {get;set;}
}


