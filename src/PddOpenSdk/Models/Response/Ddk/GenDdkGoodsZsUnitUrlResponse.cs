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
        /// 对应出参mobile_url的短链接，与mobile_url功能一致
        /// </summary>
        [JsonPropertyName("mobile_short_url")]
        public string MobileShortUrl { get; set; }

        /// <summary>
        /// 普通长链，微信环境下进入领券页点领券拉起小程序，浏览器环境下直接拉起APP，未安装拼多多APP时落地页点领券拉起登录页
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
        /// 对应出参url的短链接，与url功能一致
        /// </summary>
        [JsonPropertyName("short_url")]
        public string ShortUrl { get; set; }

        /// <summary>
        /// 普通长链。微信环境下进入领券页点领券拉起小程序，浏览器环境下优先拉起微信小程序
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// 小程序短链，点击可直接唤起微信小程序
        /// </summary>
        [JsonPropertyName("weixin_short_link")]
        public string WeixinShortLink { get; set; }

    }

}

