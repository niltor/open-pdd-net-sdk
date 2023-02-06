namespace PddOpenSdk.Models.Request.Ad;
public partial class CreateAdApiUnitTr
{

    /// <summary>
    /// 商品id
    /// </summary>
    [JsonPropertyName("goodsId")]
    public long GoodsId { get; set; }

    /// <summary>
    /// 日限额（厘），范围100000~1000000000（表示100-1000000元）,选填
    /// </summary>
    [JsonPropertyName("maxCost")]
    public long? MaxCost { get; set; }

    /// <summary>
    /// 成交出价（厘），4000~1000000(表示4-1000元)，选填
    /// </summary>
    [JsonPropertyName("optimizationBid")]
    public long? OptimizationBid { get; set; }

    /// <summary>
    /// 目标roi 范围1000~1000000 (万分位，表示0.1~100)，选填
    /// </summary>
    [JsonPropertyName("targetRoi")]
    public long? TargetRoi { get; set; }

}

