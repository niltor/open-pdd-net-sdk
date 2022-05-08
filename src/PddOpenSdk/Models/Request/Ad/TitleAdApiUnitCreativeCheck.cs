namespace PddOpenSdk.Models.Request.Ad;
public partial class TitleAdApiUnitCreativeCheck
{

    /// <summary>
    /// 商品Id
    /// </summary>
    [JsonPropertyName("goodsId")]
    public long GoodsId { get; set; }

    /// <summary>
    /// 创意标题
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

}

