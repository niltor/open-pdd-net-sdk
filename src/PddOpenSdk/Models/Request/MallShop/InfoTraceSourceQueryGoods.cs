namespace PddOpenSdk.Models.Request.MallShop;
public partial class InfoTraceSourceQueryGoods
{

    /// <summary>
    /// 请求方法
    /// </summary>
    [JsonPropertyName("httpMethod")]
    public string HttpMethod { get; set; }

    /// <summary>
    /// 请求参数
    /// </summary>
    [JsonPropertyName("params")]
    public ParamsModel Params { get; set; }
    public partial class ParamsModel
    {

        /// <summary>
        /// 接口调用账号（由平台分配）
        /// </summary>
        [JsonPropertyName("userid")]
        public string Userid { get; set; }

        /// <summary>
        /// 请求时间戳，10分钟有效，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonPropertyName("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 防伪溯源码ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

    }

}

