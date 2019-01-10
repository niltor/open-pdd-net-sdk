using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class ListAdQueryBidRequestModel : PddRequestModel
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

    }

}
