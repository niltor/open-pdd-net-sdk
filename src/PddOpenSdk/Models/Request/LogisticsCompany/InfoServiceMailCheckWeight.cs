namespace PddOpenSdk.Models.Request.LogisticsCompany;
public partial class InfoServiceMailCheckWeight
{

    /// <summary>
    /// 请求参数
    /// </summary>
    [JsonPropertyName("request")]
    public RequestModel Request { get; set; }
    public partial class RequestModel
    {

        /// <summary>
        /// 物流环节首发或到达省中心称重，单位克
        /// </summary>
        [JsonPropertyName("centerWeight")]
        public int? CenterWeight { get; set; }

        /// <summary>
        /// 结算重量，单位克
        /// </summary>
        [JsonPropertyName("checkWeight")]
        public int CheckWeight { get; set; }

        /// <summary>
        /// 快递公司编码
        /// </summary>
        [JsonPropertyName("expressCode")]
        public string ExpressCode { get; set; }

        /// <summary>
        /// 是否使用抛重
        /// </summary>
        [JsonPropertyName("isUseVolumetric")]
        public bool IsUseVolumetric { get; set; }

        /// <summary>
        /// 运单号
        /// </summary>
        [JsonPropertyName("mailNo")]
        public string MailNo { get; set; }

        /// <summary>
        /// 抛重体积
        /// </summary>
        [JsonPropertyName("volume")]
        public int? Volume { get; set; }

    }

}

