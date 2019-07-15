using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Adplan
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
