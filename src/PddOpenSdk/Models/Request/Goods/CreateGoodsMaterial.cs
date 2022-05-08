namespace PddOpenSdk.Models.Request.Goods;
public partial class CreateGoodsMaterial
{

    /// <summary>
    /// 素材内容（一般为图片链接）
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; }

    /// <summary>
    /// 图片空间文件id
    /// </summary>
    [JsonPropertyName("file_id")]
    public long FileId { get; set; }

    /// <summary>
    /// 商品id
    /// </summary>
    [JsonPropertyName("goods_id")]
    public long GoodsId { get; set; }

    /// <summary>
    /// 素材类型（1：白底图；3：长图）
    /// </summary>
    [JsonPropertyName("material_type")]
    public int MaterialType { get; set; }

}

