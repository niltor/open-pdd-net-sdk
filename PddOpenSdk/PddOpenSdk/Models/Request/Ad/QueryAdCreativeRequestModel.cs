using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class QueryAdCreativeRequestModel : PddRequestModel {
        /// <summary>
        /// 单元id
        /// </summary>
        [JsonProperty ("unit_id")]
        public long UnitId { get; set; }
        /// <summary>
        /// 格式："yyyy-MM-dd" 时区："GMT+8"
        /// </summary>
        [JsonProperty ("begin_date")]
        public string BeginDate { get; set; }
        /// <summary>
        /// 格式："yyyy-MM-dd" 时区："GMT+8"
        /// </summary>
        [JsonProperty ("end_date")]
        public string EndDate { get; set; }
        /// <summary>
        /// 0:搜索广告
        /// </summary>
        [JsonProperty ("scene_type")]
        public int SceneType { get; set; }

    }

}