using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddktools
{
    public partial class GenDdkOauthGoodsZsUnitUrlResponseModel : PddResponseModel
    {
        /// <summary>
        /// goods_zs_unit_generate_response
        /// </summary>
        [JsonProperty("goods_zs_unit_generate_response")]
        public GoodsZsUnitGenerateResponseResponseModel GoodsZsUnitGenerateResponse { get; set; }
        public partial class GoodsZsUnitGenerateResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 单人团推广长链接
            /// </summary>
            [JsonProperty("url")]
            public string Url { get; set; }
            /// <summary>
            /// 单人团推广短链接
            /// </summary>
            [JsonProperty("short_url")]
            public string ShortUrl { get; set; }
            /// <summary>
            /// 推广长链接（唤起拼多多app）
            /// </summary>
            [JsonProperty("mobile_url")]
            public string MobileUrl { get; set; }
            /// <summary>
            /// 推广短链接（可唤起拼多多app）
            /// </summary>
            [JsonProperty("mobile_short_url")]
            public string MobileShortUrl { get; set; }
            /// <summary>
            /// 双人团推广长链接
            /// </summary>
            [JsonProperty("multi_group_url")]
            public string MultiGroupUrl { get; set; }
            /// <summary>
            /// 双人团推广短链接
            /// </summary>
            [JsonProperty("multi_group_short_url")]
            public string MultiGroupShortUrl { get; set; }
            /// <summary>
            /// 推广长链接（可唤起拼多多app）
            /// </summary>
            [JsonProperty("multi_group_mobile_url")]
            public string MultiGroupMobileUrl { get; set; }
            /// <summary>
            /// 推广短链接（唤起拼多多app）
            /// </summary>
            [JsonProperty("multi_group_mobile_short_url")]
            public string MultiGroupMobileShortUrl { get; set; }
            /// <summary>
            /// schema的链接
            /// </summary>
            [JsonProperty("schema_url")]
            public string SchemaUrl { get; set; }

        }

    }

}
