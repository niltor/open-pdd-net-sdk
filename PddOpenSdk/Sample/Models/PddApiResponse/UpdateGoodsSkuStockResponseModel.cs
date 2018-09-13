using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class UpdateGoodsSkuStockResponseModel : PddResponseModel
    {
        /// <summary>
/// 全量库存更新响应对象
/// </summary>
[JsonProperty("全量库存更新响应对象")]
public List<SkuStockUpdateResponse> SkuStockUpdateResponse {get;set;}
/// <summary>
/// 全量更新是否成功，true-成功，false-失败
/// </summary>
[JsonProperty("全量更新是否成功，true-成功，false-失败")]
public bool IsSuccess {get;set;}
}
}

    public partial class SkuStockUpdateResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 全量更新是否成功，true-成功，false-失败
/// </summary>
[JsonProperty("全量更新是否成功，true-成功，false-失败")]
public bool IsSuccess {get;set;}
}


