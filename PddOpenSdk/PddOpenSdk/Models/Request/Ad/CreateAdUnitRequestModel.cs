using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class CreateAdUnitRequestModel : PddRequestModel
    {
        /// <summary>
        /// 推广类型，0-搜索推广，2-展示推广; scene type为0的时候，keywords必填，bid不用填；scene type为2的时候，keywords不用填，bid必填
        /// </summary>
        [JsonProperty("scene_type")]
        public int SceneType { get; set; }
        /// <summary>
        /// 计划id
        /// </summary>
        [JsonProperty("plan_id")]
        public long PlanId { get; set; }
        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("goods_id")]
        public long GoodsId { get; set; }
        /// <summary>
        /// [{"word":"test","bid":200}]
        /// </summary>
        [JsonProperty("keywords")]
        public List<KeywordsRequestModel> Keywords { get; set; }
        /// <summary>
        /// 创意列表 [{"image_url":"123.jpg","title":"test"}]
        /// </summary>
        [JsonProperty("creative_list")]
        public List<CreativeListRequestModel> CreativeList { get; set; }
        /// <summary>
        /// 通投单元出价，单位厘，出价需在0.10~99.0元区间内。展示推广必填
        /// </summary>
        [JsonProperty("bid")]
        public long? Bid { get; set; }
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
        public partial class CreativeListRequestModel : PddRequestModel
        {
            /// <summary>
            /// 图片地址
            /// </summary>
            [JsonProperty("image_url")]
            public string ImageUrl { get; set; }
            /// <summary>
            /// 标题
            /// </summary>
            [JsonProperty("title")]
            public string Title { get; set; }

        }

    }

}
