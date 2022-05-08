namespace PddOpenSdk.Models.Request.Ddk;
public partial class GenerateDdkGoodsPromotionUrl
{

    /// <summary>
    /// 多多礼金ID
    /// </summary>
    [JsonPropertyName("cash_gift_id")]
    public long? CashGiftId { get; set; }

    /// <summary>
    /// 自定义礼金标题，用于向用户展示渠道专属福利，不超过12个字
    /// </summary>
    [JsonPropertyName("cash_gift_name")]
    public string CashGiftName { get; set; }

    /// <summary>
    /// 自定义参数，为链接打上自定义标签；自定义参数最长限制64个字节；格式为：  {"uid":"11111","sid":"22222"} ，其中 uid 用户唯一标识，可自行加密后传入，每个用户仅且对应一个标识，必填； sid 上下文信息标识，例如sessionId等，非必填。该json字符串中也可以加入其他自定义的key。（如果使用GET请求，请使用URLEncode处理参数）
    /// </summary>
    [JsonPropertyName("custom_parameters")]
    public string CustomParameters { get; set; }

    /// <summary>
    /// 是否生成带授权的单品链接。如果未授权，则会走授权流程
    /// </summary>
    [JsonPropertyName("generate_authority_url")]
    public bool? GenerateAuthorityUrl { get; set; }

    /// <summary>
    /// 是否生成店铺收藏券推广链接
    /// </summary>
    [JsonPropertyName("generate_mall_collect_coupon")]
    public bool? GenerateMallCollectCoupon { get; set; }

    /// <summary>
    /// 是否生成qq小程序
    /// </summary>
    [JsonPropertyName("generate_qq_app")]
    public bool? GenerateQqApp { get; set; }

    /// <summary>
    /// 是否返回 schema URL
    /// </summary>
    [JsonPropertyName("generate_schema_url")]
    public bool? GenerateSchemaUrl { get; set; }

    /// <summary>
    /// 是否生成短链接，true-是，false-否
    /// </summary>
    [JsonPropertyName("generate_short_url")]
    public bool? GenerateShortUrl { get; set; }

    /// <summary>
    /// 是否生成拼多多福利券微信小程序推广信息
    /// </summary>
    [JsonPropertyName("generate_we_app")]
    public bool? GenerateWeApp { get; set; }

    /// <summary>
    /// 商品goodsSign列表，例如：["c9r2omogKFFAc7WBwvbZU1ikIb16_J3CTa8HNN"]，支持批量生链。goodsSign是加密后的goodsId, goodsId已下线，请使用goodsSign来替代。使用说明：https://jinbao.pinduoduo.com/qa-system?questionId=252
    /// </summary>
    [JsonPropertyName("goods_sign_list")]
    public List<string> GoodsSignList { get; set; }

    /// <summary>
    /// 素材ID，可以通过商品详情接口获取商品素材信息
    /// </summary>
    [JsonPropertyName("material_id")]
    public string MaterialId { get; set; }

    /// <summary>
    /// true--生成多人团推广链接 false--生成单人团推广链接（默认false）1、单人团推广链接：用户访问单人团推广链接，可直接购买商品无需拼团。2、多人团推广链接：用户访问双人团推广链接开团，若用户分享给他人参团，则开团者和参团者的佣金均结算给推手
    /// </summary>
    [JsonPropertyName("multi_group")]
    public bool? MultiGroup { get; set; }

    /// <summary>
    /// 推广位ID
    /// </summary>
    [JsonPropertyName("p_id")]
    public string PId { get; set; }

    /// <summary>
    /// 搜索id，建议填写，提高收益。来自pdd.ddk.goods.recommend.get、pdd.ddk.goods.search、pdd.ddk.top.goods.list.query等接口
    /// </summary>
    [JsonPropertyName("search_id")]
    public string SearchId { get; set; }

    /// <summary>
    /// 招商多多客ID
    /// </summary>
    [JsonPropertyName("zs_duo_id")]
    public long? ZsDuoId { get; set; }

}

