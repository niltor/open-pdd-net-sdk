using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GenDdkGoodsZsUnitUrlResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("goods_zs_unit_generate_response")]
        public GoodsZsUnitGenerateResponseResponseModel GoodsZsUnitGenerateResponse { get; set; }

        public partial class GoodsZsUnitGenerateResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 多多推广网址链接
            /// </summary>
            [JsonProperty("url")]
            public string Url { get; set; }
            /// <summary>
            /// 多多推广网址短连接
            /// </summary>
            [JsonProperty("short_url")]
            public string ShortUrl { get; set; }
            /// <summary>
            /// 多多推广移动链接
            /// </summary>
            [JsonProperty("mobile_url")]
            public string MobileUrl { get; set; }
            /// <summary>
            /// 多多推广移动短链接
            /// </summary>
            [JsonProperty("mobile_short_url")]
            public string MobileShortUrl { get; set; }
            /// <summary>
            /// 多多推广多人团链接
            /// </summary>
            [JsonProperty("multi_group_url")]
            public string MultiGroupUrl { get; set; }
            /// <summary>
            /// 多多推广多人团短链接
            /// </summary>
            [JsonProperty("multi_group_short_url")]
            public string MultiGroupShortUrl { get; set; }
            /// <summary>
            /// 多多推广多人团移动链接
            /// </summary>
            [JsonProperty("multi_group_mobile_url")]
            public string MultiGroupMobileUrl { get; set; }
            /// <summary>
            /// 红包推广多人团移动短链接
            /// </summary>
            [JsonProperty("multi_group_mobile_short_url")]
            public string MultiGroupMobileShortUrl { get; set; }

        }

    }
}
