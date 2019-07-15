using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Adplan
{
    public partial class BidAdDeleteLocationRequestModel : PddRequestModel
    {
        /// <summary>
        /// 推广类型  2-展示推广
        /// </summary>
        [JsonProperty("scene_type")]
        public int SceneType { get; set; }
        /// <summary>
        /// 单元ID
        /// </summary>
        [JsonProperty("unit_id")]
        public long UnitId { get; set; }
        /// <summary>
        /// 资源位ID, List<Long>的json string
        /// </summary>
        [JsonProperty("location_bid_ids")]
        public string LocationBidIds { get; set; }

    }

}
