using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class DeleteAdApiKeywordRequestModel : PddRequestModel
    {
        /// <summary>
        /// 广告单元Id
        /// </summary>
        [JsonProperty("adId")]
        public long AdId { get; set; }
        /// <summary>
        /// 关键词Id列表
        /// </summary>
        [JsonProperty("keywordIds")]
        public List<long> KeywordIds { get; set; }

    }

}
