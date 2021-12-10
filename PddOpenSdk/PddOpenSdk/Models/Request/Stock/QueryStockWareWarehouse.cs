namespace PddOpenSdk.Models.Request.Stock;
public partial class QueryStockWareWarehouse
{

    /// <summary>
    /// 请求对象
    /// </summary>
    [JsonPropertyName("request")]
    public RequestModel Request { get; set; }
    public partial class RequestModel
    {

        /// <summary>
        /// 当前页数
        /// </summary>
        [JsonPropertyName("page")]
        public int Page { get; set; }

        /// <summary>
        /// 页显示数据条数
        /// </summary>
        [JsonPropertyName("page_size")]
        public int PageSize { get; set; }

        /// <summary>
        /// 货品编码列表
        /// </summary>
        [JsonPropertyName("ware_sn_list")]
        public List<string> WareSnList { get; set; }

    }

}

