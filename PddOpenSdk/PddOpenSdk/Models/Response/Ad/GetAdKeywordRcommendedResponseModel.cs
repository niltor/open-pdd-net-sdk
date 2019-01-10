using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class GetAdKeywordRcommendedResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("ad_recommended_keyword_list_response")]
        public AdRecommendedKeywordListResponseResponseModel AdRecommendedKeywordListResponse { get; set; }
        public partial class AdRecommendedKeywordListResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 推荐关键字列表
            /// </summary>
            [JsonProperty("recommended_keyword_list")]
            public List<RecommendedKeywordListResponseModel> RecommendedKeywordList { get; set; }
            public partial class RecommendedKeywordListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 分数
                /// </summary>
                [JsonProperty("score")]
                public double? Score { get; set; }
                /// <summary>
                /// 热度
                /// </summary>
                [JsonProperty("heat")]
                public double? Heat { get; set; }
                /// <summary>
                /// 趋势
                /// </summary>
                [JsonProperty("trend")]
                public double? Trend { get; set; }
                /// <summary>
                /// 竞争力
                /// </summary>
                [JsonProperty("compete")]
                public double? Compete { get; set; }
                /// <summary>
                /// 平均出价
                /// </summary>
                [JsonProperty("avg_bid")]
                public double? AvgBid { get; set; }
                /// <summary>
                /// 相关性
                /// </summary>
                [JsonProperty("relevance")]
                public int? Relevance { get; set; }
                /// <summary>
                /// 关键词
                /// </summary>
                [JsonProperty("word")]
                public string Word { get; set; }

            }

        }

    }

}
