namespace PddOpenSdk.Models.Request.Goods;
public partial class GetGoodsAdvicePrice
{

    /// <summary>
    /// 获取商品建议价格请求参数
    /// </summary>
    [JsonPropertyName("request")]
    public RequestModel Request { get; set; }
    public partial class RequestModel
    {

        /// <summary>
        /// 页码，默认1
        /// </summary>
        [JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// 每页数量，默认100，最大100
        /// </summary>
        [JsonPropertyName("page_size")]
        public int? PageSize { get; set; }

    }

}

