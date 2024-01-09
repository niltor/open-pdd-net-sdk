namespace PddOpenSdk.Models.Request.Logistics;
public partial class SyncTailExpressTrace
{

    /// <summary>
    /// 轨迹信息
    /// </summary>
    [JsonPropertyName("request")]
    public RequestModel Request { get; set; }
    public partial class RequestModel
    {

        /// <summary>
        /// 地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 扫描城市名称
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 轨迹详情描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 三级地址，区/县
        /// </summary>
        [JsonPropertyName("district")]
        public string District { get; set; }

        /// <summary>
        /// 问题件原因code
        /// </summary>
        [JsonPropertyName("failReason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 数据id java.util.UUID生成
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 操作时间 格式：yyyy-MM-dd hh:mm:ss
        /// </summary>
        [JsonPropertyName("operationTime")]
        public string OperationTime { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }

        /// <summary>
        /// 快递公司id
        /// </summary>
        [JsonPropertyName("shippingId")]
        public long ShippingId { get; set; }

        /// <summary>
        /// 扫描站点名称
        /// </summary>
        [JsonPropertyName("siteName")]
        public string SiteName { get; set; }

        /// <summary>
        /// 扫描站点编码 站点编号(各快递公司用于区分站点的唯一id)
        /// </summary>
        [JsonPropertyName("siteNo")]
        public string SiteNo { get; set; }

        /// <summary>
        /// 扫描站点类型 1:网点；2:中转中心；3:代收点
        /// </summary>
        [JsonPropertyName("siteType")]
        public int? SiteType { get; set; }

        /// <summary>
        /// 轨迹状态 如：GOT、SEND
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 运单号
        /// </summary>
        [JsonPropertyName("trackingNumber")]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// 物流号 物流订单号
        /// </summary>
        [JsonPropertyName("trackingOrderNo")]
        public string TrackingOrderNo { get; set; }

    }

}

