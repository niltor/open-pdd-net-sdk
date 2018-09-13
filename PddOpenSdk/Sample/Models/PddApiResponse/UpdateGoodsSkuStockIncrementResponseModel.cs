using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class UpdateGoodsSkuStockIncrementResponseModel : PddResponseModel
    {
        /// <summary>
/// sku增量库存修改响应对象
/// </summary>
[JsonProperty("sku增量库存修改响应对象")]
public List<SkuStockIncrementUpdateResponse> SkuStockIncrementUpdateResponse {get;set;}
/// <summary>
/// 增量修改库存是否成功，false-失败，true-成功
/// </summary>
[JsonProperty("增量修改库存是否成功，false-失败，true-成功")]
public string IsSuccess {get;set;}
}
}

    public partial class SkuStockIncrementUpdateResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 增量修改库存是否成功，false-失败，true-成功
/// </summary>
[JsonProperty("增量修改库存是否成功，false-失败，true-成功")]
public string IsSuccess {get;set;}
}


