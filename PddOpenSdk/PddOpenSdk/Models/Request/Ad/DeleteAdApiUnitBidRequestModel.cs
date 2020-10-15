using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class DeleteAdApiUnitBidRequestModel : PddRequestModel
    {
        /// <summary>
        /// 广告单元Id
        /// </summary>
        [JsonProperty("adId")]
        public long AdId { get; set; }
        /// <summary>
        /// 出价Id列表
        /// </summary>
        [JsonProperty("bidIds")]
        public List<long> BidIds { get; set; }

    }

}
