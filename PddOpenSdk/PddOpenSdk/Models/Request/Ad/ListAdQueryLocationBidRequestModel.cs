using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class ListAdQueryLocationBidRequestModel : PddRequestModel {
        /// <summary>
        /// 推广类型  2-展示推广
        /// </summary>
        [JsonProperty ("scene_type")]
        public int SceneType { get; set; }
        /// <summary>
        /// 单元id
        /// </summary>
        [JsonProperty ("unit_id")]
        public long UnitId { get; set; }

    }

}