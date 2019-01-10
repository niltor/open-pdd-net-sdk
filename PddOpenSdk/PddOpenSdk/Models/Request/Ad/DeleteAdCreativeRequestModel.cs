using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class DeleteAdCreativeRequestModel : PddRequestModel
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty("creative_id")]
        public long CreativeId { get; set; }
        /// <summary>
        /// 0:搜索广告
        /// </summary>
        [JsonProperty("scene_type")]
        public int SceneType { get; set; }

    }

}
