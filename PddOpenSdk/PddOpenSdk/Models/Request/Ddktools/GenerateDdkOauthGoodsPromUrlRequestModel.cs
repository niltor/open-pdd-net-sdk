using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ddktools
{
    public partial class GenerateDdkOauthGoodsPromUrlRequestModel : PddRequestModel
    {
        /// <summary>
        /// 推广位ID
        /// </summary>
        [JsonProperty("p_id")]
        public string PId { get; set; }
        /// <summary>
        /// 商品ID，仅支持单个查询
        /// </summary>
        [JsonProperty("goods_id_list")]
        public List<long> GoodsIdList { get; set; }
        /// <summary>
        /// 是否生成短链接，true-是，false-否
        /// </summary>
        [JsonProperty("generate_short_url")]
        public bool? GenerateShortUrl { get; set; }
        /// <summary>
        /// true--生成多人团推广链接 false--生成单人团推广链接（默认false）1、单人团推广链接：用户访问单人团推广链接，可直接购买商品无需拼团。2、多人团推广链接：用户访问双人团推广链接开团，若用户分享给他人参团，则开团者和参团者的佣金均结算给推手
        /// </summary>
        [JsonProperty("multi_group")]
        public bool? MultiGroup { get; set; }
        /// <summary>
        /// 自定义参数，为链接打上自定义标签。自定义参数最长限制64个字节。
        /// </summary>
        [JsonProperty("custom_parameters")]
        public string CustomParameters { get; set; }
        /// <summary>
        /// 是否生成唤起微信客户端链接，true-是，false-否，默认false
        /// </summary>
        [JsonProperty("generate_weapp_webview")]
        public bool? GenerateWeappWebview { get; set; }
        /// <summary>
        /// 招商多多客ID
        /// </summary>
        [JsonProperty("zs_duo_id")]
        public long? ZsDuoId { get; set; }
        /// <summary>
        /// 是否生成小程序推广
        /// </summary>
        [JsonProperty("generate_we_app")]
        public bool? GenerateWeApp { get; set; }
        /// <summary>
        /// 是否生成微博推广
        /// </summary>
        [JsonProperty("generate_weiboapp_webview")]
        public bool? GenerateWeiboappWebview { get; set; }
        /// <summary>
        /// 是否返回 schema URL
        /// </summary>
        [JsonProperty("generate_schema_url")]
        public bool? GenerateSchemaUrl { get; set; }
        /// <summary>
        /// 是否使用多多客专属推广计划
        /// </summary>
        [JsonProperty("force_duo_id")]
        public bool? ForceDuoId { get; set; }
        /// <summary>
        /// 是否生成qq小程序
        /// </summary>
        [JsonProperty("generate_qq_app")]
        public bool? GenerateQqApp { get; set; }
        /// <summary>
        /// 搜索id
        /// </summary>
        [JsonProperty("search_id")]
        public string SearchId { get; set; }

    }

}
