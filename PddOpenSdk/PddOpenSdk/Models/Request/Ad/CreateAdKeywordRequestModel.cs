using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class CreateAdKeywordRequestModel : PddRequestModel
    {
        /// <summary>
        /// 0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）
        /// </summary>
        [JsonProperty("scene_type")]
        public int SceneType { get; set; }
        /// <summary>
        /// 单元id
        /// </summary>
        [JsonProperty("unit_id")]
        public long UnitId { get; set; }
        /// <summary>
        /// [{"word":"test","bid":200}]
        /// </summary>
        [JsonProperty("keywords")]
        public List<KeywordsRequestModel> Keywords { get; set; }
        public partial class KeywordsRequestModel : PddRequestModel
        {
            /// <summary>
            /// 关键字出价（厘）范围需在0.10~99.0元区间内
            /// </summary>
            [JsonProperty("bid")]
            public long Bid { get; set; }
            /// <summary>
            /// 关键词
            /// </summary>
            [JsonProperty("word")]
            public string Word { get; set; }

        }

    }

}
