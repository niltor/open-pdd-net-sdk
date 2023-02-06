namespace PddOpenSdk.Models.Request.Ddk;
public partial class AuthDdkGoodsPromotionRight
{

    /// <summary>
    /// 推广商品视频素材url
    /// </summary>
    [JsonPropertyName("demo_url")]
    public string DemoUrl { get; set; }

    /// <summary>
    /// 渠道duoId
    /// </summary>
    [JsonPropertyName("duo_id")]
    public long DuoId { get; set; }

    /// <summary>
    /// 商品GoodsId
    /// </summary>
    [JsonPropertyName("goods_id")]
    public long GoodsId { get; set; }

    /// <summary>
    /// 商家资质证明图片url列表，1到3张图
    /// </summary>
    [JsonPropertyName("mall_certificate_url")]
    public List<string> MallCertificateUrl { get; set; }

    /// <summary>
    /// 推广视频预览码url
    /// </summary>
    [JsonPropertyName("promotion_code_url")]
    public string PromotionCodeUrl { get; set; }

    /// <summary>
    /// 推广结束时间戳，毫秒
    /// </summary>
    [JsonPropertyName("promotion_end_time")]
    public long PromotionEndTime { get; set; }

    /// <summary>
    /// 推广开始时间戳，毫秒
    /// </summary>
    [JsonPropertyName("promotion_start_time")]
    public long PromotionStartTime { get; set; }

    /// <summary>
    /// 商品图片素材url列表，0到3张图
    /// </summary>
    [JsonPropertyName("thumb_pic_url")]
    public List<string> ThumbPicUrl { get; set; }

}

