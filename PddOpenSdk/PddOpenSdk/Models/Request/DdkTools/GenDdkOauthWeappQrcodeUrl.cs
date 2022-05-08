namespace PddOpenSdk.Models.Request.DdkTools;
public partial class GenDdkOauthWeappQrcodeUrl
{

    /// <summary>
    /// 自定义参数，为链接打上自定义标签。自定义参数最长限制64个字节。
    /// </summary>
    [JsonPropertyName("custom_parameters")]
    public string CustomParameters { get; set; }

    /// <summary>
    /// 商品ID，仅支持单个查询
    /// </summary>
    [JsonPropertyName("goods_id_list")]
    public List<long?> GoodsIdList { get; set; }

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

