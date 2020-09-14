using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class ProfileAdApiUnitBidQueryAudienceRequestModel : PddRequestModel
    {
        /// <summary>
        /// 渠道类型 2 - 场景单品推广, 4 - 搜索推广
        /// </summary>
        [JsonProperty("deliverType")]
        public int DeliverType { get; set; }

    }

}
