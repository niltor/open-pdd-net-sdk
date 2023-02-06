namespace PddOpenSdk.Models.Request.Ddk;
public partial class GenDdkWeappQrcodeUrl
{

    /// <summary>
    /// 多多礼金ID
    /// </summary>
    [JsonPropertyName("cash_gift_id")]
    public long? CashGiftId { get; set; }

    /// <summary>
    /// 自定义参数，为链接打上自定义标签；自定义参数最长限制64个字节；格式为：  {"uid":"11111","sid":"22222"} ，其中 uid 用户唯一标识，可自行加密后传入，每个用户仅且对应一个标识，必填； sid 上下文信息标识，例如sessionId等，非必填。该json字符串中也可以加入其他自定义的key
    /// </summary>
    [JsonPropertyName("custom_parameters")]
    public string CustomParameters { get; set; }

    /// <summary>
    /// 是否生成店铺收藏券推广链接
    /// </summary>
    [JsonPropertyName("generate_mall_collect_coupon")]
    public bool? GenerateMallCollectCoupon { get; set; }

    /// <summary>
    /// 商品goodsSign列表，支持通过goodsSign查询商品。goodsSign是加密后的goodsId, goodsId已下线，请使用goodsSign来替代。使用说明：https://jinbao.pinduoduo.com/qa-system?questionId=252
    /// </summary>
    [JsonPropertyName("goods_sign_list")]
    public List<string> GoodsSignList { get; set; }

    /// <summary>
    /// 推广位ID
    /// </summary>
    [JsonPropertyName("p_id")]
    public string PId { get; set; }

    /// <summary>
    /// 招商多多客ID
    /// </summary>
    [JsonPropertyName("zs_duo_id")]
    public long? ZsDuoId { get; set; }

}

