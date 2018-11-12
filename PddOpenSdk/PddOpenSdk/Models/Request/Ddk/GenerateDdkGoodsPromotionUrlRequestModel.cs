using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ddk
{
    public partial class GenerateDdkGoodsPromotionUrlRequestModel : PddRequestModel
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
        /// 是否开启订单拉新，true表示开启（订单拉新奖励特权仅支持白名单，请联系工作人员开通）
        /// </summary>
        [JsonProperty("pull_new")]
        public bool? PullNew { get; set; }
        /// <summary>
        /// 是否生成唤起微信客户端链接，true-是，false-否，默认false
        /// </summary>
        [JsonProperty("generate_weapp_webview")]
        public bool? GenerateWeappWebview { get; set; }
        /// <summary>
        /// 招商多多客ID
        /// </summary>
        [JsonProperty("zs_duo_id")]
        public long ZsDuoId { get; set; }
        public partial class GoodsIdListRequestModel : PddRequestModel
        {

        }

    }

}
