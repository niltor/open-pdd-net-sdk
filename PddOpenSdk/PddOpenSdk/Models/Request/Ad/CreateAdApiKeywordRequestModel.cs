using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class CreateAdApiKeywordRequestModel : PddRequestModel
    {
        /// <summary>
        /// 广告单元Id
        /// </summary>
        [JsonProperty("adId")]
        public long AdId { get; set; }
        /// <summary>
        /// 关键词创建信息列表
        /// </summary>
        [JsonProperty("keywordList")]
        public List<KeywordListRequestModel> KeywordList { get; set; }
        public partial class KeywordListRequestModel : PddRequestModel
        {
            /// <summary>
            /// 关键词出价
            /// </summary>
            [JsonProperty("bid")]
            public long Bid { get; set; }
            /// <summary>
            /// 关键词溢价比例。万分比。
            /// </summary>
            [JsonProperty("premiumRate")]
            public long? PremiumRate { get; set; }
            /// <summary>
            /// 关键词
            /// </summary>
            [JsonProperty("word")]
            public string Word { get; set; }

        }

    }

}
