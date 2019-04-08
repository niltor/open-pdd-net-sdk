using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class BidAdDeleteRequestModel : PddRequestModel {
        /// <summary>
        /// 推广类型  2-展示推广
        /// </summary>
        [JsonProperty ("scene_type")]
        public int SceneType { get; set; }
        /// <summary>
        /// 单元ID
        /// </summary>
        [JsonProperty ("unit_id")]
        public long UnitId { get; set; }
        /// <summary>
        /// 定向ID，不能删除全体人群定向。 List<Long>的json string。示例[111,222,333]
        /// </summary>
        [JsonProperty ("bid_ids")]
        public string BidIds { get; set; }

    }

}