namespace PddOpenSdk.Models.Response.Ddk;
public partial class GenDdkGoodsZsUnitUrlResponse : PddResponseModel
{

    /// <summary>
    /// goods_zs_unit_generate_response
    /// </summary>
    [JsonPropertyName("goods_zs_unit_generate_response")]
    public GoodsZsUnitGenerateResponseResponse GoodsZsUnitGenerateResponse { get; set; }
    public partial class GoodsZsUnitGenerateResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 推广短链接（可唤起拼多多app）
        /// </summary>
        [JsonPropertyName("mobile_short_url")]
        public string MobileShortUrl { get; set; }

        /// <summary>
        /// 推广长链接（唤起拼多多app）
        /// </summary>
        [JsonPropertyName("mobile_url")]
        public string MobileUrl { get; set; }

        /// <summary>
        /// 推广短链接（唤起拼多多app）
        /// </summary>
        [JsonPropertyName("multi_group_mobile_short_url")]
        public string MultiGroupMobileShortUrl { get; set; }

        /// <summary>
        /// 推广长链接（可唤起拼多多app）
        /// </summary>
        [JsonPropertyName("multi_group_mobile_url")]
        public string MultiGroupMobileUrl { get; set; }

        /// <summary>
        /// 双人团推广短链接
        /// </summary>
        [JsonPropertyName("multi_group_short_url")]
        public string MultiGroupShortUrl { get; set; }

        /// <summary>
        /// 双人团推广长链接
        /// </summary>
        [JsonPropertyName("multi_group_url")]
        public string MultiGroupUrl { get; set; }

        /// <summary>
        /// 对应出参url的短链接，与url功能一致。
        /// </summary>
        [JsonPropertyName("short_url")]
        public string ShortUrl { get; set; }

        /// <summary>
        /// 普通推广长链接，唤起H5页面
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

    }

}

