using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class UpdateGoodsSkuStockRequestModel : PddRequestModel
    {
        /// <summary>
/// 该值为：pdd.goods.sku.stock.update
/// </summary>
[JsonProperty("type")]
public string Type {get;set;}
/// <summary>
/// 879512
/// </summary>
[JsonProperty("sku_id")]
public string SkuId {get;set;}
/// <summary>
/// 外部编码如：outer_11，ps: sku_id 和 outer_id 两者必须填一个，同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。
/// </summary>
[JsonProperty("outer_id")]
public string OuterId {get;set;}
/// <summary>
/// 修改后的库存值：如 56
/// </summary>
[JsonProperty("quantity")]
public int Quantity {get;set;}
}
}

