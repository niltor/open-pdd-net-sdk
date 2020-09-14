using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class CreativeAdApiUnitCreativeUpdateSmartRequestModel : PddRequestModel
    {
        /// <summary>
        /// 标题
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
        /// <summary>
        /// 创意单元Id
        /// </summary>
        [JsonProperty("unitCreativeId")]
        public long UnitCreativeId { get; set; }

    }

}
