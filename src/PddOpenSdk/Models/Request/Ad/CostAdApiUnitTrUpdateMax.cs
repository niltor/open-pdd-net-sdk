namespace PddOpenSdk.Models.Request.Ad;
public partial class CostAdApiUnitTrUpdateMax
{

    /// <summary>
    /// 商品id
    /// </summary>
    [JsonPropertyName("goodsId")]
    public long GoodsId { get; set; }

    /// <summary>
    /// 单日消耗上线（厘），范围100000~1000000000（表示100-1000000元）
    /// </summary>
    [JsonPropertyName("maxCost")]
    public long MaxCost { get; set; }

}

