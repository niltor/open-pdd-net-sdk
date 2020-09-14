using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class RateAdApiUnitCreativeQueryFlowRequestModel : PddRequestModel
    {
        /// <summary>
        /// 广告单元Id
        /// </summary>
        [JsonProperty("adId")]
        public long AdId { get; set; }

    }

}
