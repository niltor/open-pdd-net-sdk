using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ddkoauth
{
    public partial class GenDdkOauthGoodsZsUnitUrlRequestModel : PddRequestModel {
        /// <summary>
        /// 需转链的链接
        /// </summary>
        [JsonProperty ("source_url")]
        public string SourceUrl { get; set; }
        /// <summary>
        /// 渠道id
        /// </summary>
        [JsonProperty ("pid")]
        public string Pid { get; set; }

    }

}