using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class UpdateAdApiKeywordRequestModel : PddRequestModel
    {
        /// <summary>
        /// 广告单元Id
        /// </summary>
        [JsonProperty("adId")]
        public long AdId { get; set; }
        /// <summary>
        /// 关键词列表
        /// </summary>
        [JsonProperty("keywords")]
        public List<KeywordsRequestModel> Keywords { get; set; }
        public partial class KeywordsRequestModel : PddRequestModel
        {
            /// <summary>
            /// 关键词出价
            /// </summary>
            [JsonProperty("bid")]
            public long Bid { get; set; }
            /// <summary>
            /// 关键词Id
            /// </summary>
            [JsonProperty("keywordId")]
            public long KeywordId { get; set; }
            /// <summary>
            /// 关键词溢价比例。万分比。
            /// </summary>
            [JsonProperty("premiumRate")]
            public long? PremiumRate { get; set; }

        }

    }

}
