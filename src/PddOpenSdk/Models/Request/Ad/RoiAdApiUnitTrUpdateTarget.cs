namespace PddOpenSdk.Models.Request.Ad;
public partial class RoiAdApiUnitTrUpdateTarget
{

    /// <summary>
    /// 商品id
    /// </summary>
    [JsonPropertyName("goodsId")]
    public long GoodsId { get; set; }

    /// <summary>
    /// 目标roi 范围1000~1000000(万分位，表示0.1~100)
    /// </summary>
    [JsonPropertyName("targetRoi")]
    public long TargetRoi { get; set; }

}

