namespace PddOpenSdk.Models.Request.Ad;
public partial class BidAdApiUnitTrUpdateOptimization
{

    /// <summary>
    /// 商品id
    /// </summary>
    [JsonPropertyName("goodsId")]
    public long GoodsId { get; set; }

    /// <summary>
    /// 成交出价，4000~1000000(表示4-1000元)
    /// </summary>
    [JsonPropertyName("optimizationBid")]
    public long OptimizationBid { get; set; }

}

