using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class UpdateAdCreativeRequestModel : PddRequestModel {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty ("creative_id")]
        public long CreativeId { get; set; }
        /// <summary>
        /// 0:搜索广告
        /// </summary>
        [JsonProperty ("scene_type")]
        public int SceneType { get; set; }
        /// <summary>
        /// jsonObject 的json string。 示例：{"title":"ceshi","image_url":"https://img12.360buyimg.com/n7/g14/M07/16/00/rBEhVlJfpdwIAAAAAADurQhBHX0AAETNABbGNkAAO7F355.jpg"}
        /// </summary>
        [JsonProperty ("creative")]
        public CreativeRequestModel Creative { get; set; }
        public partial class CreativeRequestModel : PddRequestModel {
            /// <summary>
            /// 图片地址
            /// </summary>
            [JsonProperty ("image_url")]
            public string ImageUrl { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty ("title")]
            public string Title { get; set; }

        }

    }

}