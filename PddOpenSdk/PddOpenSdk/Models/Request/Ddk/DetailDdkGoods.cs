namespace PddOpenSdk.Models.Request.Ddk;
public partial class DetailDdkGoods
{

    /// <summary>
    /// 自定义参数，为链接打上自定义标签；自定义参数最长限制64个字节；格式为：  {"uid":"11111","sid":"22222"} ，其中 uid 用户唯一标识，可自行加密后传入，每个用户仅且对应一个标识，必填； sid 上下文信息标识，例如sessionId等，非必填。该json字符串中也可以加入其他自定义的key。（如果使用GET请求，请使用URLEncode处理参数）
    /// </summary>
    [JsonPropertyName("custom_parameters")]
    public string CustomParameters { get; set; }

    /// <summary>
    /// 商品主图类型：1-场景图，2-白底图，默认为0
    /// </summary>
    [JsonPropertyName("goods_img_type")]
    public int? GoodsImgType { get; set; }

    /// <summary>
    /// 商品goodsSign，支持通过goodsSign查询商品。goodsSign是加密后的goodsId, goodsId已下线，请使用goodsSign来替代。使用说明：https://jinbao.pinduoduo.com/qa-system?questionId=252
    /// </summary>
    [JsonPropertyName("goods_sign")]
    public string GoodsSign { get; set; }

    /// <summary>
    /// 推广位id
    /// </summary>
    [JsonPropertyName("pid")]
    public string Pid { get; set; }

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

