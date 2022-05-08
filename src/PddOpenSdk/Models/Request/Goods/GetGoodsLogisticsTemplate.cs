namespace PddOpenSdk.Models.Request.Goods;
public partial class GetGoodsLogisticsTemplate
{

    /// <summary>
    /// 默认返回运费模板的页数为1，最高为100页，注意：page与page_size必须传一个
    /// </summary>
    [JsonPropertyName("page")]
    public int? Page { get; set; }

    /// <summary>
    /// 默认返回20条模板数据，最多100条数据
    /// </summary>
    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }

    /// <summary>
    /// 0-新发布商品，1-编辑商品。如传值为空，平台默认为发布商品
    /// </summary>
    [JsonPropertyName("goods_status")]
    public int? GoodsStatus { get; set; }

}

